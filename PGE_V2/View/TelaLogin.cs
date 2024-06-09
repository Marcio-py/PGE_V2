using PGE_V2;
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

namespace WindowsFormsApplication1
{
    public partial class TelaLogin : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataReader dr;

        string strSQL;

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
                conexao.Open();

                // Dados do usuário
                strSQL = "SELECT * FROM Login WHERE Id_Login = @Id_Login";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Id_Login", textLogin.Text);
                comando.Connection = conexao;
                //comando.Parameters.AddWithValue("@Id_Login", TextSenha.Text);
                SqlDataReader red = comando.ExecuteReader();

                if (red.Read())
                {
                    if (!TextSenha.Text.Equals(red["Senha"]))
                    {
                        MessageBox.Show("Usuário ou senha incorretos");
                    }
                    else
                    {
                        MessageBox.Show("Bem vindo! Clique no ok para avançar", "Mensagem");
                        Usuario_ativo.Estado = (int)red["Estado"];
                        Usuario_ativo.id_Login = (int)red["Id_Login"];

                        this.Hide();
                        Tela_Inicial telaIncial = new Tela_Inicial();
                        telaIncial.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_CriaConta Registro = new Tela_CriaConta();
            Registro.ShowDialog();
        }

    }
}
