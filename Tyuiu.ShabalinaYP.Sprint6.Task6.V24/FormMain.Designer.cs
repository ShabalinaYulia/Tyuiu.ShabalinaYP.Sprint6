namespace Tyuiu.ShabalinaYP.Sprint6.Task6.V24
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelForButtons_SYP = new Panel();
            buttonHelp_SYP = new Button();
            buttonDone_SYP = new Button();
            buttonOpenFile_SYP = new Button();
            groupBoxTask_SYP = new GroupBox();
            textBoxTask_SYP = new TextBox();
            panelOutputFile_SYP = new Panel();
            groupBoxOutPutFile_SYP = new GroupBox();
            textBoxOutPut_SYP = new TextBox();
            panelForInPutFile = new Panel();
            groupBoxInPutFile_SYP = new GroupBox();
            textBoxInPutData_SYP = new TextBox();
            splitterForInOutPut_SYP = new Splitter();
            toolTip = new ToolTip(components);
            openFileDialogTask_SYP = new OpenFileDialog();
            panelForButtons_SYP.SuspendLayout();
            groupBoxTask_SYP.SuspendLayout();
            panelOutputFile_SYP.SuspendLayout();
            groupBoxOutPutFile_SYP.SuspendLayout();
            panelForInPutFile.SuspendLayout();
            groupBoxInPutFile_SYP.SuspendLayout();
            SuspendLayout();
            // 
            // panelForButtons_SYP
            // 
            panelForButtons_SYP.Controls.Add(buttonHelp_SYP);
            panelForButtons_SYP.Controls.Add(buttonDone_SYP);
            panelForButtons_SYP.Controls.Add(buttonOpenFile_SYP);
            panelForButtons_SYP.Controls.Add(groupBoxTask_SYP);
            panelForButtons_SYP.Dock = DockStyle.Top;
            panelForButtons_SYP.Location = new Point(0, 0);
            panelForButtons_SYP.Name = "panelForButtons_SYP";
            panelForButtons_SYP.Size = new Size(906, 154);
            panelForButtons_SYP.TabIndex = 0;
            // 
            // buttonHelp_SYP
            // 
            buttonHelp_SYP.BackColor = SystemColors.ButtonFace;
            buttonHelp_SYP.Dock = DockStyle.Right;
            buttonHelp_SYP.FlatAppearance.BorderColor = Color.Silver;
            buttonHelp_SYP.Image = (Image)resources.GetObject("buttonHelp_SYP.Image");
            buttonHelp_SYP.Location = new Point(841, 0);
            buttonHelp_SYP.Name = "buttonHelp_SYP";
            buttonHelp_SYP.Size = new Size(65, 78);
            buttonHelp_SYP.TabIndex = 4;
            toolTip.SetToolTip(buttonHelp_SYP, "Открыть справку\r\n");
            buttonHelp_SYP.UseVisualStyleBackColor = false;
            buttonHelp_SYP.Click += buttonHelp_Click;
            // 
            // buttonDone_SYP
            // 
            buttonDone_SYP.BackColor = SystemColors.ButtonFace;
            buttonDone_SYP.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDone_SYP.Enabled = false;
            buttonDone_SYP.FlatAppearance.BorderColor = Color.Silver;
            buttonDone_SYP.FlatAppearance.MouseDownBackColor = Color.Silver;
            buttonDone_SYP.FlatStyle = FlatStyle.Flat;
            buttonDone_SYP.Image = (Image)resources.GetObject("buttonDone_SYP.Image");
            buttonDone_SYP.Location = new Point(96, 7);
            buttonDone_SYP.Name = "buttonDone_SYP";
            buttonDone_SYP.Size = new Size(59, 62);
            buttonDone_SYP.TabIndex = 3;
            toolTip.SetToolTip(buttonDone_SYP, "Выводит первое слово каждой строки в результирующею строку и выводит \r\n ее в textBoxOut.");
            buttonDone_SYP.UseVisualStyleBackColor = false;
            buttonDone_SYP.Click += buttonDone_Click;
            // 
            // buttonOpenFile_SYP
            // 
            buttonOpenFile_SYP.BackColor = SystemColors.ButtonFace;
            buttonOpenFile_SYP.FlatAppearance.BorderColor = Color.Silver;
            buttonOpenFile_SYP.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_SYP.Image = (Image)resources.GetObject("buttonOpenFile_SYP.Image");
            buttonOpenFile_SYP.Location = new Point(12, 7);
            buttonOpenFile_SYP.Name = "buttonOpenFile_SYP";
            buttonOpenFile_SYP.Size = new Size(63, 62);
            buttonOpenFile_SYP.TabIndex = 2;
            toolTip.SetToolTip(buttonOpenFile_SYP, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_SYP.UseVisualStyleBackColor = false;
            buttonOpenFile_SYP.Click += buttonOpenFile_Click;
            // 
            // groupBoxTask_SYP
            // 
            groupBoxTask_SYP.Controls.Add(textBoxTask_SYP);
            groupBoxTask_SYP.Dock = DockStyle.Bottom;
            groupBoxTask_SYP.Location = new Point(0, 78);
            groupBoxTask_SYP.Name = "groupBoxTask_SYP";
            groupBoxTask_SYP.Size = new Size(906, 76);
            groupBoxTask_SYP.TabIndex = 0;
            groupBoxTask_SYP.TabStop = false;
            groupBoxTask_SYP.Text = "Условие";
            // 
            // textBoxTask_SYP
            // 
            textBoxTask_SYP.BackColor = SystemColors.Menu;
            textBoxTask_SYP.Dock = DockStyle.Fill;
            textBoxTask_SYP.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_SYP.Location = new Point(3, 19);
            textBoxTask_SYP.Multiline = true;
            textBoxTask_SYP.Name = "textBoxTask_SYP";
            textBoxTask_SYP.ReadOnly = true;
            textBoxTask_SYP.ShortcutsEnabled = false;
            textBoxTask_SYP.Size = new Size(900, 54);
            textBoxTask_SYP.TabIndex = 0;
            textBoxTask_SYP.TabStop = false;
            textBoxTask_SYP.Text = resources.GetString("textBoxTask_SYP.Text");
            // 
            // panelOutputFile_SYP
            // 
            panelOutputFile_SYP.Controls.Add(groupBoxOutPutFile_SYP);
            panelOutputFile_SYP.Dock = DockStyle.Fill;
            panelOutputFile_SYP.Location = new Point(382, 154);
            panelOutputFile_SYP.Name = "panelOutputFile_SYP";
            panelOutputFile_SYP.Size = new Size(524, 377);
            panelOutputFile_SYP.TabIndex = 1;
            // 
            // groupBoxOutPutFile_SYP
            // 
            groupBoxOutPutFile_SYP.Controls.Add(textBoxOutPut_SYP);
            groupBoxOutPutFile_SYP.Dock = DockStyle.Fill;
            groupBoxOutPutFile_SYP.Location = new Point(0, 0);
            groupBoxOutPutFile_SYP.Name = "groupBoxOutPutFile_SYP";
            groupBoxOutPutFile_SYP.Size = new Size(524, 377);
            groupBoxOutPutFile_SYP.TabIndex = 0;
            groupBoxOutPutFile_SYP.TabStop = false;
            groupBoxOutPutFile_SYP.Text = "Вывод";
            // 
            // textBoxOutPut_SYP
            // 
            textBoxOutPut_SYP.Dock = DockStyle.Fill;
            textBoxOutPut_SYP.Location = new Point(3, 19);
            textBoxOutPut_SYP.Multiline = true;
            textBoxOutPut_SYP.Name = "textBoxOutPut_SYP";
            textBoxOutPut_SYP.ReadOnly = true;
            textBoxOutPut_SYP.ScrollBars = ScrollBars.Vertical;
            textBoxOutPut_SYP.Size = new Size(518, 355);
            textBoxOutPut_SYP.TabIndex = 1;
            // 
            // panelForInPutFile
            // 
            panelForInPutFile.Controls.Add(groupBoxInPutFile_SYP);
            panelForInPutFile.Dock = DockStyle.Left;
            panelForInPutFile.Location = new Point(0, 154);
            panelForInPutFile.Name = "panelForInPutFile";
            panelForInPutFile.Size = new Size(382, 377);
            panelForInPutFile.TabIndex = 1;
            // 
            // groupBoxInPutFile_SYP
            // 
            groupBoxInPutFile_SYP.Controls.Add(textBoxInPutData_SYP);
            groupBoxInPutFile_SYP.Dock = DockStyle.Fill;
            groupBoxInPutFile_SYP.Location = new Point(0, 0);
            groupBoxInPutFile_SYP.Name = "groupBoxInPutFile_SYP";
            groupBoxInPutFile_SYP.Size = new Size(382, 377);
            groupBoxInPutFile_SYP.TabIndex = 0;
            groupBoxInPutFile_SYP.TabStop = false;
            groupBoxInPutFile_SYP.Text = "Ввод";
            // 
            // textBoxInPutData_SYP
            // 
            textBoxInPutData_SYP.Dock = DockStyle.Fill;
            textBoxInPutData_SYP.Location = new Point(3, 19);
            textBoxInPutData_SYP.Multiline = true;
            textBoxInPutData_SYP.Name = "textBoxInPutData_SYP";
            textBoxInPutData_SYP.ReadOnly = true;
            textBoxInPutData_SYP.ScrollBars = ScrollBars.Vertical;
            textBoxInPutData_SYP.Size = new Size(376, 355);
            textBoxInPutData_SYP.TabIndex = 0;
            // 
            // splitterForInOutPut_SYP
            // 
            splitterForInOutPut_SYP.Location = new Point(382, 154);
            splitterForInOutPut_SYP.Name = "splitterForInOutPut_SYP";
            splitterForInOutPut_SYP.Size = new Size(3, 377);
            splitterForInOutPut_SYP.TabIndex = 2;
            splitterForInOutPut_SYP.TabStop = false;
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 531);
            Controls.Add(splitterForInOutPut_SYP);
            Controls.Add(panelOutputFile_SYP);
            Controls.Add(panelForInPutFile);
            Controls.Add(panelForButtons_SYP);
            MinimumSize = new Size(922, 570);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 24 | Шабалина Ю.П. ";
            panelForButtons_SYP.ResumeLayout(false);
            groupBoxTask_SYP.ResumeLayout(false);
            groupBoxTask_SYP.PerformLayout();
            panelOutputFile_SYP.ResumeLayout(false);
            groupBoxOutPutFile_SYP.ResumeLayout(false);
            groupBoxOutPutFile_SYP.PerformLayout();
            panelForInPutFile.ResumeLayout(false);
            groupBoxInPutFile_SYP.ResumeLayout(false);
            groupBoxInPutFile_SYP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForButtons_SYP;
        private Panel panelOutputFile_SYP;
        private Panel panelForInPutFile;
        private Button buttonOpenFile_SYP;
        private GroupBox groupBoxTask_SYP;
        private GroupBox groupBoxOutPutFile_SYP;
        private GroupBox groupBoxInPutFile_SYP;
        private TextBox textBoxOutPut_SYP;
        private TextBox textBoxInPutData_SYP;
        private Splitter splitterForInOutPut_SYP;
        private TextBox textBoxTask_SYP;
        private ToolTip toolTip;
        private Button buttonHelp_SYP;
        private Button buttonDone_SYP;
        private OpenFileDialog openFileDialogTask_SYP;
    }
}
