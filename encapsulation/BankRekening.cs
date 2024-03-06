using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    public class BankRekening1
    {
        public decimal saldo;
        public decimal minimumSaldo;
        public string rekeningNummer;
        public BankRekening1(string rekeningNummer, decimal startSaldo, decimal minimumSaldo)
        {
            saldo = startSaldo;
            this.rekeningNummer = rekeningNummer;
            this.minimumSaldo = minimumSaldo;
        }

        public void Storting(decimal storting) 
        {
            saldo += storting;            
        }

        public void Opname(decimal opname)
        {
            saldo -= opname;
        }
    }
}
