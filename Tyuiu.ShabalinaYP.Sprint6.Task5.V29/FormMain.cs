using Tyuiu.ShabalinaYP.Sprint6.Task5.V29.Lib;
namespace Tyuiu.ShabalinaYP.Sprint6.Task5.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\User\source\repos\Tyuiu.ShabalinaYP.Sprint6\Tyuiu.ShabalinaYP.Sprint6.Task5.V29\InPutDataFileTask5V29.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewRes_SYP.ColumnCount = 2;
            dataGridViewRes_SYP.Columns[0].Width = 20;
            dataGridViewRes_SYP.Columns[1].Width = 50;

            this.chartDiagRes_SYP.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiagRes_SYP.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiagRes_SYP.Series[0].Points.Clear();

            double[] numsArray = new double[ds.len];

            numsArray = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsArray.Length; i++)
            {
                dataGridViewRes_SYP.Rows.Add(Convert.ToString(i), Convert.ToString(numsArray[i]));
                chartDiagRes_SYP.Series[0].Points.AddXY(i, numsArray[i]);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент ПКТб-24-1 Шабалина Юлия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
