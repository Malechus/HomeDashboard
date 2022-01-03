using HomeDashboardObjects;
using HomeDashboardQueries;
using HomeDashboardQueries.Models;

namespace HomeDashboard
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }


        private void HomeScreen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            dateBox.Text = DateTime.Now.ToShortDateString();
            homeClock.Text = DateTime.Now.ToString("HH:mm");
            bool errorSetup = ErrorLogging.ErrorCheck();
            if (!errorSetup)
            {
                MessageBox.Show("There is a problem with error handling, please notify Garrett.");
            }

            homeContext _homeContext = new homeContext();
            string today = DateTime.Today.DayOfWeek.ToString();
            List<Chore> todaysChores = new List<Chore>();

            try
            {
                switch (today)
                {
                    case "Monday":
                        todaysChores.AddRange(_homeContext.Chores
                            .Where(c => c.Monday != null));
                        break;
                    case "Tuesday":
                        todaysChores.AddRange(_homeContext.Chores
                            .Where(c => c.Tuesday != null));
                        break;
                    case "Wednesday":
                        todaysChores.AddRange(_homeContext.Chores
                            .Where(c => c.Wednesday != null));
                        break;
                    case "Thursday":
                        todaysChores.AddRange(_homeContext.Chores
                            .Where(c => c.Thursday != null));
                        break;
                    case "Friday":
                        todaysChores.AddRange(_homeContext.Chores
                            .Where(c => c.Friday != null));
                        break;
                    case "Saturday":
                        todaysChores.AddRange(_homeContext.Chores
                            .Where(c => c.Saturday != null));
                        break;
                    case "Sunday":
                        todaysChores.AddRange(_homeContext.Chores
                            .Where(c => c.Sunday != null));
                        break;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.ErrorHandler(ex, DateTime.Now);
            }


        }

        private void clockCounter_Tick(object sender, EventArgs e)
        {
            homeClock.Text = DateTime.Now.ToString("HH:mm");
        }

        private void minuteRefresh_Tick(object sender, EventArgs e)
        {
            dateBox.Text = DateTime.Now.ToShortDateString();
        }

        private void fiveMinuteRefresh_Tick(object sender, EventArgs e)
        {

        }

        private void hourRefresh_Tick(object sender, EventArgs e)
        {

        }
    }
}