using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity
{
    public class SQLServer : MyServer
    {
        public override void Insert()
        {
            message = "SQLServer : Insert";
            Console.WriteLine(message);
            loggerObj.Log(message);
        }
        public override void Update()
        {
            message = "SQLServer : Update";
            Console.WriteLine(message);
            loggerObj.Log(message);
        }
        public override void Delete()
        {
            message = "SQLServer : Delete";
            Console.WriteLine(message);
            loggerObj.Log(message);
        }
        public override void Select()
        {
            message = "SQLServer : Select";
            Console.WriteLine(message);
            loggerObj.Log(message);
        }
    }
}
