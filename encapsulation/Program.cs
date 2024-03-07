namespace encapsulation
{
    internal class Program
    {
        static void Main()
        {
            BankRekening bankRekening = new BankRekening("000-0000000-00", 0,0);

            bankRekening.MinimumSaldo = -1250;

            if (bankRekening.Storting(100))
            {
                Console.WriteLine("storting gelukt"); 
            }
            else
            {
                Console.WriteLine("storting niet gelukt");
            }

            if (bankRekening.Opname(120))
            {
                Console.WriteLine("opname gelukt");
            }
            else
            {
                Console.WriteLine("opname niet gelukt");
            }

            Console.WriteLine($"rekeningnummer :  {bankRekening.RekeningNummer}");
            Console.WriteLine($"saldo : {bankRekening.Saldo}");
        }
    }
}
