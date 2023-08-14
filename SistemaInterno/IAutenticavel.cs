using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybankADM.SistemaInterno
{
   public  interface  IAutenticavel 
    {
        //private string Email;

        //public string _email
        //{
        //    get
        //    {
        //        return Email;
        //    }
        //    set
        //    {
        //        if (value.Contains("@") == true)
        //        {
        //            Email = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("email ivalido");
        //        }
        //    }
        //}
        public string Email { get; set; }
        public  string Senha { get; set; }
        public abstract bool Auntenticar(string email,string senha);
        
    }
}
