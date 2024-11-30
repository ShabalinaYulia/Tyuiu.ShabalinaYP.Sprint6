using Tyuiu.ShabalinaYP.Sprint6.Task2.V17.Lib;
namespace Tyuiu.ShabalinaYP.Sprint6.Task2.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInPutStartStep_SYP.Text);
                int stopStep = Convert.ToInt32(textBoxInPutStopStep_SYP.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_SYP.Titles.Add("График заданной функции F(x)");

                this.chartFunction_SYP.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SYP.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_SYP.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_SYP.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверный данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxInPutVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент ПКТб-24-1 Шабалина Юлия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDoResult_SYP.BackColor = Color.Red;           
        }
        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDoResult_SYP.BackColor = Color.Green;
        }
        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDoResult_SYP.BackColor = Color.Blue;
        }
    }
}
