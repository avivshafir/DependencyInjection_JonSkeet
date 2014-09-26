using System;
using DependencyInjectionDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NodaTime;
using NodaTime.Testing;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void FormatToday_Iso_Utc()
        {
            var clock = new FakeClock(new Instant(0));
            Diary diary = new Diary(clock, CalendarSystem.Iso, DateTimeZone.Utc);

            string today = diary.FormatToday();

            Assert.AreEqual("1970-01-01", today);
        }

        [TestMethod]
        public void FormatToday_Iso_NegativeOffset()
        {
            var zone = DateTimeZone.ForOffset(Offset.FromHours(-8));
            var clock = new FakeClock(new Instant(0));
            Diary diary = new Diary(clock, CalendarSystem.Iso, zone);

            string today = diary.FormatToday();

            Assert.AreEqual("1969-12-31", today);
        }
    }
}
