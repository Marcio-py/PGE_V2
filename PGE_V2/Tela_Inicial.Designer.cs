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
            button3 = new Button();
            btn_apreensao = new Button();
            button1 = new Button();
            btn_Detalhes = new Button();
            btn_detencao = new Button();
            panel2 = new Panel();
            cduApreensao1 = new CDUApreensao();
            cdU_DetalhesDetencao1 = new CDU_DetalhesDetencao();
            cdU_NovaDetencao1 = new CDU_NovaDetencao();
            cdU_Multa1 = new CDU_Multa();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btn_apreensao);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_Detalhes);
            panel1.Controls.Add(btn_detencao);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 544);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(23, 197);
            button3.Name = "button3";
            button3.Size = new Size(131, 45);
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
            btn_apreensao.Location = new Point(23, 146);
            btn_apreensao.Name = "btn_apreensao";
            btn_apreensao.Size = new Size(131, 45);
            btn_apreensao.TabIndex = 4;
            btn_apreensao.Text = "Apreensao";
            btn_apreensao.UseVisualStyleBackColor = true;
            btn_apreensao.Click += btn_apreensao_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(23, 439);
            button1.Name = "button1";
            button1.Size = new Size(131, 45);
            button1.TabIndex = 3;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btn_Detalhes
            // 
            btn_Detalhes.BackgroundImageLayout = ImageLayout.None;
            btn_Detalhes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Detalhes.ForeColor = Color.Black;
            btn_Detalhes.Location = new Point(23, 95);
            btn_Detalhes.Name = "btn_Detalhes";
            btn_Detalhes.Size = new Size(131, 45);
            btn_Detalhes.TabIndex = 2;
            btn_Detalhes.Text = "Detalhes";
            btn_Detalhes.UseVisualStyleBackColor = true;
            btn_Detalhes.Click += button2_Click;
            // 
            // btn_detencao
            // 
            btn_detencao.BackgroundImageLayout = ImageLayout.None;
            btn_detencao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_detencao.ForeColor = Color.Black;
            btn_detencao.Location = new Point(23, 44);
            btn_detencao.Name = "btn_detencao";
            btn_detencao.Size = new Size(131, 45);
            btn_detencao.TabIndex = 1;
            btn_detencao.Text = "Detenção";
            btn_detencao.UseVisualStyleBackColor = true;
            btn_detencao.Click += button1_Click;
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
            // cduApreensao1
            // 
            cduApreensao1.Location = new Point(0, 3);
            cduApreensao1.Name = "cduApreensao1";
            cduApreensao1.Size = new Size(882, 526);
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
            // cdU_Multa1
            // 
            cdU_Multa1.Location = new Point(3, 22);
            cdU_Multa1.Name = "cdU_Multa1";
            cdU_Multa1.Size = new Size(733, 405);
            cdU_Multa1.TabIndex = 5;
            // 
            // Tela_Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1152, 544);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Tela_Inicial";
            Text = "Tela_Inicial";
            panel1.ResumeLayout(false);
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
    }
}