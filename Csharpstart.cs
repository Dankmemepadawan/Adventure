using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Program
    {
        private static int playermoney = 100;
        private static int playerhealth = 100;

        static void start()
        {
            
            string surrounding;
            string name;
            int age;
         
            Random random = new Random();
            int randomNumber = random.Next(1, 6);
            switch (randomNumber)
            {
                case 1:
                    surrounding = "Desert";
                    break;
                case 2:
                    surrounding = "Forrest";
                    break;
                case 3:
                    surrounding = "Snowy Tundra";
                    break;
                case 4:
                    surrounding = "Gravelly Mountain region";
                    break;
                case 5:
                    surrounding = "flat plains area";
                    break;
                case 6:
                    surrounding = "Swamp";
                    break;
                default:
                    surrounding = "unknown location";
                    break;
            }
            Console.WriteLine("Do you know how to play? (y/n)");
            string intro = Console.ReadLine();
            if (intro == "n")
            {
                Console.WriteLine("");
                Console.WriteLine("You are a knight stranded in a " + surrounding);
                System.Threading.Thread.Sleep(2500);
                Console.WriteLine("Your arive with nothing but your armor and your self");
                System.Threading.Thread.Sleep(2500);
                Console.WriteLine("Far away you see a small village");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("You have no idea how you got here.");
                System.Threading.Thread.Sleep(4000);

                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine(name + ", what a fine name.. um...");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine(name + ", Much adventure is to come...");
                System.Threading.Thread.Sleep(3000);

                Console.WriteLine("but first, how old are you?");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Perfect!");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Before you begin you must understand the Rules");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("At any time when not asked for a particular answer or you are being spoken to you may type: ");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(5000);

                Console.WriteLine("health to cheak health");
                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("money to cheak balance");
                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("travel to um... travel");
                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("weapons to cheak weapon slots");
                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("defence to cheak defence slots");
                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("help to be reminded");
                System.Threading.Thread.Sleep(4000);


                Console.WriteLine("Understood?... Good, your adventure starts in 5");
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("4");
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("3");
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("2");
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("1");
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("now");
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("what do you want to do?");
            }

            else
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                Console.WriteLine("");
                
                Console.WriteLine("How old are you?");
                age = Convert.ToInt32(Console.ReadLine());

            }

        }

        static void health()
        {
            Console.WriteLine("You have " + playerhealth + " health!");
        }

        static void money()
        {
            Console.WriteLine("You have " + playermoney + " money!");
        }

        static void help()
        {

        }

        static void travel()
        {

        }

        static void attack()
        {

        }

        static void defence()
        {

        }

        static void Main(string[] args)
        {
            start();
            bool win = false;

            while (win == false)
            { 

            
                switch (Console.ReadLine())
                {
                    case "health":
                        health();
                        break;
                    case "money":
                        money();
                        break;
                    case "travel":
                        travel();
                        break;
                    case "attack":
                        attack();
                        break;
                    case "defence":
                        defence();
                        break;
                    case "help":
                        help();
                        break;
                    default:
                        Console.WriteLine("Thats not a command!")
                        break;
                }
            }
        }
    }
}
