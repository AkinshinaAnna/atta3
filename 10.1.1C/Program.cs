using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProgramLogic;
using UtilsC;

namespace _10._1._1C
{
    class Program
    {
        public static bool AskQuestion(string question)
        {
            while (true)
            {
                Console.Write(question);
                string answer = Console.ReadLine();

                if (answer == "y" || answer == "n")
                    return answer == "y";
            }
        }

       

       



        static void Main(string[] args)
        {
        }
    }
}
