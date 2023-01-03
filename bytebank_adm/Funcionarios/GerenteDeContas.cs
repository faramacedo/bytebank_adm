using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
            //Console.WriteLine("Criando um diretor.");
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
