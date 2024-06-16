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
    public partial class CDU_DetalhesDetencao : UserControl
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter AdaptadorDados;

        public CDU_DetalhesDetencao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(DBcontexto.CaminhoBD());
                SqlCommand cmd = new SqlCommand("consulta_Detento_EDocumento", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                AdaptadorDados = new SqlDataAdapter(cmd);
                conexao.Open();
                AdaptadorDados.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(DBcontexto.CaminhoBD());
                SqlCommand cmd = new SqlCommand("consulta_Apreensao_EDocumento", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                AdaptadorDados = new SqlDataAdapter(cmd);
                conexao.Open();
                AdaptadorDados.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(DBcontexto.CaminhoBD());
                SqlCommand cmd = new SqlCommand("consulta_MultaDoCivil_EDocumento", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                AdaptadorDados = new SqlDataAdapter(cmd); 
                conexao.Open();
                AdaptadorDados.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
