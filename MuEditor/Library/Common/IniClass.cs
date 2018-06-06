using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Library.Common
{
	// Token: 0x02000016 RID: 22
	public class IniClass
	{
		// Token: 0x06000104 RID: 260
		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

		// Token: 0x06000105 RID: 261
		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

		// Token: 0x06000106 RID: 262 RVA: 0x00002C4C File Offset: 0x00000E4C
		public IniClass(string INIPath)
		{
			path = INIPath;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002C5B File Offset: 0x00000E5B
		public void IniWriteValue(string Section, string Key, string Value)
		{
			IniClass.WritePrivateProfileString(Section, Key, Value, path);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0001846C File Offset: 0x0001666C
		public string IniReadValue(string Section, string Key)
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			IniClass.GetPrivateProfileString(Section, Key, "", stringBuilder, 255, path);
			return stringBuilder.ToString();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000184A4 File Offset: 0x000166A4
		public void IniWriteValue(string Section, string Key, string Value, string DefValue)
		{
			Value = ((Value == null) ? "" : Value);
			if ((Value == "" || Value == null) && DefValue != "" && DefValue != null)
			{
				Value = DefValue;
			}
			IniClass.WritePrivateProfileString(Section, Key, Value, path);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000184F4 File Offset: 0x000166F4
		public string IniReadValue(string Section, string Key, string DefValue)
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			int privateProfileString = IniClass.GetPrivateProfileString(Section, Key, "", stringBuilder, 255, path);
			if (privateProfileString <= 0)
			{
				return DefValue;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0400019A RID: 410
		private string path;
	}
}
