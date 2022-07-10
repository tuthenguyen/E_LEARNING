using System;
using System.Collections.Generic;
using System.Text;

namespace E_LEARNING.APPLICATION.Base.Interfaces
{
    public interface IDateTime
    {
        DateTime Now { get; }
        bool IsWeekend(int year, int month, int day);
        IEnumerable<DateTime> GetWorkingDayOfMonth(int month, int year);
        bool IsTimeStart(string timeStart = "", string timeEnd = "");
    }
}
