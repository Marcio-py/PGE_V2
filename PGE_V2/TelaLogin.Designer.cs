namespace WindowsFormsApplication1
{
    partial class TelaLogin
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
            label1 = new Label();
            label2 = new Label();
            textLogin = new TextBox();
            TextSenha = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 135);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "ID_Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 252);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // textLogin
            // 
            textLogin.Location = new Point(294, 127);
            textLogin.Margin = new Padding(4, 3, 4, 3);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(116, 23);
            textLogin.TabIndex = 2;
            textLogin.TextChanged += textLogin_TextChanged;
            // 
            // TextSenha
            // 
            TextSenha.Location = new Point(294, 252);
            TextSenha.Margin = new Padding(4, 3, 4, 3);
            TextSenha.Name = "TextSenha";
            TextSenha.Size = new Size(116, 23);
            TextSenha.TabIndex = 3;
            TextSenha.TextChanged += Senha_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(355, 402);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(button1);
            Controls.Add(TextSenha);
            Controls.Add(textLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TelaLogin";
            Text = "TelaLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox TextSenha;
        private System.Windows.Forms.Button button1;
    }
}