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

        public List<Pessoa> ListarPessoasDoArquivo()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            try
            {
                String dir = AppDomain.CurrentDomain.BaseDirectory;
                String path = dir + "bd.txt";

                StreamReader leitor = new StreamReader(path);
                
                String arquivo = leitor.ReadToEnd();

                Char[] separadorLinhas = { '\n' };
                Char[] separadorColunas = { ';' };

                String[] linhas = arquivo.Split(separadorLinhas);
                for (int i = 0; i < linhas.Length - 1; i++)
                {
                    Pessoa p = new Pessoa();

                    String[] colunas = linhas[i].Split(separadorColunas);

                    //Populando campos do objeto pessoa pelos objetos do vetor
                    p.Nome = colunas[0];
                    p.Telefone = colunas[1];
                    p.Email = colunas[2];
                    p.TipoEndereco = Convert.ToInt32(colunas[3]);
                    p.Endereco = colunas[4];
                    p.Estado = Convert.ToInt32(colunas[5]);
                    p.Cidade = Convert.ToInt32(colunas[6]);
                    p.Sexo = colunas[7];
                    p.EstadoCivil = colunas[8];
                    p.Filhos = Convert.ToBoolean(colunas[9]);
                    p.Animais = Convert.ToBoolean(colunas[10]);

                    listaPessoas.Add(p);
                }
                leitor.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaPessoas;
        }
   
    }
}
