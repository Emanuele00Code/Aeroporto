using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroporto.CLASSES
{
     abstract class Aeromobile : ICompare
    {
        // Dichiaro la variabile _sigla di tipo stringa
        protected string _sigla;

        // Richiamo il metodo costruttore della classe Areomobile
        public Aeromobile(string sigla)
        {
            this._sigla = sigla;
        }

        // Implemento il membro di interfaccia ICompare.Superiori()
        public abstract bool Superiore(int _PotenzaSecondoAereo);

        // Richiamo il metodo GetSigla() per ricevere la Sigla
        public string GetSigla()
        {
            return _sigla ;
        }

    }
}
