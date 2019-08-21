using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class Teste
    {
        //-----------------------------------//
        public string Nome { get; set; }

        //------------------------//
        private String nome1;
        public String Nome1
        {
            get { return nome1; }
            set { nome1 = value; }
        }


        //-----------------------------//
        private String nome2;

        public String getNome2()
        {
            return this.nome2;
        }

        public void setNome2(String _nome2)
        {
            this.nome2 = _nome2;
        }
    }
}
