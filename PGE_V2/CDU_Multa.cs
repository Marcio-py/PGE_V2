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


                conexao.Open();
                comando.ExecuteNonQuery();
                Registar_Multa();

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
