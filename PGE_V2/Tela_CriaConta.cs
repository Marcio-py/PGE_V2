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
using WindowsFormsApplication1;

namespace PGE_V2
{
    public partial class Tela_CriaConta : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        //SqlDataReader dr;

        string strSQL;
        public Tela_CriaConta()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin Login = new TelaLogin();
            Login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
                strSQL = "INSERT INTO Login (Senha, Estado) VALUES (@Senha, @Estado)";
                comando = new SqlCommand(strSQL, conexao);

                // Criar uma função que impede o usuario de inserir um ID existente
                //comando.Parameters.AddWithValue("@Id_Login", textBox3.Text);
                comando.Parameters.AddWithValue("@Senha", textBox2.Text);
                comando.Parameters.AddWithValue("@Estado", textBox1.Text);


                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Criou o seu login com Sucesso");
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
