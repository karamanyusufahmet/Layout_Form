namespace MotionUI
{
    partial class MainForm
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
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightCenterPanel = new System.Windows.Forms.Panel();
            this.userControl11 = new MotionUI.View.UserControls.Control();
            this.rightBottomPanel = new System.Windows.Forms.Panel();
            this.rightTopPanel = new System.Windows.Forms.Panel();
            this.controls1 = new MotionUI.View.UserControls.Controls();
            this.topPanel = new System.Windows.Forms.Panel();
            this.topBar1 = new MotionUI.View.UserControls.TopBar();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rightPanel.SuspendLayout();
            this.rightCenterPanel.SuspendLayout();
            this.rightTopPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.Transparent;
            this.rightPanel.Controls.Add(this.rightCenterPanel);
            this.rightPanel.Controls.Add(this.rightBottomPanel);
            this.rightPanel.Controls.Add(this.rightTopPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1526, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(394, 1080);
            this.rightPanel.TabIndex = 0;
            // 
            // rightCenterPanel
            // 
            this.rightCenterPanel.Controls.Add(this.userControl11);
            this.rightCenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightCenterPanel.Location = new System.Drawing.Point(0, 360);
            this.rightCenterPanel.Name = "rightCenterPanel";
            this.rightCenterPanel.Size = new System.Drawing.Size(394, 360);
            this.rightCenterPanel.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Transparent;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(394, 360);
            this.userControl11.TabIndex = 0;
            // 
            // rightBottomPanel
            // 
            this.rightBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rightBottomPanel.Location = new System.Drawing.Point(0, 720);
            this.rightBottomPanel.Name = "rightBottomPanel";
            this.rightBottomPanel.Size = new System.Drawing.Size(394, 360);
            this.rightBottomPanel.TabIndex = 1;
            // 
            // rightTopPanel
            // 
            this.rightTopPanel.Controls.Add(this.controls1);
            this.rightTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightTopPanel.Location = new System.Drawing.Point(0, 0);
            this.rightTopPanel.Name = "rightTopPanel";
            this.rightTopPanel.Size = new System.Drawing.Size(394, 360);
            this.rightTopPanel.TabIndex = 0;
            // 
            // controls1
            // 
            this.controls1.BackColor = System.Drawing.Color.Transparent;
            this.controls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controls1.Location = new System.Drawing.Point(0, 0);
            this.controls1.Name = "controls1";
            this.controls1.Size = new System.Drawing.Size(394, 360);
            this.controls1.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Controls.Add(this.topBar1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1526, 100);
            this.topPanel.TabIndex = 1;
            // 
            // topBar1
            // 
            this.topBar1.BackColor = System.Drawing.Color.Transparent;
            this.topBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topBar1.Location = new System.Drawing.Point(0, 0);
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(1526, 100);
            this.topBar1.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 980);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1526, 100);
            this.bottomPanel.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1526, 880);
            this.mainPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.rightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.rightPanel.ResumeLayout(false);
            this.rightCenterPanel.ResumeLayout(false);
            this.rightTopPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel rightCenterPanel;
        private System.Windows.Forms.Panel rightBottomPanel;
        private System.Windows.Forms.Panel rightTopPanel;
        private View.UserControls.Controls controls1;
        private View.UserControls.TopBar topBar1;
        public View.UserControls.Control userControl11;
    }
}

