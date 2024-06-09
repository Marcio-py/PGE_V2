using PGE_V2.Controler;
using PGE_V2.Modelos;
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
            textFilhoDe.Text = "";
            textEDe.Text = "";
            textNascimento.Text = "";
            comboBoxGenero.Text = "";
        }

        public bool valida_campos_detencao()
        {
            if (!string.IsNullOrEmpty(text_nome.Text) && !string.IsNullOrEmpty(text_num_Bi.Text) &&
               !string.IsNullOrEmpty(txtDetalhes.Text))
            {
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



        private void Salvar_Click(object sender, EventArgs e)
        {
            // SE  a funçaovalida_campos_detencao for falso, significa que os campos estão vazios e cancela a operação
            // SE  a funçao Verifica_SeExiste_NaBD retornar true,significa o nº documento já existe e cancela a operação
            if (valida_campos_detencao() == false || Verifica_SeExiste_NaBD(text_num_Bi.Text) == true)
            {
                return;

            }
            else
            {
                UsuarioController.Salvar_DadosPessoais(
                    text_num_Bi.Text,
                    text_nome.Text,
                    textFilhoDe.Text,
                    textEDe.Text,
                    textNascimento.Text,
                    comboBoxGenero.Text);

                UsuarioController.Salvar_Multa(Usuario_ativo.id_Login, int.Parse(text_num_Bi.Text), txtDetalhes.Text);
                UsuarioController.Salvar_Documento(text_num_Bi.Text, cmbTipoDocumento.Text);

                MessageBox.Show("Registado com Sucesso");
                limpa_Campos();
            }



        }
    }
}
