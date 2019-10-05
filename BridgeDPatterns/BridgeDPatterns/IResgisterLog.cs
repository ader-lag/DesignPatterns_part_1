using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDPatterns
{
    public interface IResgisterLog
    {
        void LogReport(string LogMessage, int LogID);
    }
}
