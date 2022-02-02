﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public Diretor(string cpf) :base(5000, cpf)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.15; 
        }
    }
}
 