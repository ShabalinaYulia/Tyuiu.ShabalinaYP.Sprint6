namespace Tyuiu.ShabalinaYP.Sprint6.Task0.V28
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
            pictureBoxofFormula_SYP = new PictureBox();
            textBoxTask_SYP = new TextBox();
            groupBoxInPutVarX_SYP = new GroupBox();
            labelVarX_SYP = new Label();
            textBoxInPutVarX_SYP = new TextBox();
            groupBoxOutPutRes_SYP = new GroupBox();
            groupBoxResult_SYP = new GroupBox();
            textBoxResult_SYP = new TextBox();
            buttonHelp_SYP = new Button();
            buttonDoResult_SYP = new Button();
            groupBoxTask_SYP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxofFormula_SYP).BeginInit();
            groupBoxInPutVarX_SYP.SuspendLayout();
            groupBoxOutPutRes_SYP.SuspendLayout();
            groupBoxResult_SYP.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SYP
            // 
            groupBoxTask_SYP.Controls.Add(pictureBoxofFormula_SYP);
            groupBoxTask_SYP.Controls.Add(textBoxTask_SYP);
            groupBoxTask_SYP.Location = new Point(12, 29);
            groupBoxTask_SYP.Name = "groupBoxTask_SYP";
            groupBoxTask_SYP.Size = new Size(548, 162);
            groupBoxTask_SYP.TabIndex = 0;
            groupBoxTask_SYP.TabStop = false;
            groupBoxTask_SYP.Text = "Условие";
            // 
            // pictureBoxofFormula_SYP
            // 
            pictureBoxofFormula_SYP.Image = (Image)resources.GetObject("pictureBoxofFormula_SYP.Image");
            pictureBoxofFormula_SYP.Location = new Point(6, 106);
            pictureBoxofFormula_SYP.Name = "pictureBoxofFormula_SYP";
            pictureBoxofFormula_SYP.Size = new Size(315, 36);
            pictureBoxofFormula_SYP.TabIndex = 1;
            pictureBoxofFormula_SYP.TabStop = false;
            // 
            // textBoxTask_SYP
            // 
            textBoxTask_SYP.BackColor = SystemColors.Control;
            textBoxTask_SYP.BorderStyle = BorderStyle.None;
            textBoxTask_SYP.Location = new Point(6, 22);
            textBoxTask_SYP.Multiline = true;
            textBoxTask_SYP.Name = "textBoxTask_SYP";
            textBoxTask_SYP.ReadOnly = true;
            textBoxTask_SYP.Size = new Size(329, 78);
            textBoxTask_SYP.TabIndex = 1;
            textBoxTask_SYP.Text = "Вычислить значение выражения при x = 3.\r\nОкруглить значение до трех знаков после запятой\r\n";
            // 
            // groupBoxInPutVarX_SYP
            // 
            groupBoxInPutVarX_SYP.Controls.Add(labelVarX_SYP);
            groupBoxInPutVarX_SYP.Controls.Add(textBoxInPutVarX_SYP);
            groupBoxInPutVarX_SYP.Location = new Point(12, 197);
            groupBoxInPutVarX_SYP.Name = "groupBoxInPutVarX_SYP";
            groupBoxInPutVarX_SYP.Size = new Size(357, 128);
            groupBoxInPutVarX_SYP.TabIndex = 1;
            groupBoxInPutVarX_SYP.TabStop = false;
            groupBoxInPutVarX_SYP.Text = "Ввод данных";
            // 
            // labelVarX_SYP
            // 
            labelVarX_SYP.AutoSize = true;
            labelVarX_SYP.Location = new Point(111, 44);
            labelVarX_SYP.Name = "labelVarX_SYP";
            labelVarX_SYP.Size = new Size(89, 15);
            labelVarX_SYP.TabIndex = 2;
            labelVarX_SYP.Text = "Переменная X:";
            // 
            // textBoxInPutVarX_SYP
            // 
            textBoxInPutVarX_SYP.Location = new Point(98, 62);
            textBoxInPutVarX_SYP.Name = "textBoxInPutVarX_SYP";
            textBoxInPutVarX_SYP.Size = new Size(115, 23);
            textBoxInPutVarX_SYP.TabIndex = 1;
            textBoxInPutVarX_SYP.KeyPress += textBoxInPutVarX_KeyPress;
            // 
            // groupBoxOutPutRes_SYP
            // 
            groupBoxOutPutRes_SYP.Controls.Add(groupBoxResult_SYP);
            groupBoxOutPutRes_SYP.Location = new Point(375, 197);
            groupBoxOutPutRes_SYP.Name = "groupBoxOutPutRes_SYP";
            groupBoxOutPutRes_SYP.Size = new Size(185, 128);
            groupBoxOutPutRes_SYP.TabIndex = 2;
            groupBoxOutPutRes_SYP.TabStop = false;
            groupBoxOutPutRes_SYP.Text = "Вывод данных";
            // 
            // groupBoxResult_SYP
            // 
            groupBoxResult_SYP.Controls.Add(textBoxResult_SYP);
            groupBoxResult_SYP.Location = new Point(6, 40);
            groupBoxResult_SYP.Name = "groupBoxResult_SYP";
            groupBoxResult_SYP.Size = new Size(173, 60);
            groupBoxResult_SYP.TabIndex = 1;
            groupBoxResult_SYP.TabStop = false;
            groupBoxResult_SYP.Text = "Результат";
            // 
            // textBoxResult_SYP
            // 
            textBoxResult_SYP.Location = new Point(24, 22);
            textBoxResult_SYP.Name = "textBoxResult_SYP";
            textBoxResult_SYP.ReadOnly = true;
            textBoxResult_SYP.Size = new Size(100, 23);
            textBoxResult_SYP.TabIndex = 0;
            textBoxResult_SYP.TextChanged += buttonDone_CLick;
            // 
            // buttonHelp_SYP
            // 
            buttonHelp_SYP.FlatStyle = FlatStyle.Flat;
            buttonHelp_SYP.Location = new Point(440, 331);
            buttonHelp_SYP.Name = "buttonHelp_SYP";
            buttonHelp_SYP.Size = new Size(30, 23);
            buttonHelp_SYP.TabIndex = 3;
            buttonHelp_SYP.Text = "?";
            buttonHelp_SYP.UseVisualStyleBackColor = true;
            buttonHelp_SYP.Click += buttonHelp_Click;
            // 
            // buttonDoResult_SYP
            // 
            buttonDoResult_SYP.Location = new Point(479, 331);
            buttonDoResult_SYP.Name = "buttonDoResult_SYP";
            buttonDoResult_SYP.Size = new Size(81, 23);
            buttonDoResult_SYP.TabIndex = 4;
            buttonDoResult_SYP.Text = "Выполнить";
            buttonDoResult_SYP.UseVisualStyleBackColor = true;
            buttonDoResult_SYP.Click += buttonDone_CLick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 363);
            Controls.Add(buttonHelp_SYP);
            Controls.Add(buttonDoResult_SYP);
            Controls.Add(groupBoxOutPutRes_SYP);
            Controls.Add(groupBoxInPutVarX_SYP);
            Controls.Add(groupBoxTask_SYP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 18 | Шабалина Ю.П.";
            groupBoxTask_SYP.ResumeLayout(false);
            groupBoxTask_SYP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxofFormula_SYP).EndInit();
            groupBoxInPutVarX_SYP.ResumeLayout(false);
            groupBoxInPutVarX_SYP.PerformLayout();
            groupBoxOutPutRes_SYP.ResumeLayout(false);
            groupBoxResult_SYP.ResumeLayout(false);
            groupBoxResult_SYP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SYP;
        private TextBox textBoxTask_SYP;
        private PictureBox pictureBoxofFormula_SYP;
        private GroupBox groupBoxInPutVarX_SYP;
        private GroupBox groupBoxOutPutRes_SYP;
        private GroupBox groupBoxResult_SYP;
        private TextBox textBoxResult_SYP;
        private Button buttonHelp_SYP;
        private Button buttonDoResult_SYP;
        private Label labelVarX_SYP;
        private TextBox textBoxInPutVarX_SYP;
    }
}
