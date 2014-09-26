using System;
using NodaTime;

namespace DependencyInjectionDemo
{
    public class Licence
    {
        private readonly DateTime expiry;
        private IClock clock;

        public Licence(Instant instant, IClock clock)
        {
            this.expiry = expiry;
            this.clock = clock;
        }

        //Makes testing very hard as DateTime.Now is a static method that
        //cant be mocked or allow dependency injection
        public bool hasExpired
        {
            get { return DateTime.UtcNow >= expiry; }
        }
    }
}
