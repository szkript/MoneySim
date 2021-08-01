using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySim
{
    class TimeManager
    {
        public int DaysInCurrentMonth()
        {
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();
            int yearInt = int.Parse(year);
            int monthInt = int.Parse(month);
            return DateTime.DaysInMonth(yearInt, monthInt);
        }
    }
}
