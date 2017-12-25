using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramLogic;

namespace UtilsF
{
    public class LineDGVConvert
    {
        public static List<Line> DGVToLineList(DataGridView dgv)
        {
            List<Line> coefflist = new List<Line>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
               
                int a = (int)Convert.ChangeType(row.Cells["InputLineDGV_a"].Value, typeof(int));
                int b = (int)Convert.ChangeType(row.Cells["InputLineDGV_b"].Value, typeof(int));
                int c = (int)Convert.ChangeType(row.Cells["InputLineDGV_c"].Value, typeof(int));



                Line coefficients = new Line(a, b, c);

                coefflist.Add(coefficients);
            }

            return coefflist;
        }

        public static void LineListToDGV(DataGridView dgv, List<Line> coefflist)
        {
            dgv.Rows.Clear();

            foreach (Line coefficient in coefflist)
            {
                dgv.Rows.Add();

                DataGridViewRow lastRow = dgv.Rows[dgv.RowCount - 1];
                lastRow.Cells["InputLineDGV_a"].Value = coefficient.A;
                lastRow.Cells["InputLineDGV_b"].Value = coefficient.B;
                lastRow.Cells["InputLineDGV_c"].Value = coefficient.C;



            }
        }
    }
}
