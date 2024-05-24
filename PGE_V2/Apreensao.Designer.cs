namespace PGE_V2
{
    partial class Apreensao
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ID_login = new TextBox();
            DataAP = new TextBox();
            N_doc = new TextBox();
            Descricao = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 34);
            label1.Name = "label1";
            label1.Size = new Size(115, 29);
            label1.TabIndex = 0;
            label1.Text = "Apreensão";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 126);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "ID_Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 190);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 2;
            label3.Text = "Data de Apreensao";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 248);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "N_Documento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 313);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Descrição";
            // 
            // ID_login
            // 
            ID_login.Location = new Point(276, 118);
            ID_login.Name = "ID_login";
            ID_login.Size = new Size(100, 23);
            ID_login.TabIndex = 5;
            ID_login.TextChanged += textBox1_TextChanged;
            // 
            // DataAP
            // 
            DataAP.Location = new Point(276, 182);
            DataAP.Name = "DataAP";
            DataAP.Size = new Size(100, 23);
            DataAP.TabIndex = 6;
            // 
            // N_doc
            // 
            N_doc.Location = new Point(276, 240);
            N_doc.Name = "N_doc";
            N_doc.Size = new Size(100, 23);
            N_doc.TabIndex = 7;
            // 
            // Descricao
            // 
            Descricao.Location = new Point(276, 305);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(100, 23);
            Descricao.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(509, 255);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Deletar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(509, 118);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(509, 182);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Apreensao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Descricao);
            Controls.Add(N_doc);
            Controls.Add(DataAP);
            Controls.Add(ID_login);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Apreensao";
            Text = "Apreensao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ID_login;
        private TextBox DataAP;
        private TextBox N_doc;
        private TextBox Descricao;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}