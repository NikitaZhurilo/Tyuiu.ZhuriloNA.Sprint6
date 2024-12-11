using Tyuiu.ZhuriloNA.Sprint6.Task4.V11.Lib;
namespace Tyuiu.ZhuriloNA.Sprint6.Task4.V11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            int startStep = Convert.ToInt32(textBox2.Text);
            int stopStep = Convert.ToInt32(textBox3.Text);
            string strLine;
            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] array = new double[len];
            array = ds.GetMassFunction(startStep, stopStep);
            textBox1.Text = "";
            textBox1.AppendText("+------------+------------+" + Environment.NewLine);
            textBox1.AppendText("|      X     +     f(x)   +" + Environment.NewLine);
            textBox1.AppendText("+------------+------------+" + Environment.NewLine);
            for (int i = 0; i < len; i++)
            {
                strLine = String.Format("|{0,5:d}      |   {1, 5:f2}     |", startStep, array[i]);
                textBox1.AppendText(strLine + Environment.NewLine);
                startStep++;
            }
            textBox1.AppendText("+------------+------------+" + Environment.NewLine);
            this.chart1.Titles.Add("График функции");
            this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
            this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";
            for (int i = 0; i < len; i++)
            {

                this.chart1.Series[0].Points.AddXY(startStep, array[i]);
                startStep++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил Журило Никита Александрович", "Сообщение", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V11.txt";
            File.WriteAllText(path, textBox1.Text);
            DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно");
        }
    }
}
