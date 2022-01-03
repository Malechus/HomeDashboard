namespace HomeDashboard
{
    partial class HomeScreen
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
            this.components = new System.ComponentModel.Container();
            this.clockCounter = new System.Windows.Forms.Timer(this.components);
            this.homeClock = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.minuteRefresh = new System.Windows.Forms.Timer(this.components);
            this.fiveMinuteRefresh = new System.Windows.Forms.Timer(this.components);
            this.hourRefresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // clockCounter
            // 
            this.clockCounter.Enabled = true;
            this.clockCounter.Interval = 1000;
            this.clockCounter.Tick += new System.EventHandler(this.clockCounter_Tick);
            // 
            // homeClock
            // 
            this.homeClock.BackColor = System.Drawing.Color.Black;
            this.homeClock.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.homeClock.Location = new System.Drawing.Point(12, 12);
            this.homeClock.Name = "homeClock";
            this.homeClock.Size = new System.Drawing.Size(441, 147);
            this.homeClock.TabIndex = 0;
            this.homeClock.TabStop = false;
            this.homeClock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateBox
            // 
            this.dateBox.BackColor = System.Drawing.Color.Black;
            this.dateBox.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateBox.Location = new System.Drawing.Point(12, 165);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(441, 77);
            this.dateBox.TabIndex = 1;
            this.dateBox.TabStop = false;
            this.dateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minuteRefresh
            // 
            this.minuteRefresh.Interval = 60000;
            this.minuteRefresh.Tick += new System.EventHandler(this.minuteRefresh_Tick);
            // 
            // fiveMinuteRefresh
            // 
            this.fiveMinuteRefresh.Interval = 300000;
            this.fiveMinuteRefresh.Tick += new System.EventHandler(this.fiveMinuteRefresh_Tick);
            // 
            // hourRefresh
            // 
            this.hourRefresh.Interval = 3600000;
            this.hourRefresh.Tick += new System.EventHandler(this.hourRefresh_Tick);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.homeClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer clockCounter;
        private TextBox homeClock;
        private TextBox dateBox;
        private System.Windows.Forms.Timer minuteRefresh;
        private System.Windows.Forms.Timer fiveMinuteRefresh;
        private System.Windows.Forms.Timer hourRefresh;
    }
}