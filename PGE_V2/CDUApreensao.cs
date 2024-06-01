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
    public partial class CDUApreensao : UserControl
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;
        public CDUApreensao()
        {
            InitializeComponent();
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

                if(Verifica_Registo_DoCidadao(N_doc.Text) == false)
                {
                    return;
                }

                conexao.Open();
                comando.ExecuteNonQuery();

                //salvar_tipo_documento(N_doc.Text, label4.Text);
                MessageBox.Show("Processo de apreensão registado com Sucesso");
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

        public bool Verifica_Registo_DoCidadao(string numeroBI)
        {
            using (SqlConnection conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True;"))
            {
                conexao.Open();
                string strSQL = "SELECT COUNT(*) FROM Tipo_Documento WHERE Nº_Documento = @Nº_Documento";
                using (SqlCommand comando = new SqlCommand(strSQL, conexao))
                {
                    comando.Parameters.AddWithValue("@Nº_Documento", numeroBI);
                    int count = (int)comando.ExecuteScalar();

                    // Check if the count is greater than 0 (record exists)
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Apreensão negada: O cívil não tem nenhum registo");
                        return false;
                    }
                }
            }
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
