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

namespace Digital_Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> TimeZones = new List<string>();
        Time GetTime = new Time();
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            AddTimeZone();
            Region.ItemsSource = TimeZones;
            Region.SelectedItem = "India Standard Time";
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }
        private void AddTimeZone()
        {
            var AllTimeZones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var item in AllTimeZones)
            {
                TimeZones.Add(item.StandardName);
            }
        }
        private void dispatcherTimer_tick(object sender, EventArgs e)
        {
            GetTime = new Time();
            HourMinute.Content = GetTime.Hour(Region.SelectedItem.ToString())+":"+GetTime.Minute(Region.SelectedItem.ToString());
            Seconds.Content = GetTime.Second(Region.SelectedItem.ToString());
            TT.Content = GetTime.AmORPm(Region.SelectedItem.ToString());
        }

        private void Region_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HourMinute.Content = GetTime.Hour(Region.SelectedItem.ToString()) + ":" + GetTime.Minute(Region.SelectedItem.ToString());
            Seconds.Content = GetTime.Second(Region.SelectedItem.ToString());
            TT.Content = GetTime.AmORPm(Region.SelectedItem.ToString());
        }
    }
}
