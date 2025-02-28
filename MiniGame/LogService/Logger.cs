using System;
using System.Text;

namespace LogService
{
    internal class Logger : ILogger
    {
        private StringBuilder sbLog = new StringBuilder();

        public Logger(StringBuilder sb)
        {
            this.sbLog = sb;
        }

        void ILogger.ConsoleLog(LogType logType, string text)
        {
            switch (logType)
            {
                case LogType.Error:
                    sbLog.AppendLine("【ERROR】" + text);
                    break;

                case LogType.Info:
                    sbLog.AppendLine("【INFO】" + text);
                    break;

                default:
                    throw new ArgumentNullException();
            }
        }
    }
}