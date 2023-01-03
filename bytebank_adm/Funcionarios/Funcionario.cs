using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace bytebank_adm.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public abstract double GetBonificacao();
        
        public abstract void AumentarSalario();

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
            Console.WriteLine("Criando um funcionário.");
        }


    }
}
