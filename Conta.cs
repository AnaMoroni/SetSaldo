public class Conta
{
    private double Saldo;

    public void SetSaldo(double saldo)
    {
        try
        {
            if (saldo > 0)
            {
                Saldo = saldo;
                Console.WriteLine("Saldo adicionado com sucesso");
            }
            else
            {
                throw new Exception("O saldo não pode ser negativo");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
