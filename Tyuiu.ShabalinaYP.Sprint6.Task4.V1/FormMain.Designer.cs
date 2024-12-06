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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            buttonDoResult_SYP = new Button();
            groupBoxTask_SYP = new GroupBox();
            pictureBoxofFormula_SYP = new PictureBox();
            textBoxTask_SYP = new TextBox();
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
            chartFunction_SYP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxofFormula_SYP).BeginInit();
            groupBoxInPutVarStep.SuspendLayout();
            groupBoxResult_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SYP).BeginInit();
            SuspendLayout();
            // 
            // buttonDoResult_SYP
            // 
            buttonDoResult_SYP.BackColor = Color.Green;
            buttonDoResult_SYP.Location = new Point(524, 31);
            buttonDoResult_SYP.Name = "buttonDoResult_SYP";
            buttonDoResult_SYP.Size = new Size(84, 40);
            buttonDoResult_SYP.TabIndex = 5;
            buttonDoResult_SYP.Text = "Выполнить";
            buttonDoResult_SYP.UseVisualStyleBackColor = false;
            buttonDoResult_SYP.Click += buttonDone_Click;
            // 
            // groupBoxTask_SYP
            // 
            groupBoxTask_SYP.Controls.Add(pictureBoxofFormula_SYP);
            groupBoxTask_SYP.Controls.Add(textBoxTask_SYP);
            groupBoxTask_SYP.Location = new Point(12, 12);
            groupBoxTask_SYP.Name = "groupBoxTask_SYP";
            groupBoxTask_SYP.Size = new Size(338, 100);
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
            textBoxTask_SYP.Location = new Point(0, 22);
            textBoxTask_SYP.Multiline = true;
            textBoxTask_SYP.Name = "textBoxTask_SYP";
            textBoxTask_SYP.ReadOnly = true;
            textBoxTask_SYP.Size = new Size(326, 78);
            textBoxTask_SYP.TabIndex = 1;
            textBoxTask_SYP.Text = "Написать программу, которая выводит таблицу значений функции: f(x) на диапазоне [-5; 5].";
            // 
            // groupBoxInPutVarStep
            // 
            groupBoxInPutVarStep.Controls.Add(labelStopStep_SYP);
            groupBoxInPutVarStep.Controls.Add(labelStartEnd_SYP);
            groupBoxInPutVarStep.Controls.Add(textBoxInPutStartStep_SYP);
            groupBoxInPutVarStep.Controls.Add(textBoxInPutStopStep_SYP);
            groupBoxInPutVarStep.Location = new Point(356, 12);
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
            groupBoxResult_SYP.Location = new Point(12, 118);
            groupBoxResult_SYP.Name = "groupBoxResult_SYP";
            groupBoxResult_SYP.Size = new Size(200, 320);
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
            textBoxShowResult_SYP.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxShowResult_SYP.Location = new Point(0, 37);
            textBoxShowResult_SYP.Multiline = true;
            textBoxShowResult_SYP.Name = "textBoxShowResult_SYP";
            textBoxShowResult_SYP.ReadOnly = true;
            textBoxShowResult_SYP.ScrollBars = ScrollBars.Vertical;
            textBoxShowResult_SYP.Size = new Size(200, 283);
            textBoxShowResult_SYP.TabIndex = 0;
            // 
            // buttonDoHelp_SYP
            // 
            buttonDoHelp_SYP.BackColor = Color.DodgerBlue;
            buttonDoHelp_SYP.Location = new Point(691, 30);
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
            buttonToSaveFile_SYP.Location = new Point(611, 31);
            buttonToSaveFile_SYP.Name = "buttonToSaveFile_SYP";
            buttonToSaveFile_SYP.Size = new Size(74, 40);
            buttonToSaveFile_SYP.TabIndex = 10;
            buttonToSaveFile_SYP.Text = "Сохранить";
            buttonToSaveFile_SYP.UseVisualStyleBackColor = false;
            buttonToSaveFile_SYP.Click += buttonSave_CLick;
            // 
            // chartFunction_SYP
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_SYP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_SYP.Legends.Add(legend1);
            chartFunction_SYP.Location = new Point(218, 118);
            chartFunction_SYP.Name = "chartFunction_SYP";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_SYP.Series.Add(series1);
            chartFunction_SYP.Size = new Size(585, 335);
            chartFunction_SYP.TabIndex = 11;
            chartFunction_SYP.Text = "chartFunctionResult_SYP";
            title1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.Blue;
            title1.Name = "TitleChartRes_SYP";
            title1.Text = "График функции f(x)";
            chartFunction_SYP.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartFunction_SYP);
            Controls.Add(buttonToSaveFile_SYP);
            Controls.Add(buttonDoHelp_SYP);
            Controls.Add(groupBoxResult_SYP);
            Controls.Add(groupBoxInPutVarStep);
            Controls.Add(groupBoxTask_SYP);
            Controls.Add(buttonDoResult_SYP);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 1 | Шабалина Ю.П.";
            groupBoxTask_SYP.ResumeLayout(false);
            groupBoxTask_SYP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxofFormula_SYP).EndInit();
            groupBoxInPutVarStep.ResumeLayout(false);
            groupBoxInPutVarStep.PerformLayout();
            groupBoxResult_SYP.ResumeLayout(false);
            groupBoxResult_SYP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SYP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDoResult_SYP;
        private GroupBox groupBoxTask_SYP;
        private PictureBox pictureBoxofFormula_SYP;
        private TextBox textBoxTask_SYP;
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
