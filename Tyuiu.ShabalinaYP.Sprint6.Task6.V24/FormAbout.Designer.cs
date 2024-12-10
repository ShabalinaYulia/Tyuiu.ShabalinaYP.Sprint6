namespace Tyuiu.ShabalinaYP.Sprint6.Task6.V24
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonOK_SYP = new Button();
            pictureBoxAvatar_SYP = new PictureBox();
            textBoxAbout_SYP = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SYP).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_SYP
            // 
            buttonOK_SYP.FlatStyle = FlatStyle.System;
            buttonOK_SYP.Location = new Point(424, 235);
            buttonOK_SYP.Name = "buttonOK_SYP";
            buttonOK_SYP.Size = new Size(75, 23);
            buttonOK_SYP.TabIndex = 0;
            buttonOK_SYP.Text = "Ок";
            buttonOK_SYP.UseVisualStyleBackColor = true;
            buttonOK_SYP.Click += buttonOK_Click;
            // 
            // pictureBoxAvatar_SYP
            // 
            pictureBoxAvatar_SYP.Image = (Image)resources.GetObject("pictureBoxAvatar_SYP.Image");
            pictureBoxAvatar_SYP.Location = new Point(22, 12);
            pictureBoxAvatar_SYP.Name = "pictureBoxAvatar_SYP";
            pictureBoxAvatar_SYP.Size = new Size(178, 253);
            pictureBoxAvatar_SYP.TabIndex = 1;
            pictureBoxAvatar_SYP.TabStop = false;
            // 
            // textBoxAbout_SYP
            // 
            textBoxAbout_SYP.BackColor = SystemColors.ButtonFace;
            textBoxAbout_SYP.BorderStyle = BorderStyle.FixedSingle;
            textBoxAbout_SYP.Location = new Point(220, 27);
            textBoxAbout_SYP.Multiline = true;
            textBoxAbout_SYP.Name = "textBoxAbout_SYP";
            textBoxAbout_SYP.Size = new Size(300, 193);
            textBoxAbout_SYP.TabIndex = 2;
            textBoxAbout_SYP.Text = resources.GetString("textBoxAbout_SYP.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 281);
            Controls.Add(textBoxAbout_SYP);
            Controls.Add(pictureBoxAvatar_SYP);
            Controls.Add(buttonOK_SYP);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SYP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK_SYP;
        private PictureBox pictureBoxAvatar_SYP;
        private TextBox textBoxAbout_SYP;
    }
}