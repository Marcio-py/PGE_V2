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
            Box_AP = new GroupBox();
            Validar_btn = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            lista_box_ap = new GroupBox();
            menu_ap_btn = new Button();
            lista_ap_btn = new Button();
            Box_AP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            lista_box_ap.SuspendLayout();
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
            label2.Location = new Point(31, 25);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "ID_Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 89);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 2;
            label3.Text = "Data de Apreensao";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 147);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "N_Documento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 212);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Descrição";
            // 
            // ID_login
            // 
            ID_login.Location = new Point(166, 17);
            ID_login.Name = "ID_login";
            ID_login.Size = new Size(100, 23);
            ID_login.TabIndex = 5;
            ID_login.TextChanged += textBox1_TextChanged;
            // 
            // DataAP
            // 
            DataAP.Location = new Point(166, 81);
            DataAP.Name = "DataAP";
            DataAP.Size = new Size(100, 23);
            DataAP.TabIndex = 6;
            // 
            // N_doc
            // 
            N_doc.Location = new Point(166, 139);
            N_doc.Name = "N_doc";
            N_doc.Size = new Size(100, 23);
            N_doc.TabIndex = 7;
            // 
            // Descricao
            // 
            Descricao.Location = new Point(166, 204);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(100, 23);
            Descricao.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(306, 138);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Deletar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(306, 25);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(504, 22);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Listar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Box_AP
            // 
            Box_AP.Controls.Add(Validar_btn);
            Box_AP.Controls.Add(button4);
            Box_AP.Controls.Add(button1);
            Box_AP.Controls.Add(Descricao);
            Box_AP.Controls.Add(button2);
            Box_AP.Controls.Add(label2);
            Box_AP.Controls.Add(label3);
            Box_AP.Controls.Add(label4);
            Box_AP.Controls.Add(label5);
            Box_AP.Controls.Add(N_doc);
            Box_AP.Controls.Add(ID_login);
            Box_AP.Controls.Add(DataAP);
            Box_AP.Location = new Point(125, 76);
            Box_AP.Name = "Box_AP";
            Box_AP.Size = new Size(514, 267);
            Box_AP.TabIndex = 12;
            Box_AP.TabStop = false;
            Box_AP.Text = "Menu de Apreensao";
            Box_AP.Enter += Box_AP_Enter;
            // 
            // Validar_btn
            // 
            Validar_btn.Location = new Point(306, 80);
            Validar_btn.Name = "Validar_btn";
            Validar_btn.Size = new Size(75, 23);
            Validar_btn.TabIndex = 14;
            Validar_btn.Text = "Validar";
            Validar_btn.UseVisualStyleBackColor = true;
            Validar_btn.Click += Validar_btn_Click;
            // 
            // button4
            // 
            button4.Location = new Point(387, 81);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "Modificar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 22);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(472, 252);
            dataGridView1.TabIndex = 14;
            // 
            // lista_box_ap
            // 
            lista_box_ap.Controls.Add(dataGridView1);
            lista_box_ap.Controls.Add(button3);
            lista_box_ap.Location = new Point(60, 93);
            lista_box_ap.Name = "lista_box_ap";
            lista_box_ap.Size = new Size(603, 280);
            lista_box_ap.TabIndex = 13;
            lista_box_ap.TabStop = false;
            lista_box_ap.Text = "Lista de apreensoes";
            // 
            // menu_ap_btn
            // 
            menu_ap_btn.Location = new Point(125, 396);
            menu_ap_btn.Name = "menu_ap_btn";
            menu_ap_btn.Size = new Size(169, 23);
            menu_ap_btn.TabIndex = 14;
            menu_ap_btn.Text = "Menu de apreensoens";
            menu_ap_btn.UseVisualStyleBackColor = true;
            menu_ap_btn.Click += menu_ap_btn_Click;
            // 
            // lista_ap_btn
            // 
            lista_ap_btn.Location = new Point(346, 396);
            lista_ap_btn.Name = "lista_ap_btn";
            lista_ap_btn.Size = new Size(166, 23);
            lista_ap_btn.TabIndex = 15;
            lista_ap_btn.Text = "Lista de apreensoes";
            lista_ap_btn.UseVisualStyleBackColor = true;
            lista_ap_btn.Click += lista_ap_btn_Click;
            // 
            // Apreensao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lista_ap_btn);
            Controls.Add(menu_ap_btn);
            Controls.Add(Box_AP);
            Controls.Add(label1);
            Controls.Add(lista_box_ap);
            Name = "Apreensao";
            Text = "Apreensao";
            Box_AP.ResumeLayout(false);
            Box_AP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            lista_box_ap.ResumeLayout(false);
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
        private GroupBox Box_AP;
        private Button button4;
        private DataGridView dataGridView1;
        private GroupBox lista_box_ap;
        private Button menu_ap_btn;
        private Button lista_ap_btn;
        private Button Validar_btn;
    }
}