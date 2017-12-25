using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramLogic
{
    public class LineFilesUtils
    {
       

        public static List<Line> ReadLineListFromFile(string path)
        {
            List<Line> coefficientList = new List<Line>();

            string[] fileLines = File.ReadAllLines(path);

            foreach (string line in fileLines)
            {
                string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                double a = double.Parse(parts[0]);
                double b = double.Parse(parts[1]);
                double c = double.Parse(parts[2]);

                coefficientList.Add(new Line(a, b, c));
            }

            return coefficientList;
        }

        public static void SaveLineListInFile(string path, List<Line> coefficients)
        {
            List<string> lines = new List<string>();

            foreach (Line coefficient in coefficients)
            {
                lines.Add(coefficient.A + " " + coefficient.B + " "+ coefficient.C+" ");
            }

            File.WriteAllLines(path, lines);
        }

    }
}
