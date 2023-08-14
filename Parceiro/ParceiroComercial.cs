using BybankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybankADM.Parceiro
{
    public class ParceiroComercial: IAutenticavel
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Auntenticar(string senha)
        {
            return this.Senha==senha;
        }

        public bool Auntenticar(string email, string senha)
        {
            return this.Senha == senha && this.Email == email;
        }
    }
}
