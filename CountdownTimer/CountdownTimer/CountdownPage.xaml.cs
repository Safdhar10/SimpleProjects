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
using System.Timers;
using System.Windows.Threading;
using System.Diagnostics;

namespace CountdownTimer
{
    /// <summary>
    /// Interaction logic for CountdownPage.xaml
    /// </summary>
    public partial class CountdownPage : Page
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        Stopwatch _stopWatch = new Stopwatch();
        
        public CountdownPage()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_tick);
            dispatcherTimer.Interval = new TimeSpan(0,0,0,0,1);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_tick(object sender, EventArgs e)
        {
            if(_stopWatch.IsRunning)
            {
                TimeSpan ts = _stopWatch.Elapsed;
                string currentTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Minutes, ts.Seconds, ts.Milliseconds/10 );
                Time.Content = currentTime;
            }
        }

        private void strtBtn(object sender, RoutedEventArgs e)
        {
            _stopWatch.Start();
            startPanel.Visibility = Visibility.Hidden;
            pausePanel.Visibility = Visibility.Visible;
        }
        private void pauseBtn(object sender, RoutedEventArgs e)
        {
            _stopWatch.Stop();
            pausePanel.Visibility = Visibility.Hidden;
            stopPanel.Visibility = Visibility.Visible;
        }

        private void stopBtn(object sender, RoutedEventArgs e)
        {
            _stopWatch.Reset();
            Time.Content = "00:00:00";
            stopPanel.Visibility = Visibility.Hidden;
            startPanel.Visibility = Visibility.Visible;
        }

        private void resumeBtn(object sender, RoutedEventArgs e)
        {
            _stopWatch.Start();
        }

    }
}
