namespace UniversalCalendar.Models
{
    /// <summary>
    /// For each item, there is Content, Overview and Notes (like Scrivener), and potentially children
    /// For each item, there is (ID), EventTime struct (IsDefinitive, DateTime, Description), CalendarType, Parent
    /// </summary>
    public class CalendarItem
    {
        public CalendarItem Parent;

        public string Title { get; set; }
        public string Overview { get; set; }
        public string Content { get; set; }
        public string Notes { get; set; }

        public string Labels { get; set; }
        public string Collections { get; set; }

        public EventTime Time;
    }
}