try
{
    Conta c = new Conta();

    Console.WriteLine("Informe um valor para adicionar a sua conta.");
    double saldo = double.Parse(Console.ReadLine());

    c.SetSaldo(saldo);
}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}