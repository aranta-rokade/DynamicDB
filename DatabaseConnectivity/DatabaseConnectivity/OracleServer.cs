using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity
{
    public class OracleServer : MyServer
    {
        public override void Insert()
        {
            message = "OracleServer : Insert";
            Console.WriteLine(message);
            loggerObj.Log(message);
        }
        public override void Update()
        {
            message = "OracleServer : Update";
            Console.WriteLine(message);
            loggerObj.Log(message);
        }
        public override void Delete()
        {
            message = "OracleServer : Delete";
            Console.WriteLine(message);
            loggerObj.Log(message);
        }
        public override void Select()
        {
            message = "OracleServer : Select";
            Console.WriteLine(message);
            loggerObj.Log(message);
        }
    }
}
