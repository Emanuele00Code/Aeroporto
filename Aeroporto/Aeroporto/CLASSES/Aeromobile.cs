using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroporto.CLASSES
{
    abstract class Aeromobile : ICompare
    {
        protected string _sigla;

        public Aeromobile(string sigla)
        {
            this._sigla = sigla;
        }
        public abstract bool Superiore();

        public string Sigla
        {
            get { return _sigla; }
        }

    }
}
