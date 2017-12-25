using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
   public  class ClassList
    {
       /* 1.	Для набора линий вида ax + by + c = 0 найти наибольшее кол-во параллельных линий
            (совпадающие линии считаются параллельными). Вернуть наибольшее множество параллельных линий
            в виде списка / массива индексов линий из переданного набора.В случае существования нескольких
            различных наборов параллельных линий из максимального кол-ва элементов – выбрать произвольный.
        */
        public List<Line> Line { get; set; }

        public ClassList (List<Line> line)
        {
            this.Line = line;
        }

        public  List<int> Result()
        {
            List<int> indexes = new List<int>();
            List<int> result = new List<int>();
            List<int> counted = new List<int>();
            for (int i = 0; i < Line.Count - 1; i++)
            {
                for (int j = i; j < Line.Count; j++)
                {
                    if (Line[i].IsParallel(Line[j]) && !counted.Contains(j))
                    {
                        counted.Add(j);
                        indexes.Add(j);
                    }
                }
                if (indexes.Count > result.Count) result = indexes;
                indexes.Clear();
            }
            return result;
        }
    }
}
