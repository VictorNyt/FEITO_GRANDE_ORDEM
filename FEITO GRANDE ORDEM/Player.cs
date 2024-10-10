using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEITO_GRANDE_ORDEM
{
    internal class Player : Seres
    {
        private List<int> ServIndex;
        private List<int> ServLvl;

        public Player(string name) : base(name)
        {
            Save();
        }
        public Player(string name, int exp, List<int> servInd, List<int> servLv) : base(name, exp)
        {
            ServIndex = servInd;
            ServLvl = servLv;
        }

        private string path;

        private string Save()
        {
            path = @"F:\feito\" + Name + ".txt";
            if (!File.Exists(path))
            {
                string ind = "";
                string lvl = "";
                if (ServIndex == null)
                {
                    ind = "0";
                }
                else
                {
                    foreach (int i in ServIndex)
                    {
                        ind += Convert.ToString(i);
                        ind += ",";
                    }
                }
                if (ServLvl == null)
                {
                    lvl = "0";
                }
                else
                {
                    foreach (int i in ServLvl)
                    {
                        lvl += Convert.ToString(i);
                        lvl += ",";
                    }
                }
                File.Create(path).Dispose();
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine($"{Name}");
                tw.WriteLine($"{ind}");
                tw.WriteLine($"{lvl}");
                tw.WriteLine($"{Exp}");
                tw.Close();

                return "New save created";
            }
            else if (File.Exists(path))
            {
                return "Loading game!!!";
            }
            return "Save with that name already exists";
        }

        public Player Load()
        {
            Player player = null;
            path = @"F:\feito\" + Name + ".txt";
            List<string> list = new List<string>();
            IEnumerable<string> lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                string field = Convert.ToString(line.Split(','));
                list.Add(field);
            }
            string name1 = list.First();
            int exp1 = int.Parse(list.Last());
            list.Remove(list.First());
            list.Remove(list.Last());

            List<int> ind = new List<int>();
            List<int> lv = new List<int>();

            int lcounter = list.Count();

            for (int x = 0; x < lcounter / 2; x++)
            {
                ind.Add(int.Parse(list.First()));
                list.Remove(list.First());
            }
            lcounter = list.Count();
            for (int x = 0; x < lcounter; x++)
            {
                lv.Add(int.Parse(list.First()));
                list.Remove(list.First());
            }


            player = new Player(name1, exp1, lv, ind);

            return player;
        }
    }
}
