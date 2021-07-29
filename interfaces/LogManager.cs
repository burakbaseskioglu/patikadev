using System;

namespace interfaces
{
    public class LogManager : ILogger
    {
        public ILogger _logger;

        //ILogger arayüzünden implemente edilen sınıfların
        //nesnelerini interface referansı olarak verebiliriz.
        public LogManager(ILogger logger)
        {
            _logger = logger;//Yukarıda oluşturduğumuz _logger referansına çağrıldığı yerden 
            //ne gelirse atıyoruz.
        }

        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}