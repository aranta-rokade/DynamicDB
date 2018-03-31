using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity
{
    public class Logger
    {
        static ArrayList messages = new ArrayList();
        static int messageCount = 0;
        static Logger logger;
        string[] arr = new string[100]; 

        private Logger()
        {
        
        }

        public static Logger GetLogger()
        {
            if (logger == null)
            {
                logger = new Logger();
            }

            return logger;
        }

        public void Log (string message)
        {
            if (messageCount > 100)
            {
                for (int i = 0; i < messageCount; i++)
                {
                    arr[i] = arr[i + 1];
                }
            }

            arr[messageCount] = message;
            messageCount++;
        }

        public void LogPrint()
        {
            for (int i = 0; i < messageCount; i++)
            {
                Console.WriteLine(arr[0]);
            }
        }
    }
}
