namespace View
{
    partial class frmListaPessoas
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
            this.gpbPessoas = new System.Windows.Forms.GroupBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.gcolID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcolNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcolEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gpbPessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPessoas
            // 
            this.gpbPessoas.Controls.Add(this.dgvDados);
            this.gpbPessoas.Location = new System.Drawing.Point(12, 12);
            this.gpbPessoas.Name = "gpbPessoas";
            this.gpbPessoas.Size = new System.Drawing.Size(350, 392);
            this.gpbPessoas.TabIndex = 6;
            this.gpbPessoas.TabStop = false;
            this.gpbPessoas.Text = "Lista de Pessoas";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcolID,
            this.gcolNome,
            this.gcolEmail});
            this.dgvDados.Location = new System.Drawing.Point(6, 28);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(326, 354);
            this.dgvDados.TabIndex = 4;
            // 
            // gcolID
            // 
            this.gcolID.HeaderText = "ID";
            this.gcolID.Name = "gcolID";
            this.gcolID.ReadOnly = true;
            this.gcolID.Width = 40;
            // 
            // gcolNome
            // 
            this.gcolNome.HeaderText = "Nome";
            this.gcolNome.Name = "gcolNome";
            this.gcolNome.ReadOnly = true;
            this.gcolNome.Width = 130;
            // 
            // gcolEmail
            // 
            this.gcolEmail.HeaderText = "E-mail";
            this.gcolEmail.Name = "gcolEmail";
            this.gcolEmail.ReadOnly = true;
            this.gcolEmail.Width = 150;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(287, 410);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmListaPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 440);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gpbPessoas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListaPessoas";
            this.Text = "Pessoas Cadastradas";
            this.Load += new System.EventHandler(this.frmListaPessoas_Load);
            this.gpbPessoas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPessoas;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcolID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcolNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcolEmail;
    }
}