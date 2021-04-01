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
        public string Hour(string Zone)
        {
            TimeZoneConverter(Zone);
            //string _hour = dt.Hour + ":";

            //if (dt.Hour<=9)
            //{
            //    _hour = "0" + dt.Hour +":";
            //}
            //return _hour;
            return dt.ToString("hh");
        }
        public string Minute(string Zone)
        {
            TimeZoneConverter(Zone);
            //string _minute = dt.Minute.ToString();
            //if (dt.Minute <= 9)
            //{
            //    _minute = "0" + dt.Minute.ToString();
            //}
            //return _minute;
            return dt.ToString("mm");
        }
        public string Second(String Zone)
        {
            TimeZoneConverter(Zone);
            //string _second = dt.Second.ToString(); 
            //if (dt.Second <= 9)
            //{
            //    _second = "0" + dt.Second.ToString();
            //}
            //return _second;
            return dt.ToString("ss");
        }
        public string AmORPm(String Zone)
        {
            TimeZoneConverter(Zone);
            return dt.ToString("tt");
        }
    }
}
