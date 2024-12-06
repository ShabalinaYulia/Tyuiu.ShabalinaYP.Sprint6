using Tyuiu.ShabalinaYP.Sprint6.Task4.V1.Lib;
namespace Tyuiu.ShabalinaYP.Sprint6.Task4.V1
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
                this.chartFunction_SYP.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SYP.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxShowResult_SYP.Text = "";

                chartFunctionSpline_SYP.Series[0].Points.Clear();
                
                for (int i = 0; i < len; i++)
                {
                    this.chartFunctionSpline_SYP.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxShowResult_SYP.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверный данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент ПКТб-24-1 Шабалина Юлия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonSave_CLick(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V1");
                File.WriteAllText(path, textBoxShowResult_SYP.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранен успешно!\n Открыть его в блокноте?", "Сщщбщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
