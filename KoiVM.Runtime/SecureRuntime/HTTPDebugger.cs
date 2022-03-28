using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace LastByte.SecureRuntime
{
   public class HTTPDebugger
    {
        //checks if http debugger service is running
        //example usage:
        //if(isHttpDebuggerRunning() == true)
     
        public bool isHTTPDebuggerRunning()
        {
            Process[] pname = Process.GetProcessesByName("HTTPDebuggerSvc");
            if (pname.Length == 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }
        //requires admin permissions
        //you should killed http debugger service
        //rewrites http debugger from it is original location:
        //C:\Program Files (x86)\HTTPDebuggerPro\HTTPDebuggerSvc.exe
        public void EndJobOfHTTPDebugger()
        {
            if(isHTTPDebuggerRunning())
            {
                KillHTTPDebugger();
            }
            else
            {
                try
                {          
                    File.WriteAllText(@"C:\Program Files (x86)\HTTPDebuggerPro\HTTPDebuggerSvc.exe", "VMGuardian has killed your http debugger lol");
                }
                catch(Exception ex)
                {
                    throw new Exception("Failed to attempting delete httpdebugger", ex);
                }
            }
        }
        //ends http debugger service
        public void KillHTTPDebugger()
        {
            foreach (var process in Process.GetProcessesByName("HTTPDebuggerSvc"))
            {
                process.Kill();
            }
        }
    }
}
