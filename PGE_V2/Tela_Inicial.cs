using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace PGE_V2
{
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
            cdU_DetalhesDetencao1.Hide();
            cdU_NovaDetencao1.Hide();
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
    }
}
