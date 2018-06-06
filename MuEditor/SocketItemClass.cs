using System;
using System.IO;

namespace MuEditor
{
	// Token: 0x0200001F RID: 31
	public class SocketItemClass
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x0001ACCC File Offset: 0x00018ECC
		public SocketItemClass(string FileName)
		{
			byte[] array = new byte[]
			{
				252,
				207,
				171
			};
			int num = 108;
			FileInfo fileInfo = new FileInfo(FileName);
			long num2 = fileInfo.Length / 108L;
			FileStream fileStream = new FileStream(FileName, FileMode.Open);
			int num3 = 0;
			while ((long)num3 < num2)
			{
				int num4 = 0;
				ITEM_SOCKETITEM item_SOCKETITEM = new ITEM_SOCKETITEM();
				byte[] array2 = new byte[num];
				fileStream.Read(array2, 0, num);
				for (int i = 0; i < num; i++)
				{
					byte[] array3 = array2;
					int num5 = i;
					array3[num5] ^= array[i % 3];
				}
				item_SOCKETITEM.uint_0 = BitConverter.ToUInt32(array2, num4);
				num4 += 4;
				item_SOCKETITEM.uint_1 = BitConverter.ToUInt32(array2, num4);
				num4 += 4;
				item_SOCKETITEM.uint_2 = BitConverter.ToUInt32(array2, num4);
				num4 += 4;
				Array.Copy(array2, num4, item_SOCKETITEM.byte_0, 0, 64);
				num4 += 64;
				item_SOCKETITEM.uint_3 = BitConverter.ToUInt32(array2, num4);
				num4 += 4;
				item_SOCKETITEM.uint_4[0] = BitConverter.ToUInt32(array2, num4);
				num4 += 4;
				item_SOCKETITEM.uint_4[1] = BitConverter.ToUInt32(array2, num4);
				num4 += 4;
				item_SOCKETITEM.uint_4[2] = BitConverter.ToUInt32(array2, num4);
				num4 += 4;
				item_SOCKETITEM.uint_4[3] = BitConverter.ToUInt32(array2, num4);
				num4 += 4;
				item_SOCKETITEM.uint_4[4] = BitConverter.ToUInt32(array2, num4);
				num4 += 4;
				item_SOCKETITEM.byte_1 = array2[num4];
				num4++;
				item_SOCKETITEM.byte_2 = array2[num4];
				num4++;
				item_SOCKETITEM.byte_3 = array2[num4];
				num4++;
				item_SOCKETITEM.byte_4 = array2[num4];
				num4++;
				item_SOCKETITEM.byte_5 = array2[num4];
				num4++;
				item_SOCKETITEM.byte_6 = array2[num4];
				num4++;
				item_SOCKETITEM.NULL = BitConverter.ToUInt16(array2, num4);
				num4 += 2;
				cSocket[num3] = item_SOCKETITEM;
				num3++;
			}
		}

		// Token: 0x040001CC RID: 460
		public ITEM_SOCKETITEM[] cSocket = new ITEM_SOCKETITEM[150];
	}
}
