using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEITO_GRANDE_ORDEM
{
    public abstract class Seres
    {
        public string Name { get; private set; }
        public int Lvl { get; private set; }
        public int Exp { get; private set; }

        public Seres(string name)
        {
            DefineName(name);
            Exp = 1;
            DefineLvl(Exp);
        }

        public Seres(string name, int exp)
        {
            DefineName(name);
            Exp = exp;
            DefineLvl(Exp);
        }

        public void DefineName(string name)
        {
            Name = name;
        }

        private void DefineLvl(int exp)
        {
            Lvl = Convert.ToInt32(Math.Sqrt(Exp));
        }

        public void IncreaseLvl(int exp)
        {
            Exp += exp;
            DefineLvl(Exp);
        }
    }
}
