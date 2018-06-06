using System;
using System.Windows.Forms;

namespace MuEditor
{
	// Token: 0x02000021 RID: 33
	internal static class Program
	{
		// Token: 0x060001BA RID: 442 RVA: 0x0000369C File Offset: 0x0000189C
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmMain());
		}
	}
}
