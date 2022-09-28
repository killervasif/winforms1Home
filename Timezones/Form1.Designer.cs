namespace Timezones
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
            this.cityChange = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityChange
            // 
            this.cityChange.AutoSize = true;
            this.cityChange.Location = new System.Drawing.Point(12, 416);
            this.cityChange.Name = "cityChange";
            this.cityChange.Size = new System.Drawing.Size(82, 25);
            this.cityChange.TabIndex = 0;
            this.cityChange.Text = "Change City";
            this.cityChange.UseVisualStyleBackColor = true;
            this.cityChange.Click += new System.EventHandler(this.cityChange_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(537, 416);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(73, 15);
            this.Time.TabIndex = 1;
            this.Time.Text = "CurrentTime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Timezones.Properties.Resources.Baku;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 473);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.cityChange);
            this.Name = "Form1";
            this.Text = "Baku And London Times";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cityChange;
        private Label Time;
    }
}