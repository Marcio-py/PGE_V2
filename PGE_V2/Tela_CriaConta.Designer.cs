﻿namespace PGE_V2
{
    partial class Tela_CriaConta
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(259, 308);
            button1.Name = "button1";
            button1.Size = new Size(154, 23);
            button1.TabIndex = 0;
            button1.Text = "Criar nova conta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 213);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 213);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 162);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(233, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(303, 352);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 116);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(233, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // Tela_CriaConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 450);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Tela_CriaConta";
            Text = "Tela_CriaConta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private Label label3;
        private TextBox textBox3;
    }
}