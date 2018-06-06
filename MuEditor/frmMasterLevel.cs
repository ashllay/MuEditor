using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MuEditor
{
	// Token: 0x02000009 RID: 9
	public partial class frmMasterLevel : frmBase
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00007510 File Offset: 0x00005710
		public frmMasterLevel(string charName)
		{
			InitializeComponent();
			charName = charName;
			string text = string.Format("SELECT T_MasterLevelSystem.CHAR_NAME, T_MasterLevelSystem.MASTER_LEVEL, T_MasterLevelSystem.ML_EXP, T_MasterLevelSystem.ML_NEXTEXP, T_MasterLevelSystem.ML_POINT, Character.Class FROM Character INNER JOIN T_MasterLevelSystem ON Character.Name = T_MasterLevelSystem.CHAR_NAME COLLATE Chinese_PRC_CS_AS_KS_WS WHERE (T_MasterLevelSystem.CHAR_NAME = '{0}')", charName);
			try
			{
				OleDbCommand oleDbCommand = new OleDbCommand(text, frmBase.Mu_Conn);
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				if (oleDbDataReader.Read())
				{
					txtCharacter.Text = Convert.ToString(oleDbDataReader.GetValue(0));
					txtLevel.Text = oleDbDataReader.GetInt16(1).ToString();
					txtEXP.Text = oleDbDataReader.GetInt64(2).ToString();
					txtNextEXP.Text = oleDbDataReader.GetInt64(3).ToString();
					txtPoint.Text = oleDbDataReader.GetInt16(4).ToString();
					if (oleDbDataReader.GetValue(5) != DBNull.Value)
					{
						classID = (int)oleDbDataReader.GetByte(5);
					}
				}
				else
				{
					Utils.WarningMessage("对不起，没有找到角色[" + charName + "]对应的帐号信息！");
					btnOK.Enabled = false;
				}
				oleDbDataReader.Close();
			}
			catch (Exception ex)
			{
				Utils.WarningMessage(string.Concat(new string[]
				{
					"SQL：",
					text,
					"\nError:",
					ex.Message,
					"\nSource:",
					ex.Source,
					"\nTrace:",
					ex.StackTrace
				}));
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000769C File Offset: 0x0000589C
		private void btnOK_Click(object sender, EventArgs e)
		{
			string text = "";
			try
			{
				Cursor = Cursors.WaitCursor;
				short num = Convert.ToInt16(txtLevel.Text.Replace(" ", ""));
				long num2 = Convert.ToInt64(txtEXP.Text.Replace(" ", ""));
				long num3 = Convert.ToInt64(txtNextEXP.Text.Replace(" ", ""));
				short num4 = Convert.ToInt16(txtPoint.Text.Replace(" ", ""));
				text = string.Format("UPDATE T_MasterLevelSystem SET MASTER_LEVEL = {0}, ML_EXP = {1}, ML_NEXTEXP = {2}, ML_POINT = {3} WHERE (CHAR_NAME = '{4}')", new object[]
				{
					num,
					num2,
					num3,
					num4,
					charName
				});
                frmBase.Mu_ExecuteSQL(text);
				if (rbAll.Checked)
				{
                    frmBase.Mu_ExecuteSQL(getJNSQL(true));
				}
				else if (rbClear.Checked)
				{
                    frmBase.Mu_ExecuteSQL(getJNSQL(false));
				}
				Utils.InfoMessage("操作成功！");
			}
			catch (Exception ex)
			{
				Utils.WarningMessage(string.Concat(new string[]
				{
					"SQL：",
					text,
					"\nError:",
					ex.Message,
					"\nSource:",
					ex.Source,
					"\nTrace:",
					ex.StackTrace
				}));
			}
			Cursor = Cursors.Default;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00007858 File Offset: 0x00005A58
		private string getJNSQL(bool isAll)
		{
			string format = "UPDATE Character SET MagicList = {0} WHERE (Name = '" + charName + "')";
			StringBuilder stringBuilder = new StringBuilder("0x");
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < Utils.lstSSG.Count; i++)
			{
				SKILL_SQL_GS skill_SQL_GS = Utils.lstSSG[i];
				if (skill_SQL_GS.GSSkillID > 0 && skill_SQL_GS.GSSkillID < 255)
				{
					stringBuilder.Append(Utils.SKILL_GS2SQL(skill_SQL_GS));
					num++;
				}
			}
			if (isAll)
			{
				num2 = 26;
				int num3 = classID;
				if (num3 <= 35)
				{
					switch (num3)
					{
					case 0:
					case 1:
					case 3:
						stringBuilder.Append("FF293BFF294AFF294FFF2954FF2963FF2986FF298BFF2931FF29BDFF2968FF296DFF29C2FF29C7FF2936FF29B8FF2977FF2972FF297CFF299FFF29A4FF2940FF2945FF2959FF295EFF2981FF299A");
						goto IL_188;
					case 2:
						break;
					default:
						switch (num3)
						{
						case 16:
						case 17:
						case 19:
							stringBuilder.Append("FF293BFF294AFF294FFF2954FF2963FF2986FF298BFF2931FF29CCFF2968FF296DFF29D1FF29D6FF2936FF29DBFF2977FF2972FF297CFF2990FF2995FF2940FF2945FF2959FF295EFF2981FF299A");
							goto IL_188;
						case 18:
							break;
						default:
							switch (num3)
							{
							case 32:
							case 33:
							case 35:
								stringBuilder.Append("FF293BFF294AFF294FFF2954FF2963FF2986FF298BFF2931FF29E0FF2968FF296DFF29E5FF29EAFF2936FF29EFFF2977FF2972FF297CFF2990FF2995FF2940FF2945FF2959FF295EFF2981FF299A");
								goto IL_188;
							}
							break;
						}
						break;
					}
				}
				else
				{
					switch (num3)
					{
					case 48:
					case 50:
						stringBuilder.Append("FF2A18FF293BFF294AFF294FFF2954FF2963FF2986FF298BFF2931FF29F4FF2968FF296DFF29F9FF29FEFF2936FF2A04FF2977FF2972FF297CFF29AEFF2940FF2945FF2959FF295EFF2981FF299A");
						goto IL_188;
					case 49:
						break;
					default:
						switch (num3)
						{
						case 64:
						case 66:
							stringBuilder.Append("FF293BFF294AFF294FFF2954FF2963FF2986FF298BFF2931FF2A0EFF2968FF296DFF2A13FF2936FF2A09FF2977FF2972FF297CFF2990FF2995FF2940FF2945FF2959FF295EFF2981FF29A9FF299A");
							goto IL_188;
						case 65:
							break;
						default:
							switch (num3)
							{
							case 80:
							case 81:
							case 83:
								num2 += 3;
								stringBuilder.Append("FF2A2CFF2A22FF2A1DFF2A27FF293BFF294AFF294FFF2954FF2963FF2986FF298BFF2931FF2A0EFF2968FF296DFF2A13FF2936FF2A09FF2977FF2972FF297CFF2940FF2945FF2959FF295EFF2981FF299AFF299FFF29A4");
								goto IL_188;
							}
							break;
						}
						break;
					}
				}
				num2 = 0;
			}
			IL_188:
			for (int j = num2 + num; j < 150; j++)
			{
				stringBuilder.Append("FF0000");
			}
			return string.Format(format, stringBuilder.ToString());
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002238 File Offset: 0x00000438
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00007A1C File Offset: 0x00005C1C
		private void txtLevel_TextChanged(object sender, EventArgs e)
		{
			int num = int.Parse(txtLevel.Text);
			if (num > 400)
			{
				Utils.WarningMessage("不能大于400！");
			}
		}

		// Token: 0x0400006D RID: 109
		private string charName = "";

		// Token: 0x0400006E RID: 110
		private int classID;
	}
}
