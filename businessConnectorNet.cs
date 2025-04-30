using System;
using Microsoft.Dynamics.BusinessConnectorNet; // C:\Program Files (x86)\Microsoft Dynamics AX\60\Client\Bin\Microsoft.Dynamics.BusinessConnectorNet.dll

namespace ERP_ALP_WinTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Axapta ax = new Axapta();
                //ax.Logon("RTS", "en-au", null, null);

                //object result = ax.CallStaticClassMethod("className", "methodName", "paramStrList"); // CallStaticClassMethod for static methods
                //Console.WriteLine("Result: " + result.ToString());

                //ax.Logoff();

                Axapta ax = new Axapta();
                ax.Logon("RTS", "en-au", null, null);

                AxaptaObject obj = ax.CreateAxaptaObject("ERP_AmmeralBeltCSV"); // CreateAxaptaObject for instance methods
                obj.Call("run"); // run() method

                ax.Logoff();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
