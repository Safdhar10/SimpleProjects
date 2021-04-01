using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using TimeZoneConverter;

namespace Digital_Clock
{
    class Time
    {
        public Dictionary<string, string> RegionTimeDetails = new Dictionary<string, string>();
        private static TimeZoneInfo tzi; 
        DateTime dt;
        public void TimeZoneConverter(String TimeZone)
        {
            tzi = TZConvert.GetTimeZoneInfo(TimeZone);
            dt = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tzi);
        }
        private string _hour;
        private string _minute;
        private string _second;
        private string _amORPm;
        private string _date;
        private string _month;
        private string _year;
        private string _day;

        public string Hour
        {
            get
            {
                return dt.ToString("hh");
            }
        }
        public string Minute
        {
            get
            {
                return dt.ToString("mm");
            }
        }
        public string Second
        {
            get
            {
                return dt.ToString("ss");
            }
            
        }
        public string AmORPm
        {
            get
            {
                return dt.ToString("tt");
            }
            
        }
        public string Date
        {
            get
            {
                return dt.ToString("dd");
            }
            
        }
        public string Month
        {
            get
            {
                return dt.ToString("MM");
            }
            
        }
        public string Year
        {
            get
            {
                return dt.ToString("yyyy");
            }
            
        }
        public string Day
        {
            get
            {
                return dt.ToString("dddd");
            }
        }
    }
}
