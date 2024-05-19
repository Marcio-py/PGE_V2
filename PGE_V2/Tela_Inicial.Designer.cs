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
            button1 = new Button();
            btn_Detalhes = new Button();
            btn_detencao = new Button();
            panel2 = new Panel();
            cdU_DetalhesDetencao1 = new CDU_DetalhesDetencao();
            cdU_NovaDetencao1 = new CDU_NovaDetencao();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_Detalhes);
            panel1.Controls.Add(btn_detencao);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 544);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 224);
            button1.Name = "button1";
            button1.Size = new Size(131, 45);
            button1.TabIndex = 3;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btn_Detalhes
            // 
            btn_Detalhes.Location = new Point(3, 147);
            btn_Detalhes.Name = "btn_Detalhes";
            btn_Detalhes.Size = new Size(131, 45);
            btn_Detalhes.TabIndex = 2;
            btn_Detalhes.Text = "Detalhes";
            btn_Detalhes.UseVisualStyleBackColor = true;
            btn_Detalhes.Click += button2_Click;
            // 
            // btn_detencao
            // 
            btn_detencao.Location = new Point(3, 74);
            btn_detencao.Name = "btn_detencao";
            btn_detencao.Size = new Size(131, 45);
            btn_detencao.TabIndex = 1;
            btn_detencao.Text = "Denteção";
            btn_detencao.UseVisualStyleBackColor = true;
            btn_detencao.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(cdU_DetalhesDetencao1);
            panel2.Controls.Add(cdU_NovaDetencao1);
            panel2.Location = new Point(179, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(709, 532);
            panel2.TabIndex = 3;
            // 
            // cdU_DetalhesDetencao1
            // 
            cdU_DetalhesDetencao1.Location = new Point(0, 0);
            cdU_DetalhesDetencao1.Name = "cdU_DetalhesDetencao1";
            cdU_DetalhesDetencao1.Size = new Size(709, 483);
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
            ClientSize = new Size(900, 544);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
    }
}