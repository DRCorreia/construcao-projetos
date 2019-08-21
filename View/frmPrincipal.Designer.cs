namespace View
{
    partial class frmPrincipal
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.gpbDadosPrincipais = new System.Windows.Forms.GroupBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbTel = new System.Windows.Forms.MaskedTextBox();
            this.ltbTipoEndereco = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpbDadosComp = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbSolteiro = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.ckbFilhos = new System.Windows.Forms.CheckBox();
            this.ckbAnimais = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpbPessoas = new System.Windows.Forms.GroupBox();
            this.gpbDadosPrincipais.SuspendLayout();
            this.gpbDadosComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbPessoas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(462, 380);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(17, 22);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(38, 13);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Nome:";
            // 
            // gpbDadosPrincipais
            // 
            this.gpbDadosPrincipais.Controls.Add(this.label5);
            this.gpbDadosPrincipais.Controls.Add(this.label4);
            this.gpbDadosPrincipais.Controls.Add(this.cmbCidade);
            this.gpbDadosPrincipais.Controls.Add(this.cmbEstado);
            this.gpbDadosPrincipais.Controls.Add(this.label3);
            this.gpbDadosPrincipais.Controls.Add(this.txbEndereco);
            this.gpbDadosPrincipais.Controls.Add(this.label2);
            this.gpbDadosPrincipais.Controls.Add(this.ltbTipoEndereco);
            this.gpbDadosPrincipais.Controls.Add(this.mtbTel);
            this.gpbDadosPrincipais.Controls.Add(this.label1);
            this.gpbDadosPrincipais.Controls.Add(this.txbNome);
            this.gpbDadosPrincipais.Controls.Add(this.lblTexto);
            this.gpbDadosPrincipais.Location = new System.Drawing.Point(12, 12);
            this.gpbDadosPrincipais.Name = "gpbDadosPrincipais";
            this.gpbDadosPrincipais.Size = new System.Drawing.Size(508, 178);
            this.gpbDadosPrincipais.TabIndex = 2;
            this.gpbDadosPrincipais.TabStop = false;
            this.gpbDadosPrincipais.Text = "Dados Principais";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(57, 19);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(270, 20);
            this.txbNome.TabIndex = 0;
            this.txbNome.Text = "Nome completo!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tel:";
            // 
            // mtbTel
            // 
            this.mtbTel.Location = new System.Drawing.Point(377, 22);
            this.mtbTel.Mask = "(99) 00000-0000";
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(114, 20);
            this.mtbTel.TabIndex = 3;
            // 
            // ltbTipoEndereco
            // 
            this.ltbTipoEndereco.FormattingEnabled = true;
            this.ltbTipoEndereco.Items.AddRange(new object[] {
            "Rod.",
            "Trav.",
            "R.",
            "Av."});
            this.ltbTipoEndereco.Location = new System.Drawing.Point(20, 76);
            this.ltbTipoEndereco.Name = "ltbTipoEndereco";
            this.ltbTipoEndereco.Size = new System.Drawing.Size(120, 69);
            this.ltbTipoEndereco.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(159, 76);
            this.txbEndereco.Multiline = true;
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(168, 69);
            this.txbEndereco.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereço";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(356, 76);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(135, 21);
            this.cmbEstado.TabIndex = 8;
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(356, 124);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(135, 21);
            this.cmbCidade.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cidade";
            // 
            // gpbDadosComp
            // 
            this.gpbDadosComp.Controls.Add(this.ckbAnimais);
            this.gpbDadosComp.Controls.Add(this.ckbFilhos);
            this.gpbDadosComp.Controls.Add(this.rdbCasado);
            this.gpbDadosComp.Controls.Add(this.rdbSolteiro);
            this.gpbDadosComp.Controls.Add(this.rdbFeminino);
            this.gpbDadosComp.Controls.Add(this.rdbMasculino);
            this.gpbDadosComp.Location = new System.Drawing.Point(12, 206);
            this.gpbDadosComp.Name = "gpbDadosComp";
            this.gpbDadosComp.Size = new System.Drawing.Size(508, 134);
            this.gpbDadosComp.TabIndex = 3;
            this.gpbDadosComp.TabStop = false;
            this.gpbDadosComp.Text = "Dados Complementares";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(20, 40);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(20, 72);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbSolteiro
            // 
            this.rdbSolteiro.AutoSize = true;
            this.rdbSolteiro.Location = new System.Drawing.Point(136, 40);
            this.rdbSolteiro.Name = "rdbSolteiro";
            this.rdbSolteiro.Size = new System.Drawing.Size(60, 17);
            this.rdbSolteiro.TabIndex = 2;
            this.rdbSolteiro.TabStop = true;
            this.rdbSolteiro.Text = "Solteiro";
            this.rdbSolteiro.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(136, 72);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(61, 17);
            this.rdbCasado.TabIndex = 3;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // ckbFilhos
            // 
            this.ckbFilhos.AutoSize = true;
            this.ckbFilhos.Location = new System.Drawing.Point(247, 40);
            this.ckbFilhos.Name = "ckbFilhos";
            this.ckbFilhos.Size = new System.Drawing.Size(53, 17);
            this.ckbFilhos.TabIndex = 4;
            this.ckbFilhos.Text = "Filhos";
            this.ckbFilhos.UseVisualStyleBackColor = true;
            // 
            // ckbAnimais
            // 
            this.ckbAnimais.AutoSize = true;
            this.ckbAnimais.Location = new System.Drawing.Point(247, 73);
            this.ckbAnimais.Name = "ckbAnimais";
            this.ckbAnimais.Size = new System.Drawing.Size(62, 17);
            this.ckbAnimais.TabIndex = 5;
            this.ckbAnimais.Text = "Animais";
            this.ckbAnimais.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(231, 294);
            this.dataGridView1.TabIndex = 4;
            // 
            // gpbPessoas
            // 
            this.gpbPessoas.Controls.Add(this.dataGridView1);
            this.gpbPessoas.Location = new System.Drawing.Point(539, 12);
            this.gpbPessoas.Name = "gpbPessoas";
            this.gpbPessoas.Size = new System.Drawing.Size(243, 328);
            this.gpbPessoas.TabIndex = 5;
            this.gpbPessoas.TabStop = false;
            this.gpbPessoas.Text = "Lista de Pessoas";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 456);
            this.Controls.Add(this.gpbPessoas);
            this.Controls.Add(this.gpbDadosComp);
            this.Controls.Add(this.gpbDadosPrincipais);
            this.Controls.Add(this.btnOk);
            this.Name = "frmPrincipal";
            this.Text = "Aula de Exemplo";
            this.gpbDadosPrincipais.ResumeLayout(false);
            this.gpbDadosPrincipais.PerformLayout();
            this.gpbDadosComp.ResumeLayout(false);
            this.gpbDadosComp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbPessoas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.GroupBox gpbDadosPrincipais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltbTipoEndereco;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.GroupBox gpbDadosComp;
        private System.Windows.Forms.CheckBox ckbAnimais;
        private System.Windows.Forms.CheckBox ckbFilhos;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbSolteiro;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpbPessoas;
    }
}

