using System;

namespace Interface
{
    public class SmsLoger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Sms olarak yazar.");
        }
    }
}