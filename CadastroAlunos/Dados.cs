using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunos
{
    class Dados
    {
        //CONSIGO POR E COLOCAR VALORS PRIVADOS AQUI ATRAVÉS DO GET E SET
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string rua { get; set; }
        public Int32 num { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public Int64 cep { get; set; }
        public string curso { get; set; }
        public string periodo { get; set; }
        public Int32 ano { get; set; }
    }
}
