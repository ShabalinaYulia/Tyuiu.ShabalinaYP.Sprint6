using Tyuiu.ShabalinaYP.Sprint6.Task1.V25.Lib;
namespace Tyuiu.ShabalinaYP.Sprint6.Task1.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int startStep = Convert.ToInt32(textBoxInPutStartStep_SYP.Text);
                int stopStep = Convert.ToInt32(textBoxInPutStopStep_SYP.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxShowResult_SYP.Text = "";
                textBoxShowResult_SYP.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxShowResult_SYP.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxShowResult_SYP.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1,6:f2}  |", startStep, valueArray[i]);
                    textBoxShowResult_SYP.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxShowResult_SYP.AppendText("+----------+----------+" + Environment.NewLine);
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
            MessageBox.Show("Таск 1 выполнил студент ПКТб-24-1 Шабалина Юлия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
