using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramLogic
{
    public class Line
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Line (double a, double b, double c)
        {
         this.A = a;
         this.B = b;
         this.C = c;
        }

       public bool IsParallel(Line line)
        {
            return Math.Abs( this.A/line.A - this.B /B) < 1e-6;
        }

        /* public List<int> CountLines(List<Line> line)
        {
            List<int> indexes = new List<int>();
            List<int> result = new List<int>();
            List<int> counted = new List<int>();
            for (int i = 0; i < line.Count - 1; i++)
            {
                for (int j = i; j < line.Count; j++)
                {
                    if (line[i].IsParallel(line[j]) && !counted.Contains(j))
                    {
                        counted.Add(j);
                        indexes.Add(j);
                    }
                }
                if (indexes.Count > result.Count) result = indexes;
                indexes.Clear();
            }
            return result;
            
        }*/
        /*{
            int count = 0;
            int maxcount = 0;
           

            for (int i = 0; i < line.Count - 1; i++)

            {


                for (int j = 0; j < line.Count - 1; j++)

                {
                    if (line[j].IsParallel(line[j + 1]))
                        count++;
                }
              maxcount<count



            return count;
                   
        }

        int MaxCount(List<Line> line)
        {
            int maxcount = 0;
            for (int i=0; i<line.Count-1; i++)
            {
                if (line[i].CountLines(line))
            }


            return maxcount;
        }
        */
        
    }
}
