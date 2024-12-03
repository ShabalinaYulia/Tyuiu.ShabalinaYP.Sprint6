namespace Tyuiu.ShabalinaYP.Sprint6.Task3.V26
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTask_SYP = new GroupBox();
            textBoxData_SYP = new TextBox();
            buttonDoHelp_SYP = new Button();
            dataGridViewMatrix_SYP = new DataGridView();
            buttonDoResult_SYP = new Button();
            groupBoxOutPutResult_SYP = new GroupBox();
            groupBoxTask_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_SYP).BeginInit();
            groupBoxOutPutResult_SYP.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SYP
            // 
            groupBoxTask_SYP.Controls.Add(textBoxData_SYP);
            groupBoxTask_SYP.Location = new Point(12, 23);
            groupBoxTask_SYP.Name = "groupBoxTask_SYP";
            groupBoxTask_SYP.Size = new Size(316, 270);
            groupBoxTask_SYP.TabIndex = 2;
            groupBoxTask_SYP.TabStop = false;
            groupBoxTask_SYP.Text = " Условие";
            // 
            // textBoxData_SYP
            // 
            textBoxData_SYP.BorderStyle = BorderStyle.None;
            textBoxData_SYP.Location = new Point(6, 22);
            textBoxData_SYP.Multiline = true;
            textBoxData_SYP.Name = "textBoxData_SYP";
            textBoxData_SYP.ReadOnly = true;
            textBoxData_SYP.Size = new Size(256, 144);
            textBoxData_SYP.TabIndex = 8;
            textBoxData_SYP.Text = "Дан массив 5 на 5 элементов. \r\n16   19   17   2    8\r\n -17   8  -17  -8   1\r\n  -7   17   -2    1  -3\r\n -12   0  -17   15   6\r\n  17  -6  -17  18 -19\t\r\nЗаменить четные значения в третьей строке на 0.\r\n";
            // 
            // buttonDoHelp_SYP
            // 
            buttonDoHelp_SYP.BackColor = SystemColors.ButtonFace;
            buttonDoHelp_SYP.Location = new Point(474, 301);
            buttonDoHelp_SYP.Name = "buttonDoHelp_SYP";
            buttonDoHelp_SYP.Size = new Size(26, 28);
            buttonDoHelp_SYP.TabIndex = 7;
            buttonDoHelp_SYP.Text = "?";
            buttonDoHelp_SYP.UseVisualStyleBackColor = false;
            buttonDoHelp_SYP.Click += buttonHelp_Click;
            // 
            // dataGridViewMatrix_SYP
            // 
            dataGridViewMatrix_SYP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_SYP.ColumnHeadersVisible = false;
            dataGridViewMatrix_SYP.Location = new Point(14, 22);
            dataGridViewMatrix_SYP.Name = "dataGridViewMatrix_SYP";
            dataGridViewMatrix_SYP.RowHeadersVisible = false;
            dataGridViewMatrix_SYP.Size = new Size(152, 144);
            dataGridViewMatrix_SYP.TabIndex = 3;
            // 
            // buttonDoResult_SYP
            // 
            buttonDoResult_SYP.BackColor = SystemColors.ButtonFace;
            buttonDoResult_SYP.Location = new Point(506, 301);
            buttonDoResult_SYP.Name = "buttonDoResult_SYP";
            buttonDoResult_SYP.Size = new Size(86, 28);
            buttonDoResult_SYP.TabIndex = 5;
            buttonDoResult_SYP.Text = "Выполнить";
            buttonDoResult_SYP.UseVisualStyleBackColor = false;
            buttonDoResult_SYP.Click += FormMain_Load;
            // 
            // groupBoxOutPutResult_SYP
            // 
            groupBoxOutPutResult_SYP.Controls.Add(dataGridViewMatrix_SYP);
            groupBoxOutPutResult_SYP.Location = new Point(334, 23);
            groupBoxOutPutResult_SYP.Name = "groupBoxOutPutResult_SYP";
            groupBoxOutPutResult_SYP.Size = new Size(258, 270);
            groupBoxOutPutResult_SYP.TabIndex = 8;
            groupBoxOutPutResult_SYP.TabStop = false;
            groupBoxOutPutResult_SYP.Text = "Вывод результата";
            // 
            // FormMain
            // 
            ClientSize = new Size(625, 341);
            Controls.Add(groupBoxOutPutResult_SYP);
            Controls.Add(buttonDoResult_SYP);
            Controls.Add(buttonDoHelp_SYP);
            Controls.Add(groupBoxTask_SYP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 26 | Шабалина Ю.П.";
            groupBoxTask_SYP.ResumeLayout(false);
            groupBoxTask_SYP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_SYP).EndInit();
            groupBoxOutPutResult_SYP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SYP;
        private DataGridView dataGridViewMatrix_SYP;
        private Button buttonDoResult_SYP;
        private TextBox textBoxData_SYP;
        private Button buttonDoHelp_SYP;
        private GroupBox groupBoxOutPutResult_SYP;
    }
}
