using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class PessoaDAO
    {
        public Boolean SalvarPessoaNoArquivo(Pessoa _p)
        {
            String dir = AppDomain.CurrentDomain.BaseDirectory;
            String path =  dir + "bd.txt";
            try
            {
                StreamWriter escritor = new StreamWriter(path, true);

                escritor.Write(_p.Nome + ";");
                escritor.Write(_p.Telefone + ";");
                escritor.Write(_p.Email + ";");
                escritor.Write(_p.TipoEndereco + ";");
                escritor.Write(_p.Endereco + ";");
                escritor.Write(_p.Estado + ";");
                escritor.Write(_p.Cidade + ";");
                escritor.Write(_p.Sexo + ";");
                escritor.Write(_p.EstadoCivil + ";");
                escritor.Write(_p.Filhos + ";");
                escritor.WriteLine(_p.Animais + ";");

                escritor.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }
    }
}
