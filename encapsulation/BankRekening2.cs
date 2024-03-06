using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace encapsulation
{
    public class BankRekening2
    {
        private decimal saldo;
        private decimal minimumSaldo;
        private readonly string rekeningNummer;
        public BankRekening2(string rekeningNummer, decimal startSaldo, decimal minimumSaldo)
        {
            saldo = startSaldo;
            this.rekeningNummer = rekeningNummer;
            this.minimumSaldo = minimumSaldo;
        }
        public bool Storting(decimal storting)
        {
            if (storting > 0) 
            { 
                saldo += storting;
                return true;
            }
            return false;
        }
        public bool Opname(decimal opname)
        {
            if (opname > 0 && (saldo - opname > minimumSaldo))
            {
                saldo -= opname;
                return true;
            }
            return false;
        }
        public string GetRekeningNummer() { return rekeningNummer; }
        public decimal GetSaldo() { return saldo;}

        public decimal GetMinimumSaldo()  {return minimumSaldo;}

        public void SetMinimumSaldo(decimal minimumSaldo)
        {
            this.minimumSaldo  = (minimumSaldo < 0) ? minimumSaldo : this.minimumSaldo;
        }
    }
}
