using BybankADM.Funcionarios;
using BybankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BybankADM
{
    public class Diretor : FuncionariosAutenticavel
    { 
        public Diretor(string cpf) : base(cpf, 5000)
        {
        }
        
        public override double GetBonificacao()
        {
            return Salario * 0.50;
        }
        public override void AumentoSalario()
        {
            this.Salario *= 1.15;
        }

    }
}
