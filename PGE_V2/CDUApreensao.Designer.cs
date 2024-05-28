namespace PGE_V2
{
    partial class CDUApreensao
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Box_AP = new GroupBox();
            lista_box_ap = new GroupBox();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            Validar_btn = new Button();
            button4 = new Button();
            button1 = new Button();
            Descricao = new TextBox();
            btn_salvar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            N_doc = new TextBox();
            ID_login = new TextBox();
            DataAP = new TextBox();
            menu_ap_btn = new Button();
            lista_ap_btn = new Button();
            Box_AP.SuspendLayout();
            lista_box_ap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Box_AP
            // 
            Box_AP.Controls.Add(lista_box_ap);
            Box_AP.Controls.Add(Validar_btn);
            Box_AP.Controls.Add(button4);
            Box_AP.Controls.Add(button1);
            Box_AP.Controls.Add(Descricao);
            Box_AP.Controls.Add(btn_salvar);
            Box_AP.Controls.Add(label2);
            Box_AP.Controls.Add(label3);
            Box_AP.Controls.Add(label4);
            Box_AP.Controls.Add(label5);
            Box_AP.Controls.Add(N_doc);
            Box_AP.Controls.Add(ID_login);
            Box_AP.Controls.Add(DataAP);
            Box_AP.Location = new Point(92, 17);
            Box_AP.Name = "Box_AP";
            Box_AP.Size = new Size(473, 344);
            Box_AP.TabIndex = 13;
            Box_AP.TabStop = false;
            Box_AP.Text = "Menu de Apreensao";
            // 
            // lista_box_ap
            // 
            lista_box_ap.Controls.Add(dataGridView1);
            lista_box_ap.Controls.Add(button3);
            lista_box_ap.Location = new Point(69, 54);
            lista_box_ap.Name = "lista_box_ap";
            lista_box_ap.Size = new Size(607, 291);
            lista_box_ap.TabIndex = 14;
            lista_box_ap.TabStop = false;
            lista_box_ap.Text = "Lista de apreensoes";
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
            // button3
            // 
            button3.Location = new Point(504, 22);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Listar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Validar_btn
            // 
            Validar_btn.Location = new Point(306, 80);
            Validar_btn.Name = "Validar_btn";
            Validar_btn.Size = new Size(75, 23);
            Validar_btn.TabIndex = 14;
            Validar_btn.Text = "Validar";
            Validar_btn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(387, 81);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "Modificar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(306, 138);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Deletar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Descricao
            // 
            Descricao.Location = new Point(166, 204);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(100, 23);
            Descricao.TabIndex = 8;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(306, 25);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 10;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += button2_Click;
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
            // N_doc
            // 
            N_doc.Location = new Point(166, 139);
            N_doc.Name = "N_doc";
            N_doc.Size = new Size(100, 23);
            N_doc.TabIndex = 7;
            // 
            // ID_login
            // 
            ID_login.Location = new Point(166, 17);
            ID_login.Name = "ID_login";
            ID_login.Size = new Size(100, 23);
            ID_login.TabIndex = 5;
            // 
            // DataAP
            // 
            DataAP.Location = new Point(166, 81);
            DataAP.Name = "DataAP";
            DataAP.Size = new Size(100, 23);
            DataAP.TabIndex = 6;
            // 
            // menu_ap_btn
            // 
            menu_ap_btn.Location = new Point(123, 388);
            menu_ap_btn.Name = "menu_ap_btn";
            menu_ap_btn.Size = new Size(169, 23);
            menu_ap_btn.TabIndex = 15;
            menu_ap_btn.Text = "Menu de apreensoens";
            menu_ap_btn.UseVisualStyleBackColor = true;
            // 
            // lista_ap_btn
            // 
            lista_ap_btn.Location = new Point(464, 388);
            lista_ap_btn.Name = "lista_ap_btn";
            lista_ap_btn.Size = new Size(166, 23);
            lista_ap_btn.TabIndex = 16;
            lista_ap_btn.Text = "Lista de apreensoes";
            lista_ap_btn.UseVisualStyleBackColor = true;
            // 
            // CDUApreensao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lista_ap_btn);
            Controls.Add(menu_ap_btn);
            Controls.Add(Box_AP);
            Name = "CDUApreensao";
            Size = new Size(970, 436);
            Box_AP.ResumeLayout(false);
            Box_AP.PerformLayout();
            lista_box_ap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Box_AP;
        private Button Validar_btn;
        private Button button4;
        private Button button1;
        private TextBox Descricao;
        private Button btn_salvar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox N_doc;
        private TextBox ID_login;
        private TextBox DataAP;
        private GroupBox lista_box_ap;
        private DataGridView dataGridView1;
        private Button button3;
        private Button menu_ap_btn;
        private Button lista_ap_btn;
    }
}
