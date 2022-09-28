namespace NaughtyLabel
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
            this.NaughtyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NaughtyLabel
            // 
            this.NaughtyLabel.AutoSize = true;
            this.NaughtyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NaughtyLabel.Location = new System.Drawing.Point(404, 230);
            this.NaughtyLabel.Name = "NaughtyLabel";
            this.NaughtyLabel.Size = new System.Drawing.Size(106, 17);
            this.NaughtyLabel.TabIndex = 0;
            this.NaughtyLabel.Text = "Get away from me";
            this.NaughtyLabel.MouseHover += new System.EventHandler(this.NaughtyLabel_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1061, 504);
            this.Controls.Add(this.NaughtyLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Try to catch it";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NaughtyLabel;
    }
}