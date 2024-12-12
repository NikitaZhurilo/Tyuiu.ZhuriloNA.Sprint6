using Tyuiu.ZhuriloNA.Sprint6.Task6.V23.Lib;
namespace Tyuiu.ZhuriloNA.Sprint6.Task6.V23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath = @"C:\Users\azhur\AppData\Local\Temp\InPutFileTask6V23.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(openFilePath);
            groupBox1.Text = groupBox1.Text + " " + openFileDialog1.FileName;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "s";
            textBox2.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
