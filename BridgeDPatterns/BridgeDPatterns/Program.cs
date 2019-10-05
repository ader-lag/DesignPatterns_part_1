using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Log log = new ApplicationLog();
            log.LogMessage = "This is log message";
            log.LogID = 111;

            log._registerLog = new MediaPlayeerLogger();
            log.LogAppMessgae();

            log._registerLog = new DocumentReaderLogger();
            log.LogAppMessgae();

            log._registerLog = new BrowserLogger();
            log.LogAppMessgae();

            Console.ReadLine();
        }
    }
}
