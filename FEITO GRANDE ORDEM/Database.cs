using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEITO_GRANDE_ORDEM
{
    internal class Database
    {
        public Database() 
        {
            List<Servants> servants = new List<Servants>();

            string file = @"F:\feito\feito.txt";
            IEnumerable<string> lines = File.ReadAllLines(file);

            foreach (var line in lines)
            {
                var field = line.Split(',');
                int[] fields = new int[4];
                fields[0] = int.Parse(field[1]);
                fields[1] = int.Parse(field[2]);
                fields[2] = int.Parse(field[3]);
                fields[3] = int.Parse(field[4]);

                Servants serv = new Servants(field[0], fields[0], fields[1], fields[2], fields[3], Convert.ToChar(field[5]), field[6]);
                servants.Add(serv);
            }

            Servants ChooseServ(int index)
            {
                Servants ser = new Servants("Servant not found", 0, 1, 1, 1, 'a', "place holder");
                foreach (Servants serv in servants)
                {
                    if (serv.Index == index)
                    {
                        ser = serv;
                        break;
                    }
                }
                return ser;
            }
            foreach (var servant in servants)
            {
                Console.WriteLine(servant);
            }
        }
    }
}
