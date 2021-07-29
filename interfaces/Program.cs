using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();

            //ILogger arayüzünden implemente edilen FileLogger sınıfının WriteLog() 
            //metodunu çağırıyoruz.
            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
        }
    } 
}
