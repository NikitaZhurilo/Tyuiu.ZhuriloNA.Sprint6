using Tyuiu.ZhuriloNA.Sprint6.Task3.V17.Lib;
namespace Tyuiu.ZhuriloNA.Sprint6.Task3.V17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = {
            { 22, 32, -16, 24, 27},
            { 3, -20, 24, -20, 25},
            { 21, 17, -8, -19, 17 },
            { 8, 22, 28, 27, 19 },
            { 11, 20, 12, 27, 29 } };
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил Журило Никита Александрович", "Сообщение", MessageBoxButtons.OK);
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView1.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(ds.Calculate(matrix)[i, j]);
                }
            }
        }
    }
}
