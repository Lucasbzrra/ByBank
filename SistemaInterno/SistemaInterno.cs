using BybankADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybankADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool logar(IAutenticavel funcionario,string email ,string senha )
        {
            bool usuarioAutenticado = funcionario.Auntenticar(email,senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta ou Usuário Invalido");
                return false;
            }
        }

        public bool logarPaceiro(IAutenticavel ParceiroComercial, string email, string senha)
        {
            bool usuarioAutenticado = ParceiroComercial.Auntenticar(email, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema Parceiro");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta ou Usuário Invalido");
                return false;
            }
        }

    }
}
