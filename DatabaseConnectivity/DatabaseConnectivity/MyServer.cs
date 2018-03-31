using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity
{
    public abstract class MyServer
    {
        internal Logger loggerObj = Logger.GetLogger();
        internal String message = "";

        public abstract void Insert();
        public abstract void Update();
        public abstract void Delete();
        public abstract void Select();
    }
}
