using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastByte.SecureRuntime
{
    public class Crash
    {
       
        public void CrashApp(string Reason)
        {
           Environment.FailFast(Reason);
        }
      
        public void CrashApp(string Reason, Exception exception)
        {
            Environment.FailFast(Reason, exception);
        }
        public void CrashWithMsg(string Reason, string Message, string Caption, MessageBoxIcon Icon )
        {
            MessageBox.Show(Message, Caption, MessageBoxButtons.OK, Icon);
            Environment.FailFast(Reason);         
        }
       
        public void CrashWithMsg(string Reason, Exception exception, string Message, string Caption, MessageBoxIcon Icon)
        {
            MessageBox.Show(Message, Caption, MessageBoxButtons.OK, Icon);
            Environment.FailFast(Reason, exception);
        }

    }
}
