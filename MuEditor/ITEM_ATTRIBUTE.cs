using System;

namespace MuEditor
{
    public class ITEM_ATTRIBUTE
    {
        public int GID;

        public ushort Group;

        public ushort Index;

        public byte[] Model_Folder = new byte[260];

        public byte[] Model_Name = new byte[260];

        public byte[] Name = new byte[30];

        public byte ItemKindA;

        public byte ItemKindB;

        public byte ItemCategory;

        public bool TwoHand;

        public ushort Level;

        public ushort ItemSlot;

        public ushort SkillType;

        public byte X;

        public byte Y;

        public ushort DamMin;

        public ushort DamMax;

        public ushort MagDef;

        public int Defence;

        public ushort AtkSpeed;

        public ushort WalkSpeed;

        public ushort Dur;

        public ushort MagicDur;

        public ushort MagicPW;

        public ushort Str;

        public ushort Dex;

        public ushort Eng;

        public ushort Hea;

        public ushort Cha;

        public ushort NLvl;

        public ushort Value;

        public uint Zen;

        public byte byte_0;

        public ClassNumber iClassNumber = new ClassNumber();

        public Attribute iAttribute = new Attribute();

        public byte byte_1;

        public byte byte_2;

        public byte byte_3;

        public byte byte_4;

        public byte UNK_01;

        public byte UNK_02;

        public byte UNK_03;

        public byte UNK_04;

        public byte UNK_05;
    }
}
