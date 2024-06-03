namespace PGE_V2
{
    partial class Tela_Inicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Grupo_viacao = new GroupBox();
            btn_detencao = new Button();
            btn_Detalhes = new Button();
            button3 = new Button();
            btn_apreensao = new Button();
            Grupo_SIC = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            cdU_Multa1 = new CDU_Multa();
            cduApreensao1 = new CDUApreensao();
            cdU_DetalhesDetencao1 = new CDU_DetalhesDetencao();
            cdU_NovaDetencao1 = new CDU_NovaDetencao();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Grupo_viacao.SuspendLayout();
            Grupo_SIC.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Grupo_viacao);
            panel1.Controls.Add(Grupo_SIC);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 612);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.whatsapp_image_2021_06_16_at_15_126388751160cb268c081bf_10_25_2;
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Grupo_viacao
            // 
            Grupo_viacao.Controls.Add(btn_detencao);
            Grupo_viacao.Controls.Add(btn_Detalhes);
            Grupo_viacao.Controls.Add(button3);
            Grupo_viacao.Controls.Add(btn_apreensao);
            Grupo_viacao.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Grupo_viacao.Location = new Point(12, 86);
            Grupo_viacao.Name = "Grupo_viacao";
            Grupo_viacao.Size = new Size(151, 219);
            Grupo_viacao.TabIndex = 7;
            Grupo_viacao.TabStop = false;
            Grupo_viacao.Text = "Viação";
            Grupo_viacao.Enter += Grupo_viacao_Enter;
            // 
            // btn_detencao
            // 
            btn_detencao.BackgroundImageLayout = ImageLayout.None;
            btn_detencao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_detencao.ForeColor = Color.Black;
            btn_detencao.Location = new Point(11, 54);
            btn_detencao.Name = "btn_detencao";
            btn_detencao.Size = new Size(131, 31);
            btn_detencao.TabIndex = 1;
            btn_detencao.Text = "Detenção";
            btn_detencao.UseVisualStyleBackColor = true;
            btn_detencao.Click += button1_Click;
            // 
            // btn_Detalhes
            // 
            btn_Detalhes.BackgroundImageLayout = ImageLayout.None;
            btn_Detalhes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Detalhes.ForeColor = Color.Black;
            btn_Detalhes.Location = new Point(11, 92);
            btn_Detalhes.Name = "btn_Detalhes";
            btn_Detalhes.Size = new Size(131, 30);
            btn_Detalhes.TabIndex = 2;
            btn_Detalhes.Text = "Detalhes";
            btn_Detalhes.UseVisualStyleBackColor = true;
            btn_Detalhes.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(11, 162);
            button3.Name = "button3";
            button3.Size = new Size(131, 29);
            button3.TabIndex = 5;
            button3.Text = "Multa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_apreensao
            // 
            btn_apreensao.BackgroundImageLayout = ImageLayout.None;
            btn_apreensao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_apreensao.ForeColor = Color.Black;
            btn_apreensao.Location = new Point(11, 128);
            btn_apreensao.Name = "btn_apreensao";
            btn_apreensao.Size = new Size(131, 28);
            btn_apreensao.TabIndex = 4;
            btn_apreensao.Text = "Apreensao";
            btn_apreensao.UseVisualStyleBackColor = true;
            btn_apreensao.Click += btn_apreensao_Click;
            // 
            // Grupo_SIC
            // 
            Grupo_SIC.Controls.Add(button5);
            Grupo_SIC.Controls.Add(button4);
            Grupo_SIC.Controls.Add(button2);
            Grupo_SIC.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Grupo_SIC.Location = new Point(12, 323);
            Grupo_SIC.Name = "Grupo_SIC";
            Grupo_SIC.Size = new Size(151, 186);
            Grupo_SIC.TabIndex = 6;
            Grupo_SIC.TabStop = false;
            Grupo_SIC.Text = "SIC";
            // 
            // button5
            // 
            button5.Location = new Point(2, 135);
            button5.Name = "button5";
            button5.Size = new Size(150, 39);
            button5.TabIndex = 2;
            button5.Text = "Apreensão";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(2, 83);
            button4.Name = "button4";
            button4.Size = new Size(150, 39);
            button4.TabIndex = 1;
            button4.Text = "Investigação";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(2, 35);
            button2.Name = "button2";
            button2.Size = new Size(150, 39);
            button2.TabIndex = 0;
            button2.Text = "Operação";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 532);
            button1.Name = "button1";
            button1.Size = new Size(131, 45);
            button1.TabIndex = 3;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(cdU_Multa1);
            panel2.Controls.Add(cduApreensao1);
            panel2.Controls.Add(cdU_DetalhesDetencao1);
            panel2.Controls.Add(cdU_NovaDetencao1);
            panel2.Location = new Point(179, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(728, 532);
            panel2.TabIndex = 3;
            // 
            // cdU_Multa1
            // 
            cdU_Multa1.Location = new Point(0, 12);
            cdU_Multa1.Name = "cdU_Multa1";
            cdU_Multa1.Size = new Size(719, 532);
            cdU_Multa1.TabIndex = 5;
            // 
            // cduApreensao1
            // 
            cduApreensao1.Location = new Point(0, 3);
            cduApreensao1.Name = "cduApreensao1";
            cduApreensao1.Size = new Size(751, 597);
            cduApreensao1.TabIndex = 4;
            // 
            // cdU_DetalhesDetencao1
            // 
            cdU_DetalhesDetencao1.Location = new Point(0, 0);
            cdU_DetalhesDetencao1.Name = "cdU_DetalhesDetencao1";
            cdU_DetalhesDetencao1.Size = new Size(697, 544);
            cdU_DetalhesDetencao1.TabIndex = 1;
            cdU_DetalhesDetencao1.Load += cdU_DetalhesDetencao1_Load;
            // 
            // cdU_NovaDetencao1
            // 
            cdU_NovaDetencao1.Location = new Point(3, 12);
            cdU_NovaDetencao1.Name = "cdU_NovaDetencao1";
            cdU_NovaDetencao1.Size = new Size(694, 520);
            cdU_NovaDetencao1.TabIndex = 0;
            // 
            // Tela_Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(942, 612);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Tela_Inicial";
            Text = "Tela_Inicial";
            Load += Tela_Inicial_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Grupo_viacao.ResumeLayout(false);
            Grupo_SIC.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_Detalhes;
        private Button btn_detencao;
        private Panel panel2;
        private CDU_NovaDetencao cdU_NovaDetencao1;
        private CDU_DetalhesDetencao cdU_DetalhesDetencao1;
        private Button button1;
        private Button button3;
        private Button btn_apreensao;
        private CDUApreensao cduApreensao1;
        private CDU_Multa cdU_Multa1;
        private Button button4;
        private Button button2;
        public GroupBox Grupo_SIC;
        public GroupBox Grupo_viacao;
        private Button button5;
        private PictureBox pictureBox1;
    }
}