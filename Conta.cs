public class Conta
{
    private double Saldo;

    public void SetSaldo(double saldo)
    {
        if (saldo >= 0)
        {
            Saldo = saldo;
            Console.WriteLine("Saldo adicionado com sucesso");
        }
        else
        {
            Console.WriteLine("Saldo inválido");
        }
    }
}
