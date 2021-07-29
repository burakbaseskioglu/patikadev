using System;

namespace interfaces
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}