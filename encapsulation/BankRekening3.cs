using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
        public class BankRekening
        {
            private decimal saldo;
            private decimal minimumSaldo;
            private readonly string rekeningNummer;

            public BankRekening(string rekeningNummer, decimal startSaldo, decimal minimumSaldo)
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

            public string RekeningNummer
            { 
                get { return rekeningNummer; } 
            }

            public decimal Saldo
            {
                get { return saldo; }
            }

            public decimal MinimumSaldo
            { 
                get { return minimumSaldo; } 
                set { minimumSaldo = (value < 0) ? value : minimumSaldo; }          
             }

        }
}
