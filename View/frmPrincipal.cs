using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Control;

namespace View
{
    public partial class frmPrincipal : Form
    {

        private Dictionary<Int64, Pessoa> mapaPessoas;

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

            Int64 ultimaChave = mapaPessoas.Keys.Max() + 1;

            //Int64 ultimoID = Convert.ToInt64(tamChaves);

            form.Tag = ultimaChave;

            form.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tmHora.Enabled = true;

            CarregarListaPessoas();
        }

        private void tmHora_Tick(object sender, EventArgs e)
        {
            itsLabelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoa form = new frmCadPessoa();

            form.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaPessoas form = new frmListaPessoas();

            form.Tag = mapaPessoas;

            form.ShowDialog();
        }

        private void CarregarListaPessoas()
        {
            try
            {
                PessoaCtrl control = new PessoaCtrl();

                mapaPessoas = control.ListarPessoasDoArquivo();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR LISTA DE PESSOAS: " + ex.Message);
            }
        }
    }
}
