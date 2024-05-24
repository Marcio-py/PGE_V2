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
    public partial class Apreensao : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        //SqlDataReader dr;

        string strSQL;
        public Apreensao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
                strSQL = "INSERT INTO Apreensao (Id_Login, Nº_Documento, Data_Apreencao, Descricao_Apreensao) VALUES (@Id_Login, @Nº_Documento, @Data_Apreencao, @Descricao_Apreensao)";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Nº_Documento", N_doc.Text);
                comando.Parameters.AddWithValue("@Id_Login", ID_login.Text);
                comando.Parameters.AddWithValue("@Descricao_Apreensao", Descricao.Text);
                comando.Parameters.AddWithValue("@Data_Apreencao", DataAP.Text);


                conexao.Open();
                comando.ExecuteNonQuery();

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
