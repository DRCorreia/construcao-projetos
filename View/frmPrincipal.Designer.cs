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
            this.components = new System.ComponentModel.Container();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.itmArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraTarefa = new System.Windows.Forms.ToolStrip();
            this.itbCadPessoa = new System.Windows.Forms.ToolStripButton();
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.itsLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmHora = new System.Windows.Forms.Timer(this.components);
            this.mnPrincipal.SuspendLayout();
            this.barraTarefa.SuspendLayout();
            this.barraStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmArquivo});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(830, 24);
            this.mnPrincipal.TabIndex = 6;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // itmArquivo
            // 
            this.itmArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem});
            this.itmArquivo.Name = "itmArquivo";
            this.itmArquivo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.itmArquivo.Size = new System.Drawing.Size(61, 20);
            this.itmArquivo.Text = "A&rquivo";
            this.itmArquivo.ToolTipText = "Item arquivo";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastrarToolStripMenuItem.Text = "&Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarToolStripMenuItem.Text = "&Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 6);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // barraTarefa
            // 
            this.barraTarefa.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.barraTarefa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itbCadPessoa});
            this.barraTarefa.Location = new System.Drawing.Point(0, 24);
            this.barraTarefa.Name = "barraTarefa";
            this.barraTarefa.Size = new System.Drawing.Size(830, 52);
            this.barraTarefa.TabIndex = 7;
            this.barraTarefa.Text = "toolStrip1";
            // 
            // itbCadPessoa
            // 
            this.itbCadPessoa.Image = global::View.Properties.Resources.nova_pessoa;
            this.itbCadPessoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itbCadPessoa.Name = "itbCadPessoa";
            this.itbCadPessoa.Size = new System.Drawing.Size(97, 49);
            this.itbCadPessoa.Text = "Pessoas";
            this.itbCadPessoa.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // barraStatus
            // 
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itsLabelHora});
            this.barraStatus.Location = new System.Drawing.Point(0, 403);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(830, 22);
            this.barraStatus.TabIndex = 9;
            this.barraStatus.Text = "statusStrip1";
            // 
            // itsLabelHora
            // 
            this.itsLabelHora.Name = "itsLabelHora";
            this.itsLabelHora.Size = new System.Drawing.Size(49, 17);
            this.itsLabelHora.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::View.Properties.Resources.logo_lasalle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tmHora
            // 
            this.tmHora.Interval = 1000;
            this.tmHora.Tick += new System.EventHandler(this.tmHora_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 425);
            this.Controls.Add(this.barraStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barraTarefa);
            this.Controls.Add(this.mnPrincipal);
            this.MainMenuStrip = this.mnPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Aula de Exemplo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.barraTarefa.ResumeLayout(false);
            this.barraTarefa.PerformLayout();
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem itmArquivo;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStrip barraTarefa;
        private System.Windows.Forms.ToolStripButton itbCadPessoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.ToolStripStatusLabel itsLabelHora;
        private System.Windows.Forms.Timer tmHora;
    }
}

