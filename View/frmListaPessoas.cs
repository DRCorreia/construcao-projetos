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
            CarregarMapaPessoas();
        }

        private void CarregarMapaPessoas()
        {
            Dictionary<Int64, Pessoa> mapaPessoas = (Dictionary<Int64, Pessoa>)this.Tag;
            foreach (Pessoa o in mapaPessoas.Values)
            {
                dgvDados.Rows.Add(o.Id, o.Nome, o.Email);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //dgvDados.SelectedRows[0].Cells[2]
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO SELECIONAR LINHA: " + ex.Message);
            }
        }

    }
}
