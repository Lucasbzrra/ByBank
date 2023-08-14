using BybankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BybankADM.Funcionarios
{
    public class GerentesDeContas: FuncionariosAutenticavel
    {
        public GerentesDeContas(string cpf):base(cpf,4000)
        {
            
        }
        
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
        public override void AumentoSalario()
        {
            Salario *= 0.05;
        }

    }
}
