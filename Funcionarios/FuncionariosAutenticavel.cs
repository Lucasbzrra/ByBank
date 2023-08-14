using BybankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybankADM.Funcionarios
{
    public abstract class FuncionariosAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionariosAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }
        public string Email { get; set; }

        public bool Auntenticar(string email, string senha) => this.Email ==email && this.Senha==senha;
        
    }
}
