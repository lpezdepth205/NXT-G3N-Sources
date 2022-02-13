using System;
using System.Windows.Forms;
using COD2019TOOL;
using Reblunted_Cross_Camos;

namespace COD2019TOOL
{
	// Token: 0x02000005 RID: 5
	internal static class Program
	{
		// Token: 0x06000017 RID: 23 RVA: 0x0000373A File Offset: 0x0000193A
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
