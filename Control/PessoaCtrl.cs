using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dao;

namespace Control
{
    public class PessoaCtrl
    {
        public Boolean SalvarPessoaNoArquivo(Pessoa _p)
        {
            try
            {
                PessoaDAO dao = new PessoaDAO();

                dao.SalvarPessoaNoArquivo(_p);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Pessoa> ListarPessoasDoArquivo()
        {
            try
            {
                PessoaDAO dao = new PessoaDAO();

                return dao.ListarPessoasDoArquivo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
