using System.Collections.Generic;

namespace UniversalCalendar.Models
{
    public class CalendarEvents
    {
        public string Title;
        public CalendarType CalendarType = new CalendarType();
        public List<CalendarItem> Items = new List<CalendarItem>();
    }
}