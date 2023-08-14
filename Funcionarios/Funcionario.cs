using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybankADM
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }

        //public string Email { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalFuncionario { get; private set; }

        public abstract double GetBonificacao();
        

        public Funcionario(string cpf,double salario)
        {
            this.CPF = cpf;
            this.Salario= salario;
            TotalFuncionario++;
            Console.WriteLine("Criando funcionario !");
        }
        public abstract void AumentoSalario();
       
    }
}
