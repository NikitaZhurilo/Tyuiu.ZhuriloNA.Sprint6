using Tyuiu.ZhuriloNA.Sprint6.Task2.V11.Lib;
namespace Tyuiu.ZhuriloNA.Sprint6.Task2.V11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonPerform_ZNA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputStart_ZNA.Text);
                int stopStep = Convert.ToInt32(textBoxInputEnd_ZNA.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] array = new double[len];
                array = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_ZNA.Titles.Add("График функции");
                this.chartFunction_ZNA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_ZNA.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_ZNA.Rows.Add(Convert.ToString(startStep), Convert.ToString(array[i]));
                    this.chartFunction_ZNA.Series[0].Points.AddXY(startStep, array[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPerform_ZNA_MouseEnter(object sender, EventArgs e)
        {
            buttonPerform_ZNA.BackColor = Color.Gold;
        }

        private void buttonReference_ZNA_MouseEnter(object sender, EventArgs e)
        {
            buttonReference_ZNA.BackColor = Color.Chartreuse;
        }

        private void buttonPerform_ZNA_MouseLeave(object sender, EventArgs e)
        {
            buttonPerform_ZNA.BackColor = Color.Green;
        }

        private void buttonPerform_ZNA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPerform_ZNA.BackColor = Color.Purple;
        }

        private void buttonReference_ZNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил Журило Никита Александрович", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
