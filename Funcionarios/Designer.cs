using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybankADM.Funcionarios
{
    public class Designer: Funcionario
    {
        public Designer(string cpf):base(cpf, 3000)
        {

        }
        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
        public override void AumentoSalario()
        {
             Salario*=0.11;
        }
    }
}
