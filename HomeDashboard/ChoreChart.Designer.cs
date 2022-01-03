namespace HomeDashboard
{
    partial class ChoreChart
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
            this.components = new System.ComponentModel.Container();
            this.choreTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // choreTimer
            // 
            this.choreTimer.Enabled = true;
            this.choreTimer.Interval = 60000;
            this.choreTimer.Tick += new System.EventHandler(this.choreTimer_Tick);
            // 
            // ChoreChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoreChart";
            this.Text = "ChoreChart";
            this.Load += new System.EventHandler(this.ChoreChart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer choreTimer;
    }
}