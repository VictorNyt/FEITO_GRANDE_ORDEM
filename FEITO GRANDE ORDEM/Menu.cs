using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FEITO_GRANDE_ORDEM
{
    internal class Menu
    {
        List<string> options;
        public Menu()
        {
            if (options == null)
            {
                CreateMenu();
            }
            ShowMenu();
        }
        private void CreateMenu()
        {
            options = new List<string>();
            options.Add("Characters");
            options.Add("Team");
            options.Add("Enhance");
            options.Add("Fight");
        }
        public void ShowMenu()
        {
            Console.WriteLine("Choose a number for the option\n(Only number are valid)");
            int count = 0;
            foreach (var item in options)
            {
                count++;
                Console.WriteLine($"{count} - {item}");
            }
        }
        private void ShowChar()
        {

        }
    }
}
