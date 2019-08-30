using Model;
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

namespace View
{
    public partial class frmCadPessoa : Form
    {
        private Pessoa p = new Pessoa();

        public frmCadPessoa()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = CarregarPessoaDoForm();

            //Enviar objeto para camada de controle para Salvar no arquivo
            PessoaCtrl control = new PessoaCtrl();

            control.SalvarPessoaNoArquivo(pessoa);
        }

        //Carregar dados do formulário em um Novo Objeto do Tipo Pessoa
        public Pessoa CarregarPessoaDoForm()
        {
            try
            {
                p.Nome = txbNome.Text;
                p.Telefone = mtbTel.Text;
                p.Email = txbEmail.Text;
                p.TipoEndereco = ltbTipoEndereco.SelectedIndex;
                p.Endereco = txbEndereco.Text;
                p.Estado = cmbEstado.SelectedIndex;
                p.Cidade = cmbCidade.SelectedIndex;

                if (rdbMasculino.Checked)
                {
                    p.Sexo = "masculino";
                }
                if (rdbFeminino.Checked)
                {
                    p.Sexo = "feminino";
                }

                if (rdbCasado.Checked)
                {
                    p.EstadoCivil = "casado";
                }
                if (rdbSolteiro.Checked)
                {
                    p.EstadoCivil = "solteiro";
                }

                p.Filhos = ckbFilhos.Checked;

                p.Animais = ckbAnimais.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar usuário: " + ex.Message);
            }

            return p;
        }

        private void ptbFoto_Click(object sender, EventArgs e)
        {
            if (janelaAbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                p.Imagem = janelaAbrirArquivo.FileName;
            }
        }

        private void txbNome_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
        }
    
        
    }
}
