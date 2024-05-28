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

namespace WindowsFormsApplication1
{
    public partial class Nova_Detencao : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        //SqlDataReader dr;

        string strSQL;
        public Nova_Detencao()
        {
            InitializeComponent();
            cmbTipoDocumento.DataSource = Buscar_Tipo_Documento();
            cmbTipoDocumento.DisplayMember = "Descricao_Tipo_Documento";
            cmbTipoDocumento.ValueMember = "Nº_Documento";

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

        private DataTable salvar_tipo_documento(string textBox_Ndocumento, string textBox_descricao)
        {
            DataTable dt = new DataTable();

            conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
            strSQL = "INSERT INTO Tipo_Documento (Nº_Documento,Estado, Descricao_Tipo_Documento) VALUES (@Nº_Documento,@Estado, @Descricao_Tipo_Documento)";
            comando = new SqlCommand(strSQL, conexao);

            //comando.Parameters.AddWithValue("@Nº_Documento", label2.Text);
            comando.Parameters.AddWithValue("@Nº_Documento", $"{textBox_Ndocumento}");
            comando.Parameters.AddWithValue("@Estado", 1);
            comando.Parameters.AddWithValue("@Descricao_Tipo_Documento", $"{textBox_descricao}");


            conexao.Open();
            comando.ExecuteNonQuery();

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

            return dt;
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


                conexao.Open();
                comando.ExecuteNonQuery();

                
                BuscarId_DadosPessoais();
                Registar_Acusacao();
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

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarId_DadosPessoais();
        }
    }
}
