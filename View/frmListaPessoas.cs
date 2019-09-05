using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Model;

namespace View
{
    public partial class frmListaPessoas : Form
    {
        public frmListaPessoas()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaPessoas_Load(object sender, EventArgs e)
        {
            CarregarListaPessoas();
        }

        private void CarregarListaPessoas()
        {
            try
            {
                PessoaCtrl control = new PessoaCtrl();

                List<Pessoa> listaPessoas = control.ListarPessoasDoArquivo();
                int i = 0;
                foreach (Pessoa o in listaPessoas)
                {
                    i++;
                    dgvDados.Rows.Add(i, o.Nome, o.Email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR LISTA DE PESSOAS: " + ex.Message);
            }
        }
    }
}
