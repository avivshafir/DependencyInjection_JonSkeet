using NodaTime;

namespace DependencyInjection_JonSkeet
{
    public class Diary
    {
        private readonly IClock clock;
        private readonly CalendarSystem calender;
        private readonly DateTimeZone timeZone;

        public Diary(IClock clock, CalendarSystem calender, DateTimeZone timeZone)
        {
            this.clock = clock;
            this.calender = calender;
            this.timeZone = timeZone;
        }

        public string DisplayToday()
        {
            
        }
    }
}
