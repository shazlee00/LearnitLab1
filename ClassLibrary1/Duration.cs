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

        public override string ToString() { return $"Hours:{_hours:00}, Minutes:{_minutes:00}, Seconds:{_seconds:00}";
        }



    }
}
