using Tyuiu.ShabalinaYP.Sprint6.Task3.V26.Lib;
namespace Tyuiu.ShabalinaYP.Sprint6.Task3.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] matrix = new int[,] { {16, 19, 17, 2, 8},
                                     {-17, 8, -17, -8, 1},
                                     {-7, 17, -2, 1, -3},
                                     {-12, 0, -17, 15, 6},
                                     {17, -6, -17, 18, -19} };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            matrix = ds.Calculate(matrix);
            dataGridViewMatrix_SYP.ColumnCount = columns;
            dataGridViewMatrix_SYP.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SYP.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SYP.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент ПКТб-24-1 Шабалина Юлия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
