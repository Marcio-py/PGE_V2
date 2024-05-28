using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PGE_V2
{
    public partial class Tela_Inicial : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        //SqlDataReader dr;

        string strSQL;
        public Tela_Inicial()
        {
            InitializeComponent();
            cdU_DetalhesDetencao1.Hide();
            cdU_NovaDetencao1.Hide();
            cduApreensao1.Hide();
        }

        public DataTable salvar_tipo_documento(string textBox_Ndocumento, string textBox_descricao)
        {
            DataTable dt = new DataTable();

            conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
            strSQL = "INSERT INTO Tipo_Documento (Nº_Documento,Estado, Descricao_Tipo_Documento) VALUES (@Nº_Documento,@Estado, @Descricao_Tipo_Documento)";
            comando = new SqlCommand(strSQL, conexao);

            //comando.Parameters.AddWithValue("@Nº_Documento", label2.Text);
            comando.Parameters.AddWithValue("@Nº_Documento", $"{textBox_Ndocumento}.Text");
            comando.Parameters.AddWithValue("@Estado", 1);
            comando.Parameters.AddWithValue("@Descricao_Tipo_Documento", $"{textBox_descricao}.Text");


            conexao.Open();
            comando.ExecuteNonQuery();

            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Esconder CDU (CAMPO DE USUARIO)
            cdU_DetalhesDetencao1.Hide();
            // Mostrar CDU (CAMPO DE USUARIO)
            cdU_NovaDetencao1.Show();
            cdU_NovaDetencao1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Esconder CDU (CAMPO DE USUARIO)
            cdU_NovaDetencao1.Hide();
            // Mostrar CDU (CAMPO DE USUARIO)
            cdU_DetalhesDetencao1.Show();
            cdU_DetalhesDetencao1.BringToFront();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin Login = new TelaLogin();
            Login.ShowDialog();
        }

        private void cdU_DetalhesDetencao1_Load(object sender, EventArgs e)
        {

        }

        private void btn_apreensao_Click(object sender, EventArgs e)
        {
            // Esconder CDU (CAMPO DE USUARIO)
            cdU_NovaDetencao1.Hide();
            cdU_DetalhesDetencao1.Hide();
            // Mostrar CDU (CAMPO DE USUARIO)
            cduApreensao1.Show();
            cduApreensao1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Esconder CDU (CAMPO DE USUARIO)
            cdU_NovaDetencao1.Hide();
            cdU_DetalhesDetencao1.Hide();
            cduApreensao1.Hide();
            // Mostrar CDU (CAMPO DE USUARIO)
            cdU_Multa1.Show();
            cdU_Multa1.BringToFront();
        }
    }
}
