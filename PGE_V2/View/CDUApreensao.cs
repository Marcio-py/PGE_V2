using PGE_V2.Controler;
using PGE_V2.Dados;
using PGE_V2.Modelos;
using PGE_V2.Repositorio;
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
using Xunit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PGE_V2
{
    public partial class CDUApreensao : UserControl
    {
        string strSQL;
        public CDUApreensao()
        {
            InitializeComponent();
        }


        private async void btn_salvar_Click(object sender, EventArgs e)
        {
            // Inicializar conexão
            var apreensaoRepositorio = new ApreensaoRepositorio(DBcontexto.CaminhoBD());
            // executar operação
            ApreensaoController apreensaoController = new ApreensaoController(apreensaoRepositorio);
            if (Verifica_Registo_DoCidadao(N_doc.Text))
            {
                apreensaoController.Create(Descricao.Text, DataAP.Text, N_doc.Text, int.Parse(ID_login.Text));
            }
            Limpa_CamposApreensao();
        }

        public bool Verifica_Registo_DoCidadao(string numeroBI)
        {
            SqlConnection conexao = new SqlConnection(DBcontexto.CaminhoBD());
            conexao.Open();
            string strSQL = "SELECT COUNT(*) FROM Dados_Pessoais WHERE Nº_BI = @Nº_BI";
            SqlCommand comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@Nº_BI", numeroBI);
            int numeroDeOcorrencias = (int)comando.ExecuteScalar();
            if (numeroDeOcorrencias > 0) { return true; }
            else { MessageBox.Show("Apreensão negada: O cívil não tem nenhum registo"); return false; }
        }

        public void Limpa_CamposApreensao()
        {
            DataAP.Text = ""; Descricao.Text = ""; N_doc.Text = ""; ID_login.Text = "";
        }

        public bool valida_campos_detencao()
        {
            if (!string.IsNullOrEmpty(ID_login.Text) && !string.IsNullOrEmpty(N_doc.Text) && !string.IsNullOrEmpty(Descricao.Text))
            { return true; }
            else { MessageBox.Show("Por favor preencha os campos"); return false; }
        }

        private void Mudar_Click(object sender, EventArgs e)
        {
            // Inicializar conexão
            var apreensaoRepositorio = new ApreensaoRepositorio(DBcontexto.CaminhoBD());
            // executar operação
            ApreensaoController apreensaoController = new ApreensaoController(apreensaoRepositorio);
            apreensaoController.Change(Descricao.Text, DataAP.Text, N_doc.Text);
            Limpa_CamposApreensao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Inicializar conexão
            var apreensaoRepositorio = new ApreensaoRepositorio(DBcontexto.CaminhoBD());
            // executar operação
            ApreensaoController apreensaoController = new ApreensaoController(apreensaoRepositorio);
            apreensaoController.Delete(N_doc.Text);
            Limpa_CamposApreensao();
        }

        private async void Validar_btn_Click(object sender, EventArgs e)
        {
            // Inicializar conexão
            var apreensaoRepositorio = new ApreensaoRepositorio(DBcontexto.CaminhoBD());
            // executar operação
            DataTable retornoApreensao = apreensaoRepositorio.BuscarPorId_RetornaUmaLinha(N_doc.Text);
            if (retornoApreensao.Rows.Count != 0) { DataRow apreensaoLinha = retornoApreensao.Rows[0]; PopularCampos(apreensaoLinha); }
            else { MessageBox.Show("Erro de Validação: Civil não encontrado"); return; }
        }

        private void PopularCampos(DataRow apreensaoLinha)
        {
            ID_login.Text = apreensaoLinha["ID_login"].ToString();
            Descricao.Text = apreensaoLinha["Descricao_Apreensao"].ToString();
            DataAP.Text = apreensaoLinha["Data_Apreencao"].ToString();
        }
    }
}
