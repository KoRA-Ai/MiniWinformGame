using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogService
{
    internal interface ILogger
    {
        void ConsoleLog(LogType logtype, string text);
    }

    public enum LogType
    {
        Error, Info
    }
}