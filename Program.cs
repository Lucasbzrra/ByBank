using BybankADM;
using BybankADM.Funcionarios;
using BybankADM.Parceiro;
using BybankADM.SistemaInterno;
using bytebank_ADM.Utilitario;
using System.ComponentModel.DataAnnotations;


#region
//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//Funcionario andre = new Funcionario("546.879.157-20",2000);
//andre.Nome = "André";


//Diretor maria = new Diretor("454.658.148-3",5000);
//maria.Nome = "Maria";



//gerenciador.Registrar(maria);
//gerenciador.Registrar(andre);
//Console.WriteLine(Funcionario.TotalFuncionario);
//Console.WriteLine(maria.Salario);
//Console.WriteLine(andre.Salario);
//maria.AumentoSalario();
//Console.WriteLine(andre.Salario);
//Console.WriteLine(maria.Salario);
#endregion
//CalcularBonficacao();
//void CalcularBonficacao()
//{
//    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//    Designer Amanda=new Designer("06876310175");
//    Amanda.Nome = "Amanda Benta";

//    Auxiliar James=new Auxiliar("06876310174");
//    James.Nome = "james Rdoriguesz";

//    GerentesDeContas Oliver = new GerentesDeContas("07876310175");
//    Oliver.Nome = ("Oliver Hack");

//    Diretor Emilho = new Diretor("0687623155");
//    Emilho.Nome = "Emilho diaz";

//    gerenciador.Registrar(Amanda);
//    gerenciador.Registrar(James);
//    gerenciador.Registrar(Oliver);
//    gerenciador.Registrar(Emilho);
//    Console.WriteLine("Total de Bonificação = " + gerenciador.getBonificacao());

//}
UsarSistema();
void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor Rodrygo = new Diretor("06876310170");
    Rodrygo.Nome = "Rodrygo";
    Rodrygo.Senha = "123";
    Rodrygo.Email = "Rdoriginho@outlook.com";

    sistemaInterno.logar(Rodrygo, "Rdoriginho@outlook.com", "457");

    GerentesDeContas Olivia = new GerentesDeContas("88668908121");
    Olivia.Nome = "Olivia";
    Olivia.Senha = "456";
    Olivia.Email = "olivia@210";
    sistemaInterno.logar(Olivia,"olivia@210", "456");

    ParceiroComercial parceiroComercial = new ParceiroComercial();
    parceiroComercial.Email = "Teste@teste";
    parceiroComercial.Senha = "0123";
    sistemaInterno.logarPaceiro(parceiroComercial, "Teste@teste", "0123");
    Console.ReadKey();
}