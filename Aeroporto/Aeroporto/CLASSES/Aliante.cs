﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeroporto.CLASSES
{
    class Aliante : Aeromobile
    {
        int _Efficienza = 0;

        public Aliante(string _sigla, int EffAlian) : base(_sigla)
        {
            this._Efficienza = EffAlian;
        }

        public int GetEfficienza()
        {
            return _Efficienza;
        }

        public override bool Superiore(int _PotenzaSecondoAereo)
        {
            if (this._Efficienza > _PotenzaSecondoAereo)
                return true;
            else
                return false;
        }






    }
}
