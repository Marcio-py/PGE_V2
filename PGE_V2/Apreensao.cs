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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PGE_V2
{
    public partial class Apreensao : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;

        public Apreensao()
        {
            InitializeComponent();
            Box_AP.Visible = false;
            lista_box_ap.Visible = false;
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

        private void Box_AP_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");

                SqlCommand cmd = new SqlCommand("SELECT * FROM Apreensao", conexao);
                comando = new SqlCommand(strSQL, conexao);
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

        private void menu_ap_btn_Click(object sender, EventArgs e)
        {
            Box_AP.Visible = true;
            lista_box_ap.Visible = false;

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        private void lista_ap_btn_Click(object sender, EventArgs e)
        {
            Box_AP.Visible = false;
            lista_box_ap.Visible = true;

            DataAP.Text = "";
            Descricao.Text = "";
            N_doc.Text = "";
            ID_login.Text = "";
        }

        private void Validar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
                strSQL = "SELECT * FROM Apreensao WHERE Nº_Documento = @Nº_Documento";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Nº_Documento", N_doc.Text);

                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    ID_login.Text = Convert.ToString(dr["Id_Login"]);
                    N_doc.Text = Convert.ToString(dr["Nº_Documento"]);
                    DataAP.Text = Convert.ToString(dr["Data_Apreencao"]);
                    // DataAP.Text = (string)dr["Data_Apreencao"];
                    Descricao.Text = (string)dr["Descricao_Apreensao"];
                }

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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True;");
                strSQL = "UPDATE Apreensao SET Data_Apreencao = @Data_Apreencao, Descricao_Apreensao= @Descricao_Apreensao WHERE Nº_Documento = @Nº_Documento";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Data_Apreencao", DataAP.Text);
                comando.Parameters.AddWithValue("@Descricao_Apreensao", Descricao.Text);
                comando.Parameters.AddWithValue("@Nº_Documento", N_doc.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("modificação feita com Sucesso");
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
            try
            {
                conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True;");
                strSQL = "Delete Apreensao WHERE Nº_Documento = @Nº_Documento";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Nº_Documento", N_doc.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Apagado com Sucesso");
                DataAP.Text = "";
                Descricao.Text = "";
                N_doc.Text = "";
                ID_login.Text = "";
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
