using NodaTime;

namespace DependencyInjectionDemo
{
    class Program
    {
        static void Main()
        {
            IClock clock = SystemClock.Instance;

            Licence licence = new Licence(new Instant(0), clock);

            Diary diary = new Diary(clock, CalendarSystem.Iso, DateTimeZone.Utc);

            DiaryPresenter presenter = new DiaryPresenter(diary, licence);

            //these components are decoupled
            //Its just a demonstration for how dependency injection
            //can become complicated with many components involved...

            //This is why we use a DI framework like Ninject...
        }
    }
}
