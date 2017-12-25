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
            {
                return (double)this.A / line.A == (double)this.B / line.B;
            }
        }

        
        
    }
}
