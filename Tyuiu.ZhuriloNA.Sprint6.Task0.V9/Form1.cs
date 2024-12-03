using Tyuiu.ZhuriloNA.Sprint6.Task0.V9.Lib;
namespace Tyuiu.ZhuriloNA.Sprint6.Task0.V9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonPerform_ZNA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxConclusion_ZNA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInputX_ZNA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxInputX_ZNA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_ZNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил Журило Никита Александрович", "Сообщение", MessageBoxButtons.OK);
        }

    }
}
