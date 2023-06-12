namespace ZaverecnaPraceMain
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            monitorImage = new PictureBox();
            passwordBox = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)monitorImage).BeginInit();
            SuspendLayout();
            // 
            // monitorImage
            // 
            monitorImage.BackgroundImage = (Image)resources.GetObject("monitorImage.BackgroundImage");
            monitorImage.Location = new Point(12, -34);
            monitorImage.Name = "monitorImage";
            monitorImage.Size = new Size(885, 597);
            monitorImage.TabIndex = 0;
            monitorImage.TabStop = false;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(409, 468);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(100, 23);
            passwordBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(515, 462);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 2;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 559);
            Controls.Add(button1);
            Controls.Add(passwordBox);
            Controls.Add(monitorImage);
            Name = "BaseForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)monitorImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox monitorImage;
        private TextBox passwordBox;
        private Button button1;
    }
}