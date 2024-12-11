using Tyuiu.ZhuriloNA.Sprint6.Task5.V24.Lib;
using System.IO;
namespace Tyuiu.ZhuriloNA.Sprint6.Task5.V24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\azhur\AppData\Local\Temp\InPutFileTask5V24.txt";


        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил Журило Никита Александрович", "Сообщение", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 50;

            this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
            this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";
            chart1.Series[0].Points.Clear();
            double[] numMass = new double[ds.len];
            numMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chart1.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
