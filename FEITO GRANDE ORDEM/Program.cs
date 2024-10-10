// See https://aka.ms/new-console-template for more information
//FAN PROJETO DE FATE
using FEITO_GRANDE_ORDEM;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player;
        int choice = 0;
        Boolean faltrue = true;
        do
        {
            Console.WriteLine("1 - New Game\n2 - Load Game\n3 - Exit");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Choose a valid option");
            }
            switch (choice)
            {
                case 1:
                    //Console.Clear();
                    Console.Write("Please choose your name:");

                    player = new Player(Console.ReadLine());
                    faltrue = false;
                    break;
                case 2:
                    //Console.Clear();
                    Console.Write("Write the name of the player:");

                    player = new Player(Console.ReadLine());
                    player = player.Load();
                    faltrue = false;
                    break;
                case 3:
                    //Console.Clear();
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }
        } while (faltrue);


        Database data = new Database();

        do
        {
            //Console.Clear();
            Menu menu = new Menu();
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please select a valid option");
            }
            switch (choice)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                default:
                    Console.WriteLine("Please select a valid option");
                    break;
            }
        } while (true);
    }
}