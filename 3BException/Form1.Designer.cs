namespace _3BException
{
    partial class Form1
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
            btnException = new Button();
            btnCustomException = new Button();
            SuspendLayout();
            // 
            // btnException
            // 
            btnException.Location = new Point(12, 12);
            btnException.Name = "btnException";
            btnException.Size = new Size(132, 40);
            btnException.TabIndex = 0;
            btnException.Text = "Exception";
            btnException.UseVisualStyleBackColor = true;
            btnException.Click += btnException_Click;
            // 
            // btnCustomException
            // 
            btnCustomException.Location = new Point(170, 13);
            btnCustomException.Name = "btnCustomException";
            btnCustomException.Size = new Size(132, 40);
            btnCustomException.TabIndex = 1;
            btnCustomException.Text = "Custom Exception";
            btnCustomException.UseVisualStyleBackColor = true;
            btnCustomException.Click += btnCustomException_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 66);
            Controls.Add(btnCustomException);
            Controls.Add(btnException);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnException;
        private Button btnCustomException;
    }
}
