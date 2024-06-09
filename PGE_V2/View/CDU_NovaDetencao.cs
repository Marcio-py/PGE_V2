using PGE_V2.Controler;
using PGE_V2.Dados;
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
            cmbTipoDocumento.DataSource = Listar_DocumentoValido();
            cmbTipoDocumento.DisplayMember = "Tipo_Documentos_validos";
            //cmbTipoDocumento.ValueMember = "Tipo_Documentos_validos";

            cmbTipo_Acusacoa.DataSource = ListarTipoAcusacao();
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

        public void Limpa_Campos()
        {
            text_num_Bi.Text = "";
            text_nome.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            txtDetalhes.Text = "";
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

        public DataTable Listar_DocumentoValido()
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

        public DataTable ListarTipoAcusacao()
        {
            DataTable dt = new DataTable();

            string connectionString = "Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True;";
            string query = "SELECT Id_Tipo_Detencao, Descricao_Tipo_Detencao FROM Tipo_Detencao";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                        sqlDataAdapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions (log, display an error message, etc.)
                        Console.WriteLine($"Error: {ex.Message}");
                        throw;
                    }
                }
            }

            return dt;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
                if (valida_campos_detencao() == false || Verifica_SeExiste_NaBD(text_num_Bi.Text) == true )
                {
                    return;

                }

                UsuarioController.Salvar_DadosPessoais(
                    text_num_Bi.Text, 
                    text_nome.Text, textBox1.Text, 
                    textBox2.Text, 
                    textBox3.Text, 
                    comboBoxGenero.Text);
                
                int argumento_PesquisaDadosPessoais = UsuarioController.Pesquisar_IDDadosPessoais(text_num_Bi.Text);
                UsuarioController.Salvar_Detencao(argumento_PesquisaDadosPessoais, txtDetalhes.Text);

                UsuarioController.Salvar_Documento(text_num_Bi.Text, cmbTipoDocumento.Text);
                MessageBox.Show("Adicionado um processo de detenção");
                Limpa_Campos();
            }
        }
    }

