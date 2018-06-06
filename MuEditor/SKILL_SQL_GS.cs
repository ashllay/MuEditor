using System;

namespace MuEditor
{
    public class SKILL_SQL_GS
    {
        public byte SKillLv
        {
            get
            {
                return this.skillLv;
            }
            set
            {
                this.skillLv = value;
            }
        }

        public int GSSkillID
        {
            get
            {
                return this.gsSkillID;
            }
            set
            {
                this.gsSkillID = value;
            }
        }

        private byte skillLv;

        private int gsSkillID;
    }
}
