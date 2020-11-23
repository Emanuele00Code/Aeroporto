using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroporto.CLASSES
{
    class AereoMotore : Aeromobile,ICompare
    {
        // Dichiaro la variabile Cavalli come intero
        public int _Cavalli;
        public AereoMotore(string sigla, int Cavalli) : base(sigla)
        {
            this._Cavalli = Cavalli;
        }
        // Implemento il metodo Superiore
        public override bool Superiore()
        {
            ICompare(int _PotenzaSecondoAereo)
            {
                if (this._Cavalli > _PotenzaSecondoAereo)
                    return true;
                else
                    return false;
            }
        }
        public int GetCavalli()
        {
            return _Cavalli;
        }
    }
}
