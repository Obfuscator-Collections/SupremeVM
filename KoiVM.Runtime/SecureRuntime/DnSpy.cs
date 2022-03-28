using System;
using System.IO;

namespace LastByte.SecureRuntime
{
    public class DnSpy
    {
        public bool ValueType()
        {
            if (!File.Exists(Environment.ExpandEnvironmentVariables("%appdata%") + "\\dnSpy\\dnSpy.xml"))
            {
                return false;
            }
            else{
                return true;
            }
          
        }
    }
}