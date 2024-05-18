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
    public partial class DetalhesDetencao : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        //SqlDataReader dr;

        string strSQL;
        public DetalhesDetencao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");

                SqlCommand cmd = new SqlCommand("consulta_detidos", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();

                da = new SqlDataAdapter(cmd);

                conexao.Open();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
