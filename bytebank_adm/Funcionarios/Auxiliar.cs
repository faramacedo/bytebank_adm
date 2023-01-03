using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    internal class Auxiliar : Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 0.2;
        }
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
            //Console.WriteLine("Criando um diretor.");
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.2;
        }
    }
}
