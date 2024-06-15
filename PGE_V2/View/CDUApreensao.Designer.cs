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
            Descricao = new TextBox();
            Validar_btn = new Button();
            modificar_btn = new Button();
            apagar_btn = new Button();
            btn_salvar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            N_doc = new TextBox();
            ID_login = new TextBox();
            DataAP = new TextBox();
            Box_AP.SuspendLayout();
            SuspendLayout();
            // 
            // Box_AP
            // 
            Box_AP.Controls.Add(Descricao);
            Box_AP.Controls.Add(Validar_btn);
            Box_AP.Controls.Add(modificar_btn);
            Box_AP.Controls.Add(apagar_btn);
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
            // Descricao
            // 
            Descricao.Location = new Point(105, 212);
            Descricao.Margin = new Padding(4, 3, 4, 3);
            Descricao.Multiline = true;
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(276, 84);
            Descricao.TabIndex = 33;
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
            // modificar_btn
            // 
            modificar_btn.Location = new Point(387, 81);
            modificar_btn.Name = "modificar_btn";
            modificar_btn.Size = new Size(75, 23);
            modificar_btn.TabIndex = 13;
            modificar_btn.Text = "Modificar";
            modificar_btn.UseVisualStyleBackColor = true;
            modificar_btn.Click += Mudar_Click;
            // 
            // apagar_btn
            // 
            apagar_btn.Location = new Point(306, 138);
            apagar_btn.Name = "apagar_btn";
            apagar_btn.Size = new Size(75, 23);
            apagar_btn.TabIndex = 9;
            apagar_btn.Text = "Deletar";
            apagar_btn.UseVisualStyleBackColor = true;
            apagar_btn.Click += btn_Apagar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(306, 25);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 10;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
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
            // CDUApreensao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Box_AP);
            Name = "CDUApreensao";
            Size = new Size(631, 436);
            Box_AP.ResumeLayout(false);
            Box_AP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Box_AP;
        private Button Validar_btn;
        private Button modificar_btn;
        private Button apagar_btn;
        private TextBox Descricao;
        private Button btn_salvar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox N_doc;
        private TextBox ID_login;
        private TextBox DataAP;
    }
}
