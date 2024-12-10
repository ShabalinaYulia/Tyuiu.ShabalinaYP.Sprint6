namespace Tyuiu.ShabalinaYP.Sprint6.Task7.V25
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
            textBoxAbout_SYP = new TextBox();
            pictureBoxAvatar_SYP = new PictureBox();
            buttonOK_SYP = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SYP).BeginInit();
            SuspendLayout();
            // 
            // textBoxAbout_SYP
            // 
            textBoxAbout_SYP.BackColor = SystemColors.ButtonFace;
            textBoxAbout_SYP.BorderStyle = BorderStyle.FixedSingle;
            textBoxAbout_SYP.Location = new Point(221, 45);
            textBoxAbout_SYP.Multiline = true;
            textBoxAbout_SYP.Name = "textBoxAbout_SYP";
            textBoxAbout_SYP.Size = new Size(300, 193);
            textBoxAbout_SYP.TabIndex = 5;
            textBoxAbout_SYP.Text = resources.GetString("textBoxAbout_SYP.Text");
            // 
            // pictureBoxAvatar_SYP
            // 
            pictureBoxAvatar_SYP.Image = (Image)resources.GetObject("pictureBoxAvatar_SYP.Image");
            pictureBoxAvatar_SYP.Location = new Point(12, 12);
            pictureBoxAvatar_SYP.Name = "pictureBoxAvatar_SYP";
            pictureBoxAvatar_SYP.Size = new Size(178, 253);
            pictureBoxAvatar_SYP.TabIndex = 4;
            pictureBoxAvatar_SYP.TabStop = false;
            // 
            // buttonOK_SYP
            // 
            buttonOK_SYP.FlatStyle = FlatStyle.System;
            buttonOK_SYP.Location = new Point(481, 279);
            buttonOK_SYP.Name = "buttonOK_SYP";
            buttonOK_SYP.Size = new Size(75, 23);
            buttonOK_SYP.TabIndex = 3;
            buttonOK_SYP.Text = "Ок";
            buttonOK_SYP.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 314);
            Controls.Add(textBoxAbout_SYP);
            Controls.Add(pictureBoxAvatar_SYP);
            Controls.Add(buttonOK_SYP);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SYP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAbout_SYP;
        private PictureBox pictureBoxAvatar_SYP;
        private Button buttonOK_SYP;
    }
}