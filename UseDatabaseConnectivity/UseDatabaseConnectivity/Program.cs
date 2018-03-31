using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseConnectivity
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger loggerObj = Logger.GetLogger();
                      
            Console.WriteLine("DataBase Connectivity");
            string serverNo;
            Servers server;
            string operationNo;
            Operations operation;
            Program pObj = new Program();

            do
            {
                displayServerMenu();
                serverNo = Console.ReadLine();
                server = (Servers)Enum.Parse(typeof(Servers), serverNo);
                if (Convert.ToInt32(serverNo) == 4)
                {
                    loggerObj.LogPrint();
                    Console.ReadLine();
                    break;
                }
                displayOperationMenu();
                operationNo = Console.ReadLine();
                operation = (Operations)Enum.Parse(typeof(Operations), operationNo);
                if (Convert.ToInt32(operationNo) == 5)
                    break;

                MyServer myServer = pObj.GetServer(server);

                switch (operation)
                {
                            case Operations.Insert : myServer.Insert();
                                break;
                            case Operations.Update : myServer.Update();
                                break;
                            case Operations.Delete : myServer.Delete();
                                break;
                            case Operations.Select : myServer.Select();
                                break;
                            default: Console.WriteLine("Invalid Choice");
                                break;
               }

            } while (Convert.ToInt32(serverNo) != 4);
        }

        public MyServer GetServer(Servers server)
        { 
            switch(server)
            {
                case Servers.SQL: return new SQLServer();
                case Servers.Oracle: return new OracleServer();
                case Servers.Access: return new MyAccessServer();
                default: return null;
            }
        }

        public static void displayServerMenu()
        {
            Console.WriteLine("Choose The Server");
            int lastServerValue = 0;
            foreach (Servers s in Enum.GetValues(typeof(Servers)))
            {
                Console.WriteLine((int)s + ". " + s);
                lastServerValue = (int)s;
            }
            Console.WriteLine(lastServerValue + 1 + ". " + "Exit");
        }

        public static void displayOperationMenu()
        {
            Console.WriteLine("Choose The Operation");
            int lastOperationValue = 0;
            foreach (Operations o in Enum.GetValues(typeof(Operations)))
            {
                Console.WriteLine((int)o + " " + o);
                lastOperationValue = (int)o;
            }
            Console.WriteLine(lastOperationValue + 1 + " " + "Exit");
        }
    }

    public enum Servers
    {
        SQL = 1, Oracle, Access
    };

    public enum Operations
    {
        Insert = 1, Update, Delete, Select
    };
}
