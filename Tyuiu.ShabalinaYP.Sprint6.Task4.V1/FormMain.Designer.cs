namespace Tyuiu.ShabalinaYP.Sprint6.Task4.V1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDoResult_SYP = new Button();
            groupBoxInPutVarStep = new GroupBox();
            labelStopStep_SYP = new Label();
            labelStartEnd_SYP = new Label();
            textBoxInPutStartStep_SYP = new TextBox();
            textBoxInPutStopStep_SYP = new TextBox();
            groupBoxResult_SYP = new GroupBox();
            labelOutPutResult_SYP = new Label();
            textBoxShowResult_SYP = new TextBox();
            buttonDoHelp_SYP = new Button();
            buttonToSaveFile_SYP = new Button();
            panelForOutPutData_SYP = new Panel();
            splitterSplineandOutPut_SYP = new Splitter();
            chartFunctionSpline_SYP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelForFunction_SYP = new Panel();
            groupBoxTask_SYP = new GroupBox();
            pictureBoxofFormula_SYP = new PictureBox();
            textBoxTask_SYP = new TextBox();
            panelInPutTask_SYP = new Panel();
            groupBoxInPutVarStep.SuspendLayout();
            groupBoxResult_SYP.SuspendLayout();
            panelForOutPutData_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunctionSpline_SYP).BeginInit();
            panelForFunction_SYP.SuspendLayout();
            groupBoxTask_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxofFormula_SYP).BeginInit();
            panelInPutTask_SYP.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDoResult_SYP
            // 
            buttonDoResult_SYP.BackColor = Color.Green;
            buttonDoResult_SYP.Location = new Point(524, 22);
            buttonDoResult_SYP.Name = "buttonDoResult_SYP";
            buttonDoResult_SYP.Size = new Size(84, 40);
            buttonDoResult_SYP.TabIndex = 5;
            buttonDoResult_SYP.Text = "Выполнить";
            buttonDoResult_SYP.UseVisualStyleBackColor = false;
            buttonDoResult_SYP.Click += buttonDone_Click;
            // 
            // groupBoxInPutVarStep
            // 
            groupBoxInPutVarStep.Controls.Add(labelStopStep_SYP);
            groupBoxInPutVarStep.Controls.Add(labelStartEnd_SYP);
            groupBoxInPutVarStep.Controls.Add(textBoxInPutStartStep_SYP);
            groupBoxInPutVarStep.Controls.Add(textBoxInPutStopStep_SYP);
            groupBoxInPutVarStep.Location = new Point(356, 3);
            groupBoxInPutVarStep.Name = "groupBoxInPutVarStep";
            groupBoxInPutVarStep.Size = new Size(162, 64);
            groupBoxInPutVarStep.TabIndex = 7;
            groupBoxInPutVarStep.TabStop = false;
            groupBoxInPutVarStep.Text = "Ввод данных";
            // 
            // labelStopStep_SYP
            // 
            labelStopStep_SYP.AutoSize = true;
            labelStopStep_SYP.Location = new Point(78, 19);
            labelStopStep_SYP.Name = "labelStopStep_SYP";
            labelStopStep_SYP.Size = new Size(75, 15);
            labelStopStep_SYP.TabIndex = 4;
            labelStopStep_SYP.Text = "Конец шага:";
            // 
            // labelStartEnd_SYP
            // 
            labelStartEnd_SYP.AutoSize = true;
            labelStartEnd_SYP.Location = new Point(0, 19);
            labelStartEnd_SYP.Name = "labelStartEnd_SYP";
            labelStartEnd_SYP.Size = new Size(72, 15);
            labelStartEnd_SYP.TabIndex = 3;
            labelStartEnd_SYP.Text = "Старт шага:";
            // 
            // textBoxInPutStartStep_SYP
            // 
            textBoxInPutStartStep_SYP.Location = new Point(6, 35);
            textBoxInPutStartStep_SYP.Name = "textBoxInPutStartStep_SYP";
            textBoxInPutStartStep_SYP.Size = new Size(65, 23);
            textBoxInPutStartStep_SYP.TabIndex = 2;
            // 
            // textBoxInPutStopStep_SYP
            // 
            textBoxInPutStopStep_SYP.Location = new Point(78, 35);
            textBoxInPutStopStep_SYP.Name = "textBoxInPutStopStep_SYP";
            textBoxInPutStopStep_SYP.Size = new Size(75, 23);
            textBoxInPutStopStep_SYP.TabIndex = 1;
            // 
            // groupBoxResult_SYP
            // 
            groupBoxResult_SYP.Controls.Add(labelOutPutResult_SYP);
            groupBoxResult_SYP.Controls.Add(textBoxShowResult_SYP);
            groupBoxResult_SYP.Dock = DockStyle.Fill;
            groupBoxResult_SYP.Location = new Point(0, 0);
            groupBoxResult_SYP.Name = "groupBoxResult_SYP";
            groupBoxResult_SYP.Size = new Size(212, 344);
            groupBoxResult_SYP.TabIndex = 8;
            groupBoxResult_SYP.TabStop = false;
            groupBoxResult_SYP.Text = "Вывод данных";
            // 
            // labelOutPutResult_SYP
            // 
            labelOutPutResult_SYP.AutoSize = true;
            labelOutPutResult_SYP.Location = new Point(6, 19);
            labelOutPutResult_SYP.Name = "labelOutPutResult_SYP";
            labelOutPutResult_SYP.Size = new Size(63, 15);
            labelOutPutResult_SYP.TabIndex = 1;
            labelOutPutResult_SYP.Text = "Результат:";
            // 
            // textBoxShowResult_SYP
            // 
            textBoxShowResult_SYP.Cursor = Cursors.IBeam;
            textBoxShowResult_SYP.Dock = DockStyle.Fill;
            textBoxShowResult_SYP.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxShowResult_SYP.Location = new Point(3, 19);
            textBoxShowResult_SYP.Multiline = true;
            textBoxShowResult_SYP.Name = "textBoxShowResult_SYP";
            textBoxShowResult_SYP.ReadOnly = true;
            textBoxShowResult_SYP.ScrollBars = ScrollBars.Vertical;
            textBoxShowResult_SYP.Size = new Size(206, 322);
            textBoxShowResult_SYP.TabIndex = 0;
            // 
            // buttonDoHelp_SYP
            // 
            buttonDoHelp_SYP.BackColor = Color.DodgerBlue;
            buttonDoHelp_SYP.Location = new Point(694, 22);
            buttonDoHelp_SYP.Name = "buttonDoHelp_SYP";
            buttonDoHelp_SYP.Size = new Size(74, 40);
            buttonDoHelp_SYP.TabIndex = 9;
            buttonDoHelp_SYP.Text = "Справка";
            buttonDoHelp_SYP.UseVisualStyleBackColor = false;
            buttonDoHelp_SYP.Click += buttonHelp_Click;
            // 
            // buttonToSaveFile_SYP
            // 
            buttonToSaveFile_SYP.BackColor = Color.SteelBlue;
            buttonToSaveFile_SYP.Location = new Point(614, 21);
            buttonToSaveFile_SYP.Name = "buttonToSaveFile_SYP";
            buttonToSaveFile_SYP.Size = new Size(74, 40);
            buttonToSaveFile_SYP.TabIndex = 10;
            buttonToSaveFile_SYP.Text = "Сохранить";
            buttonToSaveFile_SYP.UseVisualStyleBackColor = false;
            buttonToSaveFile_SYP.Click += buttonSave_CLick;
            // 
            // panelForOutPutData_SYP
            // 
            panelForOutPutData_SYP.Controls.Add(groupBoxResult_SYP);
            panelForOutPutData_SYP.Dock = DockStyle.Left;
            panelForOutPutData_SYP.Location = new Point(0, 106);
            panelForOutPutData_SYP.Name = "panelForOutPutData_SYP";
            panelForOutPutData_SYP.Size = new Size(212, 344);
            panelForOutPutData_SYP.TabIndex = 13;
            // 
            // splitterSplineandOutPut_SYP
            // 
            splitterSplineandOutPut_SYP.Location = new Point(212, 106);
            splitterSplineandOutPut_SYP.Name = "splitterSplineandOutPut_SYP";
            splitterSplineandOutPut_SYP.Size = new Size(3, 344);
            splitterSplineandOutPut_SYP.TabIndex = 14;
            splitterSplineandOutPut_SYP.TabStop = false;
            // 
            // chartFunctionSpline_SYP
            // 
            chartArea1.Name = "ChartArea1";
            chartFunctionSpline_SYP.ChartAreas.Add(chartArea1);
            chartFunctionSpline_SYP.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunctionSpline_SYP.Legends.Add(legend1);
            chartFunctionSpline_SYP.Location = new Point(0, 0);
            chartFunctionSpline_SYP.Name = "chartFunctionSpline_SYP";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunctionSpline_SYP.Series.Add(series1);
            chartFunctionSpline_SYP.Size = new Size(585, 344);
            chartFunctionSpline_SYP.TabIndex = 11;
            chartFunctionSpline_SYP.Text = "chartFunctionResult_SYP";
            title1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.Blue;
            title1.Name = "TitleChartRes_SYP";
            title1.Text = "График функции f(x)";
            chartFunctionSpline_SYP.Titles.Add(title1);
            // 
            // panelForFunction_SYP
            // 
            panelForFunction_SYP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForFunction_SYP.AutoSize = true;
            panelForFunction_SYP.Controls.Add(chartFunctionSpline_SYP);
            panelForFunction_SYP.Location = new Point(215, 106);
            panelForFunction_SYP.Name = "panelForFunction_SYP";
            panelForFunction_SYP.Size = new Size(585, 344);
            panelForFunction_SYP.TabIndex = 12;
            // 
            // groupBoxTask_SYP
            // 
            groupBoxTask_SYP.Controls.Add(pictureBoxofFormula_SYP);
            groupBoxTask_SYP.Controls.Add(textBoxTask_SYP);
            groupBoxTask_SYP.Location = new Point(12, 3);
            groupBoxTask_SYP.Name = "groupBoxTask_SYP";
            groupBoxTask_SYP.Size = new Size(338, 94);
            groupBoxTask_SYP.TabIndex = 6;
            groupBoxTask_SYP.TabStop = false;
            groupBoxTask_SYP.Text = "Условие";
            // 
            // pictureBoxofFormula_SYP
            // 
            pictureBoxofFormula_SYP.Image = (Image)resources.GetObject("pictureBoxofFormula_SYP.Image");
            pictureBoxofFormula_SYP.Location = new Point(6, 60);
            pictureBoxofFormula_SYP.Name = "pictureBoxofFormula_SYP";
            pictureBoxofFormula_SYP.Size = new Size(245, 28);
            pictureBoxofFormula_SYP.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxofFormula_SYP.TabIndex = 1;
            pictureBoxofFormula_SYP.TabStop = false;
            // 
            // textBoxTask_SYP
            // 
            textBoxTask_SYP.BackColor = SystemColors.Control;
            textBoxTask_SYP.BorderStyle = BorderStyle.None;
            textBoxTask_SYP.Location = new Point(0, 19);
            textBoxTask_SYP.Multiline = true;
            textBoxTask_SYP.Name = "textBoxTask_SYP";
            textBoxTask_SYP.ReadOnly = true;
            textBoxTask_SYP.Size = new Size(326, 78);
            textBoxTask_SYP.TabIndex = 1;
            textBoxTask_SYP.Text = "Написать программу, которая выводит таблицу значений функции: f(x) на диапазоне [-5; 5].";
            // 
            // panelInPutTask_SYP
            // 
            panelInPutTask_SYP.Controls.Add(groupBoxTask_SYP);
            panelInPutTask_SYP.Controls.Add(groupBoxInPutVarStep);
            panelInPutTask_SYP.Controls.Add(buttonDoHelp_SYP);
            panelInPutTask_SYP.Controls.Add(buttonToSaveFile_SYP);
            panelInPutTask_SYP.Controls.Add(buttonDoResult_SYP);
            panelInPutTask_SYP.Dock = DockStyle.Top;
            panelInPutTask_SYP.Location = new Point(0, 0);
            panelInPutTask_SYP.Name = "panelInPutTask_SYP";
            panelInPutTask_SYP.Size = new Size(800, 106);
            panelInPutTask_SYP.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitterSplineandOutPut_SYP);
            Controls.Add(panelForOutPutData_SYP);
            Controls.Add(panelInPutTask_SYP);
            Controls.Add(panelForFunction_SYP);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 1 | Шабалина Ю.П.";
            groupBoxInPutVarStep.ResumeLayout(false);
            groupBoxInPutVarStep.PerformLayout();
            groupBoxResult_SYP.ResumeLayout(false);
            groupBoxResult_SYP.PerformLayout();
            panelForOutPutData_SYP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunctionSpline_SYP).EndInit();
            panelForFunction_SYP.ResumeLayout(false);
            groupBoxTask_SYP.ResumeLayout(false);
            groupBoxTask_SYP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxofFormula_SYP).EndInit();
            panelInPutTask_SYP.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDoResult_SYP;
        private GroupBox groupBoxInPutVarStep;
        private Label labelStopStep_SYP;
        private Label labelStartEnd_SYP;
        private TextBox textBoxInPutStartStep_SYP;
        private TextBox textBoxInPutStopStep_SYP;
        private GroupBox groupBoxResult_SYP;
        private Label labelOutPutResult_SYP;
        private TextBox textBoxShowResult_SYP;
        private Button buttonDoHelp_SYP;
        private Button buttonToSaveFile_SYP;
        private Splitter splitterSplineandOutPut_SYP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctionSpline_SYP;        
        private GroupBox groupBoxTask_SYP;
        private PictureBox pictureBoxofFormula_SYP;
        private TextBox textBoxTask_SYP;
        private Panel panelInPutTask_SYP;
        private Panel panelForOutPutData_SYP;
        private Panel panelForFunction_SYP;


    }
}
