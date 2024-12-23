using Tyuiu.ZhuriloNA.Sprint6.Task1.V11.Lib;
namespace Tyuiu.ZhuriloNA.Sprint6.Task1.V11
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
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] array = new double[len];
                array = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_ZNA.Text = "";
                textBoxResult_ZNA.AppendText("+------------+------------+" + Environment.NewLine);
                textBoxResult_ZNA.AppendText("|      X     +     f(x)   +" + Environment.NewLine);
                textBoxResult_ZNA.AppendText("+------------+------------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}      |   {1, 5:f2}     |", startStep, array[i]);
                    textBoxResult_ZNA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_ZNA.AppendText("+------------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonReference_ZNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 1 �������� ������ ������ �������������", "���������", MessageBoxButtons.OK);
        }

        
    }
}
