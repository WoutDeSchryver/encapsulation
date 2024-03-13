using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    private readonly int protocolNummer
    private readonly int echtRekeningNummer
    private readonly int controleNummer
    public readonly string rekeningNummer 

    public class RekeningNummer(int protocolNummer, int rekeningNummer)
    {
        this.protocolNummer = protocolNummer
        this.echtRekeningNummer = rekeningNummer
        this.controleNummer = (protocolNummer + rekeningNummer) % 97
        this.rekeningNummer = $"BE{protocolNummer}{echtRekeningNummer}{controleNummer}"
    }
}
