using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FEITO_GRANDE_ORDEM
{
    internal class Servants : Seres
    {
        public int Index {  get; private set; }
        public int HP {  get; private set; }
        public int ATK {  get; private set; }
        public int DEF {  get; private set; }
        public char Type {  get; private set; }
        public string Clas { get; private set; }

        public Servants(string name, int index, int hp, int atk, int def, char type, string clas) : base(name) 
        {
            Index = index;
            HP = hp;
            ATK = atk;
            DEF = def;
            Type = type;
            Clas = clas;
        }

        public override string ToString()
        {
            return $"{Index} - {Name}";
        }
    }
}
