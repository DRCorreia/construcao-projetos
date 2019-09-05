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

        public Dictionary<Int64, Pessoa> ListarPessoasDoArquivo()
        {
            try
            {
                Dictionary<Int64, Pessoa> mapaPessoas = new Dictionary<Int64, Pessoa>();
                PessoaDAO dao = new PessoaDAO();

                foreach (Pessoa o in dao.ListarPessoasDoArquivo())
                {
                    mapaPessoas.Add(o.Id, o);
                }

                return mapaPessoas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
