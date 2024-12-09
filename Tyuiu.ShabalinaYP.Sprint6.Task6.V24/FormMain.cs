using Tyuiu.ShabalinaYP.Sprint6.Task6.V24.Lib;
namespace Tyuiu.ShabalinaYP.Sprint6.Task6.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOutPut_SYP.Text = Convert.ToString(ds.CollectTextFromFile(openFilePath));
            
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SYP.ShowDialog();
            openFilePath = openFileDialogTask_SYP.FileName;
            using (StreamReader sr = new StreamReader(openFilePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    textBoxInPutData_SYP.Text += line + Environment.NewLine;                    
                }
            }
            groupBoxOutPutFile_SYP.Text = groupBoxOutPutFile_SYP.Text + " " + openFileDialogTask_SYP.FileName; ;
            buttonDone_SYP.Enabled = true;
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
       
    }
}
