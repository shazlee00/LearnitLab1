using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Duration
    {
        private int _hours;
        private
                    int _minutes;
        private int _seconds;

        public Duration(int hours, int minutes, int seconds)
        {
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
        }

        public Duration(int seconds)
        {
            _hours = seconds / 3600;
            _minutes = (seconds / 60) % 60;
            _seconds = seconds % 60;
        }

        public override string ToString()
        {
            return $"Hours:{_hours:00}, Minutes:{_minutes:00}, Seconds:{_seconds:00}";
        }


        public override bool Equals(object? obj)
        {
            if (obj is Duration duration)
            {
                return _hours == duration._hours && _minutes == duration._minutes && _seconds == duration._seconds;
            }
            else
            {
                return false;
            }

        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = d1._hours * 3600 + d1._minutes * 60 + d1._seconds +
                               d2._hours * 3600 + d2._minutes * 60 + d2._seconds;

            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            return new Duration(hours, minutes, seconds);
        }

        public static Duration operator ++(Duration d1)
        {
            // Add 60 seconds (1 minute)
            int totalSeconds = d1._hours * 3600 + d1._minutes * 60 + d1._seconds + 60;

            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            return new Duration(hours, minutes, seconds);
        }

        public static Duration operator --(Duration d1)
        {
            // Subtract 60 seconds (1 minute)
            int totalSeconds = d1._hours * 3600 + d1._minutes * 60 + d1._seconds - 60;

            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            return new Duration(hours, minutes, seconds);
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            int duration1 = d1._hours * 3600 + d1._minutes * 60 + d1._seconds;
            int duration2 = d2._hours * 3600 + d2._minutes * 60 + d2._seconds;

            return duration1 >= duration2;
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            int duration1 = d1._hours * 3600 + d1._minutes * 60 + d1._seconds;
            int duration2 = d2._hours * 3600 + d2._minutes * 60 + d2._seconds;

            return duration1 <= duration2;
        }

        public static Duration operator +(Duration d1, int secondsToAdd)
        {
            int totalSeconds = d1._hours * 3600 + d1._minutes * 60 + d1._seconds + secondsToAdd;

            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            return new Duration(hours, minutes, seconds);
        }


    }










    }
