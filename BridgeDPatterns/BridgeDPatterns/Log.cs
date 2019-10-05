using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDPatterns
{
    public abstract class Log
    {
        public IResgisterLog _registerLog;
        public string LogMessage;
        public int LogID;
        public abstract void LogAppMessgae();
    }
}
