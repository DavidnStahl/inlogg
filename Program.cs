using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filerSparaLösenord
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            while (play)
            {
                var startGame = new Meny();
                int val = startGame.MenyToStart();
                if (val == 1)
                {
                    Console.Write("användarnamn: ");
                    string username = Console.ReadLine();
                    Console.Write("password: ");
                    string password = Console.ReadLine();
                    string saveinput = (username + " " + password);
                    if (startGame.LoggaIn(saveinput))
                    {
                        Console.WriteLine("Du är inloggad grattis!!");
                    }
                    else if (!startGame.LoggaIn(saveinput)) { Console.WriteLine("Fel inloggning uppgifter, försök igen, eller registera nya uppgifter:"); }

                    


                }
                else if (val == 2)
                {
                    while (true)
                    {
                        Console.Write("Skriv nytt användarnamn: ");
                        string username = Console.ReadLine();
                        Console.Write("Skriv nytt Lösenord: ");
                        string password = Console.ReadLine();
                        string saveinput = (username + " " + password);

                        if (!startGame.RegistreraAnvändarnamn(saveinput))
                        {
                            Console.WriteLine("Din regitrering är klar!!");
                            startGame.AddNewUsernameAndPassword(saveinput);
                            break;

                        }
                        else if (startGame.RegistreraAnvändarnamn(saveinput))
                        {
                            Console.WriteLine("Användarnamnet finns redan!! försök igen");
                        }
                    }
                }
            }
            




        }
    }
}
