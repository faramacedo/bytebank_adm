using bytebank_adm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Parceria
{
    public class ParceiroComercial : IAutenticavel
    {
        public ParceiroComercial()
        {
            Console.WriteLine("Criando parceiro comercial.");
        }

        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
