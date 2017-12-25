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

        static List<Line> ReadLineList()
        {
            List<Line> lines;

            if (AskQuestion("Ввести данные из файла? y\n  "))
            {
                while (true)
                {
                    try
                    {
                        string inputFilePath = IOUtils.ReadValueFromConsole<string>("путь к файлу  ",
                            (path) => (File.Exists(path)));

                        lines = LineFilesUtils.ReadLineListFromFile(inputFilePath);
                        break;
                    }
                    catch (Exception e)
                    {

                    }
                }
            }
            else
            {
                int linesCount = IOUtils.ReadValueFromConsole<int>("количество линий  ", (count) => (count > 0));

                lines = new List<Line>(linesCount);

                for (int i = 0; i < linesCount; i++)
                {
                    double a = IOUtils.ReadValueFromConsole<double>("коэффициент a  ");
                    double b = IOUtils.ReadValueFromConsole<double>("коэффициент b  ");
                    double c = IOUtils.ReadValueFromConsole<double>("коэффициент c  ");

                    lines.Add(new Line(a, b, c));
                }
            }

            Console.WriteLine();
            return lines;
        }

        static void SaveLineListInFile(string line)
        {
            while (true)
            {
                try
                {
                    string outputFilePath = IOUtils.ReadValueFromConsole<string>("путь к файлу  ");

                    FileUtils.Write(outputFilePath, line);
                    return;
                }
                catch (Exception e)
                {

                }
            }

            Console.WriteLine();
        }

        static void PrintLineList( string result)
        {
            
           Console.WriteLine(" Результат: {0}", result);

           
            Console.WriteLine();
        }





        static void Main(string[] args)
        {
            while (true)
            {
               

                //  список прямых 
                List<Line> lines = ReadLineList();

                // Получаем список  параллельных прямых
                ClassList result = new ClassList(lines);
                List<int> resultlines = result.Result();

                string Result = ClassConvert.ListToStr(resultlines);

                PrintLineList(Result);

                if (AskQuestion("Сохранить список в файл? y\n  "))
                {
                    SaveLineListInFile(Result);
                }

               

                
            }
        }
    }
}
