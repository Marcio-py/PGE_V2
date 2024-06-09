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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            label1 = new Label();
            label2 = new Label();
            textLogin = new TextBox();
            TextSenha = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(460, 209);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 0;
            label1.Text = "ID_Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(460, 265);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 18);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // textLogin
            // 
            textLogin.BackColor = Color.Gray;
            textLogin.BorderStyle = BorderStyle.None;
            textLogin.Location = new Point(583, 211);
            textLogin.Margin = new Padding(4, 3, 4, 3);
            textLogin.Multiline = true;
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(195, 23);
            textLogin.TabIndex = 2;
            // 
            // TextSenha
            // 
            TextSenha.BackColor = Color.Gray;
            TextSenha.BorderStyle = BorderStyle.None;
            TextSenha.Location = new Point(583, 267);
            TextSenha.Margin = new Padding(4, 3, 4, 3);
            TextSenha.Multiline = true;
            TextSenha.Name = "TextSenha";
            TextSenha.PasswordChar = '*';
            TextSenha.Size = new Size(195, 21);
            TextSenha.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(608, 321);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 33);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button2.ForeColor = Color.Teal;
            button2.Location = new Point(608, 369);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 39);
            button2.TabIndex = 5;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = PGE_V2.Properties.Resources.Shape_sombreado;
            pictureBox1.Location = new Point(-2, -307);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 877);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = PGE_V2.Properties.Resources.group_694642;
            pictureBox2.Location = new Point(583, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gray;
            pictureBox3.Image = PGE_V2.Properties.Resources.shield_508281;
            pictureBox3.Location = new Point(555, 267);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Gray;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(555, 211);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(933, 519);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TextSenha);
            Controls.Add(textLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "TelaLogin";
            Text = "TelaLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox TextSenha;
        private System.Windows.Forms.Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}