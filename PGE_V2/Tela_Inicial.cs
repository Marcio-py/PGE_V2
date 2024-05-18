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
    }
}
