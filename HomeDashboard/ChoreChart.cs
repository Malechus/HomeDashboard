using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeDashboard
{
    public partial class ChoreChart : Form
    {
        public ChoreChart()
        {
            InitializeComponent();
        }

        private void ChoreChart_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Focus();
        }

        private void choreTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
