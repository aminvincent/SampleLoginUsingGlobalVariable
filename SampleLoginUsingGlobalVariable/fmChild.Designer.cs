namespace SampleLoginUsingGlobalVariable
{
    partial class fmChild
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
            this.btnCheckTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckTest
            // 
            this.btnCheckTest.Location = new System.Drawing.Point(75, 31);
            this.btnCheckTest.Name = "btnCheckTest";
            this.btnCheckTest.Size = new System.Drawing.Size(118, 44);
            this.btnCheckTest.TabIndex = 0;
            this.btnCheckTest.Text = "Check UserName Value";
            this.btnCheckTest.UseVisualStyleBackColor = true;
            this.btnCheckTest.Click += new System.EventHandler(this.btnCheckTest_Click);
            // 
            // fmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 111);
            this.Controls.Add(this.btnCheckTest);
            this.Name = "fmChild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmChild";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckTest;
    }
}