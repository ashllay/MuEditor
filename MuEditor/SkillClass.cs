using System;
using System.IO;

namespace MuEditor
{
    public class SkillClass
    {
        public SkillClass(string FileName)
        {
            byte[] array = new byte[]
            {
                252,
                207,
                171
            };
            int num = 96;
            FileInfo fileInfo = new FileInfo(FileName);
            long num2 = (fileInfo.Length - 4L) / 96L;
            FileStream fileStream = new FileStream(FileName, FileMode.Open);
            int num3 = 0;
            while ((long)num3 < num2)
            {
                int num4 = 0;
                CMagicDamage cmagicDamage = new CMagicDamage();
                byte[] array2 = new byte[num];
                fileStream.Read(array2, 0, num);
                for (int i = 0; i < num; i++)
                {
                    byte[] array3 = array2;
                    int num5 = i;
                    array3[num5] ^= array[i % 3];
                }
                cmagicDamage.m_Number = num3;
                Array.Copy(array2, num4, cmagicDamage.Name, 0, 32);
                num4 += 32;
                cmagicDamage.ushort_0 = BitConverter.ToUInt16(array2, num4);
                num4 += 2;
                cmagicDamage.ushort_1 = BitConverter.ToUInt16(array2, num4);
                num4 += 2;
                cmagicDamage.ushort_2 = BitConverter.ToUInt16(array2, num4);
                num4 += 2;
                cmagicDamage.ushort_3 = BitConverter.ToUInt16(array2, num4);
                num4 += 2;
                cmagicDamage.uint_0 = BitConverter.ToUInt32(array2, num4);
                num4 += 4;
                cmagicDamage.Delay = BitConverter.ToUInt32(array2, num4);
                num4 += 4;
                cmagicDamage.Eng = BitConverter.ToUInt32(array2, num4);
                num4 += 4;
                cmagicDamage.Cha = BitConverter.ToUInt16(array2, num4);
                num4 += 2;
                cmagicDamage.byte_0 = array2[num4];
                num4++;
                cmagicDamage.SkilluseType = array2[num4];
                num4++;
                cmagicDamage.SkillBrand = BitConverter.ToInt32(array2, num4);
                num4 += 4;
                cmagicDamage.KillCout = array2[num4];
                num4++;
                cmagicDamage.iStatuNumber.stOne = array2[num4];
                num4++;
                cmagicDamage.iStatuNumber.stTwo = array2[num4];
                num4++;
                cmagicDamage.iStatuNumber.stThe = array2[num4];
                num4++;
                cmagicDamage.iClassNumber.WIZARD = array2[num4];
                num4++;
                cmagicDamage.iClassNumber.KNIGHT = array2[num4];
                num4++;
                cmagicDamage.iClassNumber.ELF = array2[num4];
                num4++;
                cmagicDamage.iClassNumber.MAGUMSA = array2[num4];
                num4++;
                cmagicDamage.iClassNumber.DARKLORD = array2[num4];
                num4++;
                cmagicDamage.iClassNumber.SUMMONER = array2[num4];
                num4++;
                cmagicDamage.iClassNumber.MONK = array2[num4];
                num4++;
                cmagicDamage.byte_1 = array2[num4];
                num4++;
                cmagicDamage.ushort_4 = BitConverter.ToUInt16(array2, num4);
                num4 += 2;
                cmagicDamage.ushort_5 = BitConverter.ToUInt16(array2, num4);
                num4 += 2;
                cmagicDamage.ushort_6 = BitConverter.ToUInt16(array2, num4);
                num4 += 2;
                cmagicDamage.ushort_7 = BitConverter.ToUInt16(array2, num4);
                num4 += 2;
                cmagicDamage.ushort_8 = BitConverter.ToUInt16(array2, num4);
                num4 += 2;
                cmagicDamage.ushort_9 = BitConverter.ToUInt16(array2, num4);
                num4 += 2;
                cmagicDamage.byte_2 = array2[num4];
                num4++;
                cmagicDamage.byte_3 = array2[num4];
                num4++;
                cmagicDamage.ushort_10 = BitConverter.ToUInt16(array2, num4);
                num4 += 2;
                cmagicDamage.byte_4 = array2[num4];
                num4++;
                cmagicDamage.byte_5 = array2[num4];
                num4++;
                cmagicDamage.byte_6 = array2[num4];
                num4++;
                cmagicDamage.byte_7 = array2[num4];
                num4++;
                cmagicDamage.byte_8 = array2[num4];
                num4++;
                cmagicDamage.byte_9 = array2[num4];
                num4++;
                cmagicDamage.UNK = BitConverter.ToUInt16(array2, num4);
                num4 += 2;
                this.cMagic[num3] = cmagicDamage;
                num3++;
            }
        }

        public CMagicDamage[] cMagic = new CMagicDamage[700];
    }
}
