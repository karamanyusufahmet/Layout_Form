namespace MotionUI.View.UserControls
{
    partial class TopBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buStatus1 = new buControls.Controls.buStatus();
            this.SuspendLayout();
            // 
            // buStatus1
            // 
            this.buStatus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buStatus1.Image = null;
            this.buStatus1.Location = new System.Drawing.Point(454, 3);
            this.buStatus1.Name = "buStatus1";
            this.buStatus1.Size = new System.Drawing.Size(762, 94);
            this.buStatus1.Status.Alarm.BackColor = System.Drawing.Color.Red;
            this.buStatus1.Status.Information.BackColor = System.Drawing.Color.Blue;
            this.buStatus1.Status.StatusText = "Test";
            this.buStatus1.Status.Warning.BackColor = System.Drawing.Color.Gold;
            this.buStatus1.TabIndex = 0;
            this.buStatus1.Text = "buStatus1";
            // 
            // TopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buStatus1);
            this.Name = "TopBar";
            this.Size = new System.Drawing.Size(1526, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private buControls.Controls.buStatus buStatus1;
    }
}
