using BybankADM;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.GetBonificacao();
        }

        public void Registrar(Diretor funcionario)
        {
            this.totalBonificacao += funcionario.GetBonificacao();
        }

        public double getBonificacao()
        {
            return this.totalBonificacao;
        }
    }
}