using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilsF;
using ProgramLogic;

namespace _10._1._1F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(InputLineDGV, 40, false, true, true, true, false);
        }

        private void resultbutton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Line> lines = LineDGVConvert.DGVToLineList(InputLineDGV);

                ClassList line = new ClassList(lines);
                List<int> newlist = line.Result();

                OutputListlabel.Text = ClassConvert.ListToStr(newlist, " ");
            }
            catch (Exception ex)
            {
                MessagesUtils.ShowError("Произошла ошибка!");
            }
        }

        private void MainMenuFileOpen_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = OpenFileDialog.FileName;

                    List<Line> lineList = LineFilesUtils.ReadLineListFromFile(path);
                    LineDGVConvert.LineListToDGV(InputLineDGV, lineList);

                    MessagesUtils.ShowMessage("Данные загружены из файла");
                }
                catch (Exception ex)
                {
                    MessagesUtils.ShowError("Ошибка чтения из файла");
                }
            }
        }

        private void MainMenuFileSave_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = SaveFileDialog.FileName;

                    List<Line> studentsList = LineDGVConvert.DGVToLineList(InputLineDGV);
                    LineFilesUtils.SaveLineListInFile(path, studentsList);

                    MessagesUtils.ShowMessage("Данные сохранены в файл");
                }
                catch (Exception ex)
                {
                    MessagesUtils.ShowError("Ошибка сохранения в файл");
                }
            }
        }
    }
}
