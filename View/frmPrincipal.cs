using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCadPessoa form = new frmCadPessoa();

            form.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tmHora.Enabled = true;
        }

        private void tmHora_Tick(object sender, EventArgs e)
        {
            itsLabelHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
