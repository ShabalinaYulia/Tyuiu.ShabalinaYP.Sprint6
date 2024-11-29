namespace Tyuiu.ShabalinaYP.Sprint6.Task1.V25
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
            groupBoxTask_SYP = new GroupBox();
            pictureBoxFunction_SYP = new PictureBox();
            labelTask_SYP = new Label();
            groupBoxInPutVarStep = new GroupBox();
            labelStopStep_SYP = new Label();
            labelStartEnd_SYP = new Label();
            textBoxInPutStartStep_SYP = new TextBox();
            textBoxInPutStopStep_SYP = new TextBox();
            buttonDoHelp_SYP = new Button();
            buttonDoResult_SYP = new Button();
            groupBoxResult_SYP = new GroupBox();
            labelOutPutResult_SYP = new Label();
            textBoxShowResult_SYP = new TextBox();
            groupBoxTask_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunction_SYP).BeginInit();
            groupBoxInPutVarStep.SuspendLayout();
            groupBoxResult_SYP.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SYP
            // 
            groupBoxTask_SYP.Controls.Add(pictureBoxFunction_SYP);
            groupBoxTask_SYP.Controls.Add(labelTask_SYP);
            groupBoxTask_SYP.Location = new Point(21, 23);
            groupBoxTask_SYP.Name = "groupBoxTask_SYP";
            groupBoxTask_SYP.Size = new Size(468, 211);
            groupBoxTask_SYP.TabIndex = 0;
            groupBoxTask_SYP.TabStop = false;
            groupBoxTask_SYP.Text = " Условие";
            // 
            // pictureBoxFunction_SYP
            // 
            pictureBoxFunction_SYP.Image = (Image)resources.GetObject("pictureBoxFunction_SYP.Image");
            pictureBoxFunction_SYP.Location = new Point(6, 41);
            pictureBoxFunction_SYP.Name = "pictureBoxFunction_SYP";
            pictureBoxFunction_SYP.Size = new Size(237, 39);
            pictureBoxFunction_SYP.TabIndex = 1;
            pictureBoxFunction_SYP.TabStop = false;
            // 
            // labelTask_SYP
            // 
            labelTask_SYP.AutoSize = true;
            labelTask_SYP.Location = new Point(6, 19);
            labelTask_SYP.Name = "labelTask_SYP";
            labelTask_SYP.Size = new Size(382, 105);
            labelTask_SYP.TabIndex = 0;
            labelTask_SYP.Text = resources.GetString("labelTask_SYP.Text");
            // 
            // groupBoxInPutVarStep
            // 
            groupBoxInPutVarStep.Controls.Add(labelStopStep_SYP);
            groupBoxInPutVarStep.Controls.Add(labelStartEnd_SYP);
            groupBoxInPutVarStep.Controls.Add(textBoxInPutStartStep_SYP);
            groupBoxInPutVarStep.Controls.Add(textBoxInPutStopStep_SYP);
            groupBoxInPutVarStep.Location = new Point(21, 240);
            groupBoxInPutVarStep.Name = "groupBoxInPutVarStep";
            groupBoxInPutVarStep.Size = new Size(243, 64);
            groupBoxInPutVarStep.TabIndex = 1;
            groupBoxInPutVarStep.TabStop = false;
            groupBoxInPutVarStep.Text = "Ввод данных";
            // 
            // labelStopStep_SYP
            // 
            labelStopStep_SYP.AutoSize = true;
            labelStopStep_SYP.Location = new Point(143, 19);
            labelStopStep_SYP.Name = "labelStopStep_SYP";
            labelStopStep_SYP.Size = new Size(75, 15);
            labelStopStep_SYP.TabIndex = 4;
            labelStopStep_SYP.Text = "Конец шага:";
            // 
            // labelStartEnd_SYP
            // 
            labelStartEnd_SYP.AutoSize = true;
            labelStartEnd_SYP.Location = new Point(24, 19);
            labelStartEnd_SYP.Name = "labelStartEnd_SYP";
            labelStartEnd_SYP.Size = new Size(72, 15);
            labelStartEnd_SYP.TabIndex = 3;
            labelStartEnd_SYP.Text = "Старт шага:";
            // 
            // textBoxInPutStartStep_SYP
            // 
            textBoxInPutStartStep_SYP.Location = new Point(6, 35);
            textBoxInPutStartStep_SYP.Name = "textBoxInPutStartStep_SYP";
            textBoxInPutStartStep_SYP.Size = new Size(110, 23);
            textBoxInPutStartStep_SYP.TabIndex = 2;
            textBoxInPutStartStep_SYP.KeyPress += textBoxInPutVarX_KeyPress;
            // 
            // textBoxInPutStopStep_SYP
            // 
            textBoxInPutStopStep_SYP.Location = new Point(127, 35);
            textBoxInPutStopStep_SYP.Name = "textBoxInPutStopStep_SYP";
            textBoxInPutStopStep_SYP.Size = new Size(110, 23);
            textBoxInPutStopStep_SYP.TabIndex = 1;
            textBoxInPutStopStep_SYP.KeyPress += textBoxInPutVarX_KeyPress;
            // 
            // buttonDoHelp_SYP
            // 
            buttonDoHelp_SYP.BackColor = Color.DodgerBlue;
            buttonDoHelp_SYP.Location = new Point(270, 247);
            buttonDoHelp_SYP.Name = "buttonDoHelp_SYP";
            buttonDoHelp_SYP.Size = new Size(95, 57);
            buttonDoHelp_SYP.TabIndex = 2;
            buttonDoHelp_SYP.Text = "Справка";
            buttonDoHelp_SYP.UseVisualStyleBackColor = false;
            buttonDoHelp_SYP.Click += buttonHelp_Click;
            // 
            // buttonDoResult_SYP
            // 
            buttonDoResult_SYP.BackColor = Color.Green;
            buttonDoResult_SYP.Location = new Point(371, 247);
            buttonDoResult_SYP.Name = "buttonDoResult_SYP";
            buttonDoResult_SYP.Size = new Size(118, 57);
            buttonDoResult_SYP.TabIndex = 3;
            buttonDoResult_SYP.Text = "Выполнить";
            buttonDoResult_SYP.UseVisualStyleBackColor = false;
            buttonDoResult_SYP.Click += buttonDone_Click;
            // 
            // groupBoxResult_SYP
            // 
            groupBoxResult_SYP.Controls.Add(labelOutPutResult_SYP);
            groupBoxResult_SYP.Controls.Add(textBoxShowResult_SYP);
            groupBoxResult_SYP.Location = new Point(506, 23);
            groupBoxResult_SYP.Name = "groupBoxResult_SYP";
            groupBoxResult_SYP.Size = new Size(200, 281);
            groupBoxResult_SYP.TabIndex = 4;
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
            textBoxShowResult_SYP.Size = new Size(200, 244);
            textBoxShowResult_SYP.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 316);
            Controls.Add(groupBoxResult_SYP);
            Controls.Add(buttonDoResult_SYP);
            Controls.Add(buttonDoHelp_SYP);
            Controls.Add(groupBoxInPutVarStep);
            Controls.Add(groupBoxTask_SYP);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 25 | Шабалина Ю.П.";
            groupBoxTask_SYP.ResumeLayout(false);
            groupBoxTask_SYP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunction_SYP).EndInit();
            groupBoxInPutVarStep.ResumeLayout(false);
            groupBoxInPutVarStep.PerformLayout();
            groupBoxResult_SYP.ResumeLayout(false);
            groupBoxResult_SYP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SYP;
        private Label labelTask_SYP;
        private PictureBox pictureBoxFunction_SYP;
        private GroupBox groupBoxInPutVarStep;
        private TextBox textBoxInPutStartStep_SYP;
        private TextBox textBoxInPutStopStep_SYP;
        private Label labelStartEnd_SYP;
        private Label labelStopStep_SYP;
        private Button buttonDoHelp_SYP;
        private Button buttonDoResult_SYP;
        private GroupBox groupBoxResult_SYP;
        private Label labelOutPutResult_SYP;
        private TextBox textBoxShowResult_SYP;
    }
}
