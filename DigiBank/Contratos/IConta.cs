using DigiBank.Classes;

namespace DigiBank.Contratos
{
    public interface IConta
    {
        void Deposito(double valor);
        bool Saque(double valor);
        double ConsultaSaldo();
        string GetCodigoDoBanco();
        string GetNumeroAgencia();
        string GetNumeroDaConta();
        List<Extrato> Extrato();
    }
}
