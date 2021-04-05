using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Timers;

namespace CountdownTimer
{
    /// <summary>
    /// Interaction logic for Timer.xaml
    /// </summary>
    public partial class Timer : Page
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void NUDButtonUP_Click(object sender, RoutedEventArgs e)
        {
            int number;
            if (hrSet.Text != "") 
                number = Convert.ToInt32(hrSet.Text);
            else 
                number = 0;
            if (number < 23)
                hrSet.Text = Convert.ToString(number + 1);
            else
                hrSet.Text = Convert.ToString(number = 0);
        }

        private void NUDButtonLow_Click(object sender, RoutedEventArgs e)
        {
            int number;
            if (hrSet.Text != "")
                number = Convert.ToInt32(hrSet.Text);
            else
                number = 0;
            if (number ==0)
                hrSet.Text = Convert.ToString(number=23);
            else
                hrSet.Text = Convert.ToString(number-1);
        }

        private void MinUp_Click(object sender, RoutedEventArgs e)
        {
            int number;
            if (mmSet.Text != "")
                number = Convert.ToInt32(mmSet.Text);
            else
                number = 0;
            if (number < 59)
                mmSet.Text = Convert.ToString(number + 1);
            else
                mmSet.Text = Convert.ToString(number = 0);
        }

        private void MinLow_Click(object sender, RoutedEventArgs e)
        {
            int number;
            if (mmSet.Text != "")
                number = Convert.ToInt32(mmSet.Text);
            else
                number = 0;
            if (number == 0)
                mmSet.Text = Convert.ToString(number = 59);
            else
                mmSet.Text = Convert.ToString(number - 1);
        }

        private void SecUP_Click(object sender, RoutedEventArgs e)
        {
            int number;
            if (ssSet.Text != "")
                number = Convert.ToInt32(ssSet.Text);
            else
                number = 0;
            if (number < 59)
                ssSet.Text = Convert.ToString(number + 1);
            else
                ssSet.Text = Convert.ToString(number = 0);
        }

        private void SecLow_Click(object sender, RoutedEventArgs e)
        {
            int number;
            if (ssSet.Text != "")
                number = Convert.ToInt32(ssSet.Text);
            else
                number = 0;
            if (number == 0)
                ssSet.Text = Convert.ToString(number = 59);
            else
                ssSet.Text = Convert.ToString(number - 1);
        }

        private void timeStartButton(object sender, RoutedEventArgs e)
        {
            if(hrSet.Text.Equals("00") && mmSet.Text.Equals("00") && ssSet.Text.Equals("00"))
            {
                MessageBox.Show("Set Timer To Before You Start");
            }
            else
            {
                SetTimer.Visibility = Visibility.Hidden;
                timerPanel.Visibility = Visibility.Visible;
                RunTimer();
            }
        }
        DispatcherTimer disTimer = new DispatcherTimer();
        private void RunTimer()
        {
            _time =TimeSpan.FromHours(Convert.ToInt32(hrSet.Text))+TimeSpan.FromMinutes(Convert.ToInt32(mmSet.Text)) +TimeSpan.FromSeconds(Convert.ToInt32(ssSet.Text));
            disTimer.Tick += new EventHandler(disTimer_tick);
            disTimer.Interval = new TimeSpan(0, 0, 1);
            disTimer.Start();
        }
        TimeSpan _time = new TimeSpan();
        private void disTimer_tick(object sender, EventArgs e)
        {
            Time.Content = _time.ToString("c");
            if (_time == TimeSpan.Zero)
            {
                disTimer.Stop();
                MessageBox.Show("Your Timer is Stopped");
            }
            else
                _time = _time.Add(TimeSpan.FromSeconds(-1));
        }

        private void pauseBtn(object sender, RoutedEventArgs e)
        {
            disTimer.Stop();
            resumeButton.Visibility = Visibility.Visible;
            pauseButton.Visibility = Visibility.Hidden;
        }

        private void resumeBtn(object sender, RoutedEventArgs e)
        {
            disTimer.Start();
            resumeButton.Visibility = Visibility.Hidden;
            pauseButton.Visibility = Visibility.Visible;
        }

        private void StopButton(object sender, RoutedEventArgs e)
        {
            disTimer.Stop();
            timerPanel.Visibility = Visibility.Hidden;
            SetTimer.Visibility = Visibility.Visible;
            resumeButton.Visibility = Visibility.Hidden;
        }

        private void Brush(object sender, RoutedEventArgs e)
        {
            mmSet.Text = "02";
        }

        private void Face(object sender, RoutedEventArgs e)
        {
            mmSet.Text = "10";
        }

        private void Noon(object sender, RoutedEventArgs e)
        {
            mmSet.Text = "30";
        }

        private void SteamEgg(object sender, RoutedEventArgs e)
        {
            mmSet.Text = "15";
        }
    }
}
