using System;
using System.IO;

namespace MuEditor
{
	// Token: 0x02000006 RID: 6
	public class ItemClass
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00005BC8 File Offset: 0x00003DC8
		public ItemClass(string FileName)
		{
			byte[] array = new byte[]
			{
				252,
				207,
				171
			};
			int num = 628;
			FileStream fileStream = new FileStream(FileName, FileMode.Open);
			byte[] array2 = new byte[4];
			fileStream.Read(array2, 0, 4);
			int num2 = BitConverter.ToInt32(array2, 0);
			for (int i = 0; i < num2; i++)
			{
				int num3 = 0;
				ITEM_ATTRIBUTE item_ATTRIBUTE = new ITEM_ATTRIBUTE();
				array2 = new byte[num];
				fileStream.Read(array2, 0, num);
				for (int j = 0; j < num; j++)
				{
					byte[] array3 = array2;
					int num4 = j;
					array3[num4] ^= array[j % 3];
				}
				item_ATTRIBUTE.GID = BitConverter.ToInt32(array2, num3);
				num3 += 4;
				item_ATTRIBUTE.Group = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.Index = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				Array.Copy(array2, num3, item_ATTRIBUTE.Model_Folder, 0, 260);
				num3 += 260;
				Array.Copy(array2, num3, item_ATTRIBUTE.Model_Name, 0, 260);
				num3 += 260;
				Array.Copy(array2, num3, item_ATTRIBUTE.Name, 0, 30);
				num3 += 30;
				item_ATTRIBUTE.ItemKindA = array2[num3];
				num3++;
				item_ATTRIBUTE.ItemKindB = array2[num3];
				num3++;
				item_ATTRIBUTE.ItemCategory = array2[num3];
				num3++;
				item_ATTRIBUTE.TwoHand = BitConverter.ToBoolean(array2, num3);
				num3++;
				item_ATTRIBUTE.Level = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.ItemSlot = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.SkillType = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.X = array2[num3];
				num3++;
				item_ATTRIBUTE.Y = array2[num3];
				num3++;
				item_ATTRIBUTE.DamMin = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.DamMax = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.MagDef = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.Defence = BitConverter.ToInt32(array2, num3);
				num3 += 4;
				item_ATTRIBUTE.AtkSpeed = (ushort)array2[num3];
				num3++;
				item_ATTRIBUTE.WalkSpeed = (ushort)array2[num3];
				num3++;
				item_ATTRIBUTE.Dur = (ushort)array2[num3];
				num3++;
				item_ATTRIBUTE.MagicDur = (ushort)array2[num3];
				num3++;
				item_ATTRIBUTE.MagicPW = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.Str = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.Dex = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.Eng = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.Hea = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.Cha = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.NLvl = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.Value = BitConverter.ToUInt16(array2, num3);
				num3 += 2;
				item_ATTRIBUTE.Zen = BitConverter.ToUInt32(array2, num3);
				num3 += 4;
				item_ATTRIBUTE.byte_0 = array2[num3];
				num3++;
				item_ATTRIBUTE.iClassNumber.WIZARD = array2[num3];
				num3++;
				item_ATTRIBUTE.iClassNumber.KNIGHT = array2[num3];
				num3++;
				item_ATTRIBUTE.iClassNumber.ELF = array2[num3];
				num3++;
				item_ATTRIBUTE.iClassNumber.MAGUMSA = array2[num3];
				num3++;
				item_ATTRIBUTE.iClassNumber.DARKLORD = array2[num3];
				num3++;
				item_ATTRIBUTE.iClassNumber.SUMMONER = array2[num3];
				num3++;
				item_ATTRIBUTE.iClassNumber.MONK = array2[num3];
				num3++;
				item_ATTRIBUTE.iAttribute.ICE = array2[num3];
				num3++;
				item_ATTRIBUTE.iAttribute.POISON = array2[num3];
				num3++;
				item_ATTRIBUTE.iAttribute.LIGHTNING = array2[num3];
				num3++;
				item_ATTRIBUTE.iAttribute.FIRE = array2[num3];
				num3++;
				item_ATTRIBUTE.iAttribute.EARTH = array2[num3];
				num3++;
				item_ATTRIBUTE.iAttribute.WIND = array2[num3];
				num3++;
				item_ATTRIBUTE.iAttribute.WATER = array2[num3];
				num3++;
				ItemAttribute[item_ATTRIBUTE.GID] = item_ATTRIBUTE;
			}
		}

		// Token: 0x0400001F RID: 31
		public ITEM_ATTRIBUTE[] ItemAttribute = new ITEM_ATTRIBUTE[8192];
	}
}
