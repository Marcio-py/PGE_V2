using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGE_V2
{
    public partial class CDU_Multa : UserControl
    {
        SqlConnection conexao;
        SqlCommand comando;
        //SqlDataReader dr;

        string strSQL;
        public CDU_Multa()
        {
            InitializeComponent();
            cmbTipoDocumento.DataSource = Buscar_DocumentoValido();
            cmbTipoDocumento.DisplayMember = "Tipo_Documentos_validos";
        }

        public DataTable Buscar_DocumentoValido()
        {
            DataTable dt = new DataTable();

            conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");

            comando = new SqlCommand("SELECT Tipo_Documentos_validos FROM Documentos_validos", conexao);
            //comando.Connection = conexao;   
            //dr = comando.ExecuteReader();
            conexao.Open();
            try
            {
                SqlDataAdapter slqDat = new SqlDataAdapter(comando);
                slqDat.Fill(dt);

            }
            catch (Exception)
            {

                throw;
            }


            conexao.Close();
            return dt;
        }

        public void limpa_Campos()
        {
            text_num_Bi.Text = "";
            text_nome.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBoxGenero.Text = "";
        }

        public bool valida_campos_detencao()
        {
            if (!string.IsNullOrEmpty(text_nome.Text) && !string.IsNullOrEmpty(text_num_Bi.Text) &&
               !string.IsNullOrEmpty(txtDetalhes.Text) && !string.IsNullOrEmpty(text_idLogin.Text))
            {
                MessageBox.Show("Campos preenchidos ");
                return true;

            }
            else
            {
                MessageBox.Show("Por favor preencha os campos");
                return false;
            }
        }

        public bool Verifica_SeExiste_NaBD(string numeroBI)
        {
            using (SqlConnection conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True;"))
            {
                conexao.Open();
                string strSQL = "SELECT COUNT(*) FROM Dados_Pessoais WHERE Nº_BI = @Nº_BI";
                using (SqlCommand comando = new SqlCommand(strSQL, conexao))
                {
                    comando.Parameters.AddWithValue("@Nº_BI", numeroBI);
                    int count = (int)comando.ExecuteScalar();

                    // Check if the count is greater than 0 (record exists)
                    if (count > 0)
                    {
                        MessageBox.Show("Já existe alguém na base de dados com esse numero de docoumento");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public DataTable Registar_Multa()
        {
            DataTable dt = new DataTable();

            conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
            strSQL = "INSERT INTO Multa (Id_Login,Nº_Doc, Descricao_Multa) VALUES (@Id_Login,@Nº_Doc, @Descricao_Multa)";
            comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@Id_Login", text_idLogin.Text);
            comando.Parameters.AddWithValue("@Nº_Doc", text_num_Bi.Text);
            comando.Parameters.AddWithValue("@Descricao_Multa", txtDetalhes.Text);


            conexao.Open();
            comando.ExecuteNonQuery();

            return dt;
        }

        private DataTable salvar_tipo_documento(string Nº_Documento, string Descricao)
        {
            DataTable dt = new DataTable();

            conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
            strSQL = "INSERT INTO Tipo_Documento (Nº_Documento,Estado, Descricao_Tipo_Documento) VALUES (@Nº_Documento,@Estado, @Descricao_Tipo_Documento)";
            comando = new SqlCommand(strSQL, conexao);

            //comando.Parameters.AddWithValue("@Nº_Documento", label2.Text);
            comando.Parameters.AddWithValue("@Nº_Documento", $"{Nº_Documento}");
            comando.Parameters.AddWithValue("@Estado", 1);
            comando.Parameters.AddWithValue("@Descricao_Tipo_Documento", $"{Descricao}");


            conexao.Open();
            comando.ExecuteNonQuery();

            conexao.Close();
            return dt;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
                strSQL = "INSERT INTO Dados_Pessoais (Nº_BI, Nome_Completo, Filho_de, E_de, Data_nasc, Genero) VALUES (@Nº_BI, @Nome_Completo, @Filho_de, @E_de, @Data_nasc, @Genero)";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Nº_BI", text_num_Bi.Text);
                comando.Parameters.AddWithValue("@Nome_Completo", text_nome.Text);
                comando.Parameters.AddWithValue("@Filho_de", textBox1.Text);
                comando.Parameters.AddWithValue("@e_de", textBox2.Text);
                comando.Parameters.AddWithValue("@Data_nasc", textBox3.Text);
                comando.Parameters.AddWithValue("@genero", comboBoxGenero.Text);


                // SE  a funçaovalida_campos_detencao for falso, significa que os campos estão vazios e cancela a operação
                // SE  a funçao Verifica_SeExiste_NaBD retornar true,significa o nº documento já existe e cancela a operação
                if (valida_campos_detencao() == false || Verifica_SeExiste_NaBD(text_num_Bi.Text))
                {
                    return;

                }

                conexao.Open();
                comando.ExecuteNonQuery();

                Registar_Multa();
                salvar_tipo_documento(text_num_Bi.Text, cmbTipoDocumento.Text);

                MessageBox.Show("Registado com Sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
