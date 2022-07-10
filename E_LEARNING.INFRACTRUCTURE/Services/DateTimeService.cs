using E_LEARNING.APPLICATION.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_LEARNING.INFRACTRUCTURE.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.UtcNow.AddHours(7);

        public bool IsWeekend(int year, int month, int day)
        {
            DayOfWeek dayOfWeek = new DateTime(year, month, day).DayOfWeek;
            return (dayOfWeek == DayOfWeek.Saturday) || (dayOfWeek == DayOfWeek.Sunday);
        }

        public IEnumerable<DateTime> GetWorkingDayOfMonth(int month, int year)
        {
            var lstWorkingDay = new List<DateTime>();
            //var holidays = CalendarConstant.HOLIDAYS.Split(',').ToList();
            var startDate = new DateTime(year, month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            for (int i = startDate.Day; i <= endDate.Day; i++)
            {
                var date = new DateTime(startDate.Year, startDate.Month, i);
                bool isWeekend = IsWeekend(startDate.Year, startDate.Month, i);
                // bool isHoliday = holidays.Any(e => e == $"{date.Day.ToString("D2")}/{date.Month.ToString("D2")}");
                //if (!(isWeekend || isHoliday)) lstWorkingDay.Add(date);
            }

            return lstWorkingDay.OrderBy(e => e.Date);
        }

        public bool IsTimeStart(string timeStart = "", string timeEnd = "")
        {
            TimeSpan startCompare = string.IsNullOrEmpty(timeStart) ? TimeSpan.Parse("07:00") : TimeSpan.Parse(timeStart);
            TimeSpan endCompare = string.IsNullOrEmpty(timeEnd) ? TimeSpan.Parse("23:00") : TimeSpan.Parse(timeStart);
            var now = Now.TimeOfDay;
            return now >= startCompare && now <= endCompare;
        }
    }
}
