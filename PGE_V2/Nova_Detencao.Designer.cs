namespace WindowsFormsApplication1
{
    partial class Nova_Detencao
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
            groupBox = new GroupBox();
            label3 = new Label();
            cmbTipoDocumento = new ComboBox();
            comboBoxGenero = new ComboBox();
            text_num_Bi = new TextBox();
            lbl_num_Bi = new Label();
            label_genero = new Label();
            textBox3 = new TextBox();
            label_data_nasc = new Label();
            textBox2 = new TextBox();
            label_e_de = new Label();
            textBox1 = new TextBox();
            label_filho_de = new Label();
            text_nome = new TextBox();
            lbl_nome = new Label();
            Acusação = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtDetalhes = new TextBox();
            cmbTipo_Acusacoa = new ComboBox();
            btnSalvar = new Button();
            button1 = new Button();
            groupBox.SuspendLayout();
            Acusação.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(cmbTipoDocumento);
            groupBox.Controls.Add(comboBoxGenero);
            groupBox.Controls.Add(text_num_Bi);
            groupBox.Controls.Add(lbl_num_Bi);
            groupBox.Controls.Add(label_genero);
            groupBox.Controls.Add(textBox3);
            groupBox.Controls.Add(label_data_nasc);
            groupBox.Controls.Add(textBox2);
            groupBox.Controls.Add(label_e_de);
            groupBox.Controls.Add(textBox1);
            groupBox.Controls.Add(label_filho_de);
            groupBox.Controls.Add(text_nome);
            groupBox.Controls.Add(lbl_nome);
            groupBox.Location = new Point(14, 37);
            groupBox.Margin = new Padding(4, 3, 4, 3);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(4, 3, 4, 3);
            groupBox.Size = new Size(852, 189);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Dados Pessoais";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 141);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 30;
            label3.Text = "Tipo de Documento";
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Location = new Point(161, 136);
            cmbTipoDocumento.Margin = new Padding(4, 3, 4, 3);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(171, 23);
            cmbTipoDocumento.TabIndex = 29;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Masculino", "Feminino" });
            comboBoxGenero.Location = new Point(686, 97);
            comboBoxGenero.Margin = new Padding(2);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(107, 23);
            comboBoxGenero.TabIndex = 26;
            // 
            // text_num_Bi
            // 
            text_num_Bi.Location = new Point(433, 141);
            text_num_Bi.Margin = new Padding(2);
            text_num_Bi.Multiline = true;
            text_num_Bi.Name = "text_num_Bi";
            text_num_Bi.Size = new Size(193, 21);
            text_num_Bi.TabIndex = 25;
            // 
            // lbl_num_Bi
            // 
            lbl_num_Bi.AutoSize = true;
            lbl_num_Bi.Location = new Point(376, 145);
            lbl_num_Bi.Margin = new Padding(2, 0, 2, 0);
            lbl_num_Bi.Name = "lbl_num_Bi";
            lbl_num_Bi.Size = new Size(51, 15);
            lbl_num_Bi.TabIndex = 24;
            lbl_num_Bi.Text = "Nº do BI";
            // 
            // label_genero
            // 
            label_genero.AutoSize = true;
            label_genero.Location = new Point(632, 97);
            label_genero.Margin = new Padding(2, 0, 2, 0);
            label_genero.Name = "label_genero";
            label_genero.Size = new Size(45, 15);
            label_genero.TabIndex = 23;
            label_genero.Text = "Genero";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(525, 44);
            textBox3.Margin = new Padding(2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 21);
            textBox3.TabIndex = 22;
            // 
            // label_data_nasc
            // 
            label_data_nasc.AutoSize = true;
            label_data_nasc.Location = new Point(392, 46);
            label_data_nasc.Margin = new Padding(2, 0, 2, 0);
            label_data_nasc.Name = "label_data_nasc";
            label_data_nasc.Size = new Size(112, 15);
            label_data_nasc.TabIndex = 21;
            label_data_nasc.Text = "Data de nascimento";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(433, 92);
            textBox2.Margin = new Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 21);
            textBox2.TabIndex = 20;
            // 
            // label_e_de
            // 
            label_e_de.AutoSize = true;
            label_e_de.Location = new Point(392, 92);
            label_e_de.Margin = new Padding(2, 0, 2, 0);
            label_e_de.Name = "label_e_de";
            label_e_de.Size = new Size(32, 15);
            label_e_de.TabIndex = 19;
            label_e_de.Text = "E de ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 96);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 21);
            textBox1.TabIndex = 18;
            // 
            // label_filho_de
            // 
            label_filho_de.AutoSize = true;
            label_filho_de.Location = new Point(26, 99);
            label_filho_de.Margin = new Padding(2, 0, 2, 0);
            label_filho_de.Name = "label_filho_de";
            label_filho_de.Size = new Size(52, 15);
            label_filho_de.TabIndex = 17;
            label_filho_de.Text = "Filho de ";
            // 
            // text_nome
            // 
            text_nome.Location = new Point(76, 44);
            text_nome.Margin = new Padding(2);
            text_nome.Multiline = true;
            text_nome.Name = "text_nome";
            text_nome.Size = new Size(298, 21);
            text_nome.TabIndex = 16;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(26, 46);
            lbl_nome.Margin = new Padding(2, 0, 2, 0);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(40, 15);
            lbl_nome.TabIndex = 15;
            lbl_nome.Text = "Nome";
            // 
            // Acusação
            // 
            Acusação.Controls.Add(label2);
            Acusação.Controls.Add(label1);
            Acusação.Controls.Add(txtDetalhes);
            Acusação.Controls.Add(cmbTipo_Acusacoa);
            Acusação.Location = new Point(14, 246);
            Acusação.Margin = new Padding(4, 3, 4, 3);
            Acusação.Name = "Acusação";
            Acusação.Padding = new Padding(4, 3, 4, 3);
            Acusação.Size = new Size(852, 189);
            Acusação.TabIndex = 1;
            Acusação.TabStop = false;
            Acusação.Text = "Dados da Acusação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 28;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 27;
            label1.Text = "Tipo de Acusação";
            // 
            // txtDetalhes
            // 
            txtDetalhes.Location = new Point(29, 93);
            txtDetalhes.Margin = new Padding(4, 3, 4, 3);
            txtDetalhes.Multiline = true;
            txtDetalhes.Name = "txtDetalhes";
            txtDetalhes.Size = new Size(801, 88);
            txtDetalhes.TabIndex = 1;
            // 
            // cmbTipo_Acusacoa
            // 
            cmbTipo_Acusacoa.FormattingEnabled = true;
            cmbTipo_Acusacoa.Location = new Point(29, 45);
            cmbTipo_Acusacoa.Margin = new Padding(4, 3, 4, 3);
            cmbTipo_Acusacoa.Name = "cmbTipo_Acusacoa";
            cmbTipo_Acusacoa.Size = new Size(206, 23);
            cmbTipo_Acusacoa.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(727, 464);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 27);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(541, 464);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Nova_Detencao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(Acusação);
            Controls.Add(groupBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Nova_Detencao";
            Text = "Nova_Detencao";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            Acusação.ResumeLayout(false);
            Acusação.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.TextBox text_num_Bi;
        private System.Windows.Forms.Label lbl_num_Bi;
        private System.Windows.Forms.Label label_genero;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_data_nasc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_e_de;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_filho_de;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.GroupBox Acusação;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.ComboBox cmbTipo_Acusacoa;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Button button1;
    }
}