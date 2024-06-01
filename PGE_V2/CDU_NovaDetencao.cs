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
    public partial class CDU_NovaDetencao : UserControl
    {
        SqlConnection conexao;
        SqlCommand comando;
        //SqlDataReader dr;
        string strSQL;

        public CDU_NovaDetencao()
        {
            InitializeComponent();
            cmbTipoDocumento.DataSource = Buscar_DocumentoValido();
            cmbTipoDocumento.DisplayMember = "Tipo_Documentos_validos";
            //cmbTipoDocumento.ValueMember = "Tipo_Documentos_validos";

            cmbTipo_Acusacoa.DataSource = Buscar_Tipo_Acusacao();
            cmbTipo_Acusacoa.DisplayMember = "Descricao_Tipo_Detencao";
            cmbTipo_Acusacoa.ValueMember = "Id_Tipo_Detencao";
        }

        public DataTable Buscar_Tipo_Documento()
        {
            DataTable dt = new DataTable();

            conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");

            comando = new SqlCommand("SELECT Nº_Documento,Descricao_Tipo_Documento FROM Tipo_Documento WHERE Estado = 1", conexao);
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
               !string.IsNullOrEmpty(txtDetalhes.Text)) 
            {
               // MessageBox.Show("Campos preenchidos ");
                return true;
                
            } else
            {
                MessageBox.Show("Por favor preencha os campos");
                return false;
            }
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
                        MessageBox.Show("Já existe um usuario na base de dados com esse numero de docoumento");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public DataTable Buscar_Tipo_Acusacao()
        {
            DataTable dt = new DataTable();

            conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");

            comando = new SqlCommand("SELECT Id_Tipo_Detencao,Descricao_Tipo_Detencao FROM Tipo_Detencao", conexao);
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
        public DataTable BuscarId_DadosPessoais()
        {
            DataTable dt = new DataTable();

            conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
            conexao.Open();
            strSQL = "SELECT Id_Dados_Pessoais FROM Dados_Pessoais WHERE Nº_BI = @Nº_BI";
            comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@Nº_BI", text_num_Bi.Text);
            comando.Connection = conexao;
            SqlDataReader red = comando.ExecuteReader();
            while (red.Read())
            {
                label2.Text = red["Id_Dados_Pessoais"].ToString();


            }
            red.Close();
            conexao.Close();
            return dt;
        }

        public DataTable Registar_Acusacao()
        {
            DataTable dt = new DataTable();

            conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
            strSQL = "INSERT INTO Detecao (Id_Dados_Pessoais,Id_Login, Detalhes_Detecao) VALUES (@Id_Dados_Pessoais,@Id_Login, @Detalhes_Detecao)";
            comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@Id_Dados_Pessoais", label2.Text);
            comando.Parameters.AddWithValue("@Id_Login", 1);
            comando.Parameters.AddWithValue("@Detalhes_Detecao", txtDetalhes.Text);


            conexao.Open();
            comando.ExecuteNonQuery();

            conexao.Close();
            return dt;
        }

        private DataTable salvar_tipo_documento(string Documento, string Descricao)
        {
            DataTable dt = new DataTable();

            conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
            strSQL = "INSERT INTO Tipo_Documento (Nº_Documento,Estado, Descricao_Tipo_Documento) VALUES (@Nº_Documento,@Estado, @Descricao_Tipo_Documento)";
            comando = new SqlCommand(strSQL, conexao);

            //comando.Parameters.AddWithValue("@Nº_Documento", label2.Text);
            comando.Parameters.AddWithValue("@Nº_Documento", $"{Documento}");
            comando.Parameters.AddWithValue("@Estado", 1);
            comando.Parameters.AddWithValue("@Descricao_Tipo_Documento", $"{Descricao}");


            conexao.Open();
            comando.ExecuteNonQuery();

            conexao.Close();
            return dt;
        }

        private void label_filho_de_Click(object sender, EventArgs e)
        {

        }

        private void label_e_de_Click(object sender, EventArgs e)
        {

        }

        private void text_num_Bi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
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
                if (valida_campos_detencao() == false || Verifica_SeExiste_NaBD(text_num_Bi.Text) == true )
                {
                    return;

                }

                conexao.Open();
                comando.ExecuteNonQuery();

                
                BuscarId_DadosPessoais();
                Registar_Acusacao();
                salvar_tipo_documento(text_num_Bi.Text, cmbTipoDocumento.Text);
                MessageBox.Show("Registado com Sucesso");
                limpa_Campos();
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
