using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank
{
    public class Cliente
    {
        public string Nome { get; set; }
        private string _cpf;
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
                //codigo de validação
            }
        }
        
        public string Profissao { get; set; }
       
    }
}
