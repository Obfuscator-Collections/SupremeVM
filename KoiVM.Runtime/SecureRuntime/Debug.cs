using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LastByte.SecureRuntime
{
   public class Debug
    {
        public void Log(EnumDebugType type, string text)
        {
            if(File.Exists(@"C:\Users\" + Environment.UserName + @"\Desktop\Log.txt"))
            {
                writeValues(type, text);
            }
            else
            {
                File.Create(@"C:\Users\" + Environment.UserName + @"\Desktop\Log.txt");
                writeValues(type, text);
            }
        
           
        }
        private void writeValues(EnumDebugType enm, string value)
        {
            string time = DateTime.Now.ToString();
            string LOGS;
            LOGS = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\Log.txt");
            if (enm == EnumDebugType.Error)
            {
                File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\Log.txt", LOGS + Environment.NewLine + "[" + time + " ERROR]:" +" " + value);
            }
            if (enm == EnumDebugType.Warning)
            {
                File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\Log.txt", LOGS + Environment.NewLine + "[" + time + " WARNING]:" + " " + value);
            }
            if (enm == EnumDebugType.Success)
            {
                File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\Log.txt", LOGS + Environment.NewLine + "[" + time + " SUCCESS]:" + " " + value);
            }
            if (enm == EnumDebugType.Info)
            {
                File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\Log.txt", LOGS + Environment.NewLine + "[" + time + " INFO]:" + " " + value);
            }
        }
    }
}
