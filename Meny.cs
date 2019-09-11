using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filerSparaLösenord
{
    class Meny
    {
        public int MenyToStart()
        {
            Console.WriteLine("Meny: ");
            Console.WriteLine("a : Logga in ");
            Console.WriteLine("b : Registrera ");
            Console.Write("Välj a eller b: ");
            string userinput = Console.ReadLine();

            if (userinput == "a") { return 1; }
            if (userinput == "b") { return 2; }

            return 0;

        }
        public bool LoggaIn(string input)
        {
            StreamReader path = new StreamReader(@"C:\Users\dns20\source\repos\filerSparaLösenord\filerSparaLösenord\usernamepassword.txt");
            bool ok = false;
            using (path)
            {
                string line = path.ReadLine();

                while (line != null)
                {
                    line = path.ReadLine();

                    if (line == input) { ok = true; }
                }
            }

            return ok;


        }
        public bool RegistreraAnvändarnamn(string input)
        {


            StreamReader path = new StreamReader(@"C:\Users\dns20\source\repos\filerSparaLösenord\filerSparaLösenord\usernamepassword.txt");
            bool ok = false;
            using (path)
            {
                string line = path.ReadLine();

                while (line != null)
                {
                    line = path.ReadLine();

                    if (line == input) { ok = true; }
                }
            }

            return ok;


        }
        public bool CheckUserName(string username)
        {
            StreamReader path = new StreamReader(@"C:\Users\dns20\source\repos\filerSparaLösenord\filerSparaLösenord\usernamepassword.txt");
            bool ok = false;
            using (path)
            {
                string line = path.ReadLine();

                while (line != null)
                {
                    line = path.ReadLine();

                    if (line == username)
                    {
                        ok = true;
                    }
                }
            }

            return ok;
        }
        public void AddNewUsernameAndPassword(string input)
        {
            string path = @"C:\Users\dns20\source\repos\filerSparaLösenord\filerSparaLösenord\usernamepassword.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(input);
            }

        }
    }
}
