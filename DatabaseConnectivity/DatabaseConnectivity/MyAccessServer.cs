using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity
{
    public class MyAccessServer : MyServer
    {
        public override void Insert()
        {
            message = "MyAccessServer : Insert";
            Console.WriteLine(message);
            loggerObj.Log(message);
        }
        public override void Update()
        {
            message = "MyAccessServer : Update";
            Console.WriteLine(message);
            loggerObj.Log(message);
        }
        public override void Delete()
        {
            message = "MyAccessServer : Delete";
            Console.WriteLine(message);
            loggerObj.Log(message);
        }
        public override void Select()
        {
            message = "MyAccessServer : Select";
            Console.WriteLine(message);
            loggerObj.Log(message);
        }
    }
}
