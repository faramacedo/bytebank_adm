using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    public class GerenciadorDeBonificacao
    {
        private double TotalDeBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();
        }

        public double GetBonificacao()
        {
            return this.TotalDeBonificacao;
        }
    }
}

