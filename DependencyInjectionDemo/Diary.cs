using NodaTime;
using NodaTime.Text;

namespace DependencyInjectionDemo
{
    public class Diary
    {
        private readonly LocalDatePattern outputPattern =
            LocalDatePattern.CreateWithInvariantCulture("yyyy-MM-dd");

        private readonly IClock clock;
        private readonly CalendarSystem calender;
        private readonly DateTimeZone timeZone;

        public Diary(IClock clock, CalendarSystem calender, DateTimeZone timeZone)
        {
            this.clock = clock;
            this.calender = calender;
            this.timeZone = timeZone;
        }

        public string FormatToday()
        {
            LocalDate date = clock.Now.InZone(timeZone, calender).LocalDateTime.Date;
            return outputPattern.Format(date);
        }
    }
}
