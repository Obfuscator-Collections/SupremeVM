using System;
using LastByte.SecureRuntime;

namespace SupremeVM {
	public class SupremeVM {

		public static object Run(RuntimeTypeHandle type, uint id, object[] args) {
			Crash c = new Crash();
			DebuggerScan debuggerScan = new DebuggerScan();
			debuggerScan.ScanAndKill();
			//Anti_Dump1.AntiDump();
			bool debuggeracl = DebuggerAcl.Run();
            if (debuggeracl)
            {
				c.CrashWithMsg("e", "Debugging is not allowed!", "SupremeVM", System.Windows.Forms.MessageBoxIcon.Error);
            }
			bool commonacl = CommonAcl.SecurityDocumentElement();
			Sandboxie sandboxie = new Sandboxie();
            if (sandboxie.IsSandboxie())
            {
				c.CrashWithMsg("e", "Running under Virtual Environments is not allowed!", "SupremeVM", System.Windows.Forms.MessageBoxIcon.Error);
			}
            if (commonacl)
            {
				c.CrashWithMsg("e", "Running under VMs is not allowed!", "SupremeVM", System.Windows.Forms.MessageBoxIcon.Error);
			}
			var module = Type.GetTypeFromHandle(type).Module;
			return VMInstance.Instance(module).Run(id, args);
		}

		public static unsafe void Run(RuntimeTypeHandle type, uint id, void*[] typedRefs, void* retTypedRef) {
			Crash c = new Crash();
			DebuggerScan debuggerScan = new DebuggerScan();
			debuggerScan.ScanAndKill();
			//Anti_Dump1.AntiDump();
			bool debuggeracl = DebuggerAcl.Run();
			if (debuggeracl)
			{
				c.CrashWithMsg("e", "Debugging is not allowed!", "SupremeVM", System.Windows.Forms.MessageBoxIcon.Error);
			}
			bool commonacl = CommonAcl.SecurityDocumentElement();
			Sandboxie sandboxie = new Sandboxie();
			if (sandboxie.IsSandboxie())
			{
				c.CrashWithMsg("e", "Running under Virtual Environments is not allowed!", "SupremeVM", System.Windows.Forms.MessageBoxIcon.Error);
			}
			if (commonacl)
			{
				c.CrashWithMsg("e", "Running under VMs is not allowed!", "SupremeVM", System.Windows.Forms.MessageBoxIcon.Error);
			}
			var module = Type.GetTypeFromHandle(type).Module;
			VMInstance.Instance(module).Run(id, typedRefs, retTypedRef);
		}

		internal static object RunInternal(int moduleId, ulong codeAddr, uint key, uint sigId, object[] args) {
			Crash c = new Crash();
			DebuggerScan debuggerScan = new DebuggerScan();
			debuggerScan.ScanAndKill();
			//Anti_Dump1.AntiDump();
			bool debuggeracl = DebuggerAcl.Run();
			if (debuggeracl)
			{
				c.CrashWithMsg("e", "Debugging is not allowed!", "SupremeVM", System.Windows.Forms.MessageBoxIcon.Error);
			}
			bool commonacl = CommonAcl.SecurityDocumentElement();
			Sandboxie sandboxie = new Sandboxie();
			if (sandboxie.IsSandboxie())
			{
				c.CrashWithMsg("e", "Running under Virtual Environments is not allowed!", "SupremeVM", System.Windows.Forms.MessageBoxIcon.Error);
			}
			if (commonacl)
			{
				c.CrashWithMsg("e", "Running under VMs is not allowed!", "SupremeVM", System.Windows.Forms.MessageBoxIcon.Error);
			}
			return VMInstance.Instance(moduleId).Run(codeAddr, key, sigId, args);
		}

		internal static unsafe void RunInternal(int moduleId, ulong codeAddr, uint key, uint sigId, void*[] typedRefs,
			void* retTypedRef) {
			Crash c = new Crash();
			DebuggerScan debuggerScan = new DebuggerScan();
			debuggerScan.ScanAndKill();
			//Anti_Dump1.AntiDump();
			bool debuggeracl = DebuggerAcl.Run();
			if (debuggeracl)
			{
				c.CrashWithMsg("e", "Debugging is not allowed!", "SupremeVM", System.Windows.Forms.MessageBoxIcon.Error);
			}
			bool commonacl = CommonAcl.SecurityDocumentElement();
			Sandboxie sandboxie = new Sandboxie();
			if (sandboxie.IsSandboxie())
			{
				c.CrashWithMsg("e", "Running under Virtual Environments is not allowed!", "SupremeVM", System.Windows.Forms.MessageBoxIcon.Error);
			}
			if (commonacl)
			{
				c.CrashWithMsg("e", "Running under VMs is not allowed!", "SupremeVM", System.Windows.Forms.MessageBoxIcon.Error);
			}
			VMInstance.Instance(moduleId).Run(codeAddr, key, sigId, typedRefs, retTypedRef);
		}
	}
}