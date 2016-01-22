using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace DataAccess
{
    public class LogManager
    {
        private static LogManager instance;

        ILog log;

        private LogManager()
        {
            //string workPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            //workPath = workPath.Substring(0, workPath.LastIndexOf('\\') + 1);
            //System.Environment.CurrentDirectory = workPath;
            //log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo(workPath + "TetsLog4net.exe.config"));
            //创建日志记录组件实例
            log = log4net.LogManager.GetLogger("LogManager");
        }

        public static LogManager GetInstance()
        {
            if (instance == null)
            {
                instance = new LogManager();
            }

            return instance;
        }

        public void Error(string p, Exception exception)
        {
            log.Error(p, exception);
        }

        public void Fatal(string p, Exception exception)
        {
            log.Fatal(p, exception);
        }

        public void Info(string p)
        {
            log.Info(p);
        }

        public void Debug(string p)
        {
            log.Debug(p);
        }

        public void Warn(string p)
        {
            log.Warn(p);
        }
    }
}
