using Tyuiu.ShabalinaYP.Sprint6.Task0.V28.Lib;
namespace Tyuiu.ShabalinaYP.Sprint6.Task0.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_CLick(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_SYP.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInPutVarX_SYP.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxInPutVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент ПКТб-24-1 Шабалина Юлия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
