using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Management;
using System.Text;
using System.Web.Security;
using System.Windows.Forms;

namespace MuEditor
{
    public class Utils
    {
        public static int JPLevel
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["JPLevel"]);
            }
        }

        public static int JPExt
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["JPExt"]);
            }
        }

        public static bool JPJN
        {
            get
            {
                return ConfigurationManager.AppSettings["JPJN"] == "true";
            }
        }

        public static bool JPXY
        {
            get
            {
                return ConfigurationManager.AppSettings["JPXY"] == "true";
            }
        }

        public static bool JPZY1
        {
            get
            {
                return ConfigurationManager.AppSettings["JPZY1"] == "true";
            }
        }

        public static bool JPZY2
        {
            get
            {
                return ConfigurationManager.AppSettings["JPZY2"] == "true";
            }
        }

        public static bool JPZY3
        {
            get
            {
                return ConfigurationManager.AppSettings["JPZY3"] == "true";
            }
        }

        public static bool JPZY4
        {
            get
            {
                return ConfigurationManager.AppSettings["JPZY4"] == "true";
            }
        }

        public static bool JPZY5
        {
            get
            {
                return ConfigurationManager.AppSettings["JPZY5"] == "true";
            }
        }

        public static bool JPZY6
        {
            get
            {
                return ConfigurationManager.AppSettings["JPZY6"] == "true";
            }
        }

        public static int DJLevel
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["DJLevel"]);
            }
        }

        public static int DJExt
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["DJExt"]);
            }
        }

        public static bool DJJN
        {
            get
            {
                return ConfigurationManager.AppSettings["DJJN"] == "true";
            }
        }

        public static bool DJXY
        {
            get
            {
                return ConfigurationManager.AppSettings["DJXY"] == "true";
            }
        }

        public static bool DJZY1
        {
            get
            {
                return ConfigurationManager.AppSettings["DJZY1"] == "true";
            }
        }

        public static bool DJZY2
        {
            get
            {
                return ConfigurationManager.AppSettings["DJZY2"] == "true";
            }
        }

        public static bool DJZY3
        {
            get
            {
                return ConfigurationManager.AppSettings["DJZY3"] == "true";
            }
        }

        public static bool DJZY4
        {
            get
            {
                return ConfigurationManager.AppSettings["DJZY4"] == "true";
            }
        }

        public static bool DJZY5
        {
            get
            {
                return ConfigurationManager.AppSettings["DJZY5"] == "true";
            }
        }

        public static bool DJZY6
        {
            get
            {
                return ConfigurationManager.AppSettings["DJZY6"] == "true";
            }
        }

        public static int CJPLevel
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["CJPLevel"]);
            }
        }

        public static int CJPExt
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["CJPExt"]);
            }
        }

        public static int CJPSetVal
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["CJPSetVal"]);
            }
        }

        public static bool CJPXY
        {
            get
            {
                return ConfigurationManager.AppSettings["CJPXY"] == "true";
            }
        }

        public static bool CJPZY1
        {
            get
            {
                return ConfigurationManager.AppSettings["CJPZY1"] == "true";
            }
        }

        public static bool CJPZY2
        {
            get
            {
                return ConfigurationManager.AppSettings["CJPZY2"] == "true";
            }
        }

        public static bool CJPZY3
        {
            get
            {
                return ConfigurationManager.AppSettings["CJPZY3"] == "true";
            }
        }

        public static bool CJPZY4
        {
            get
            {
                return ConfigurationManager.AppSettings["CJPZY4"] == "true";
            }
        }

        public static bool CJPZY5
        {
            get
            {
                return ConfigurationManager.AppSettings["CJPZY5"] == "true";
            }
        }

        public static bool CJPZY6
        {
            get
            {
                return ConfigurationManager.AppSettings["CJPZY6"] == "true";
            }
        }

        public static int CDJLevel
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["CDJLevel"]);
            }
        }

        public static int CDJExt
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["CDJExt"]);
            }
        }

        public static int CDJSetVal
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["CDJSetVal"]);
            }
        }

        public static bool CDJXY
        {
            get
            {
                return ConfigurationManager.AppSettings["CDJXY"] == "true";
            }
        }

        public static bool CDJZY1
        {
            get
            {
                return ConfigurationManager.AppSettings["CDJZY1"] == "true";
            }
        }

        public static bool CDJZY2
        {
            get
            {
                return ConfigurationManager.AppSettings["CDJZY2"] == "true";
            }
        }

        public static bool CDJZY3
        {
            get
            {
                return ConfigurationManager.AppSettings["CDJZY3"] == "true";
            }
        }

        public static bool CDJZY4
        {
            get
            {
                return ConfigurationManager.AppSettings["CDJZY4"] == "true";
            }
        }

        public static bool CDJZY5
        {
            get
            {
                return ConfigurationManager.AppSettings["CDJZY5"] == "true";
            }
        }

        public static bool CDJZY6
        {
            get
            {
                return ConfigurationManager.AppSettings["CDJZY6"] == "true";
            }
        }

        public static string[] AccFieldNames
        {
            get
            {
                return ConfigurationManager.AppSettings["AccFieldNames"].Split(new char[]
                {
                    '|'
                });
            }
        }

        public static string[] AccFieldValues
        {
            get
            {
                return ConfigurationManager.AppSettings["AccFieldValues"].Split(new char[]
                {
                    '|'
                });
            }
        }

        public static string[] ChaFieldNames
        {
            get
            {
                return ConfigurationManager.AppSettings["ChaFieldNames"].Split(new char[]
                {
                    '|'
                });
            }
        }

        public static string[] ChaFieldValues
        {
            get
            {
                return ConfigurationManager.AppSettings["ChaFieldValues"].Split(new char[]
                {
                    '|'
                });
            }
        }

        public static string FilterSQL(string strSql)
        {
            return strSql.Trim().Replace("'", "''");
        }

        public static string GetID()
        {
            string[] array = Guid.NewGuid().ToString().Split(new char[]
            {
                '-'
            });
            return array[3] + array[4];
        }

        public static string EncodeEncrypt(string str)
        {
            str = FormsAuthentication.HashPasswordForStoringInConfigFile(str, "sha1");
            str = FormsAuthentication.HashPasswordForStoringInConfigFile(str, "md5");
            str = FormsAuthentication.HashPasswordForStoringInConfigFile(str, "sha1");
            str = FormsAuthentication.HashPasswordForStoringInConfigFile(str, "md5");
            str = FormsAuthentication.HashPasswordForStoringInConfigFile(str, "md5");
            str = FormsAuthentication.HashPasswordForStoringInConfigFile(str, "sha1");
            str = FormsAuthentication.HashPasswordForStoringInConfigFile(str, "sha1");
            return str;
        }

        public static string GetMachineID()
        {
            string result;
            try
            {
                SelectQuery query = new SelectQuery("SELECT * FROM Win32_BaseBoard");
                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator();
                enumerator.MoveNext();
                ManagementBaseObject managementBaseObject = enumerator.Current;
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(managementBaseObject.GetPropertyValue("SerialNumber").ToString());
                if (stringBuilder.ToString().Trim().Length < 5)
                {
                    ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
                    ManagementObjectCollection instances = managementClass.GetInstances();
                    foreach (ManagementBaseObject managementBaseObject2 in instances)
                    {
                        ManagementObject managementObject = (ManagementObject)managementBaseObject2;
                        if ((bool)managementObject["IPEnabled"])
                        {
                            stringBuilder.Append(managementObject["MacAddress"].ToString());
                        }
                        managementObject.Dispose();
                    }
                }
                result = "S7" + stringBuilder.ToString().Trim();
            }
            catch
            {
                result = "";
            }
            return result;
        }

        public static bool IsRight()
        {
            return true;
        }

        public static void InfoMessage(string msg)
        {
            MessageBox.Show(msg, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static void WarningMessage(string msg)
        {
            MessageBox.Show(msg, "系统错误消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void GetPlusType(ComboBox cboPlusType, int plusType)
        {
            cboPlusType.Items.Clear();
            if (plusType == 1)
            {
                foreach (string item in Utils.strPlusA)
                {
                    cboPlusType.Items.Add(item);
                }
                return;
            }
            if (plusType == 2)
            {
                foreach (string item2 in Utils.strPlusB)
                {
                    cboPlusType.Items.Add(item2);
                }
                return;
            }
            if (plusType == 3)
            {
                foreach (string item3 in Utils.strPlusC)
                {
                    cboPlusType.Items.Add(item3);
                }
                return;
            }
            cboPlusType.Items.Add(" ---无---");
            cboPlusType.SelectedIndex = 0;
        }

        public static string GetPlusStr(EquipItem item)
        {
            if (item.Type >= 0 && item.Type <= 5)
            {
                return Utils.strPlusA[item.PlusType];
            }
            if (item.Type >= 6 && item.Type <= 11)
            {
                return Utils.strPlusB[item.PlusType];
            }
            return Utils.GetBoolenStr(false);
        }

        public static bool GetJN(EquipItem item)
        {
            ushort skillType = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].SkillType;
            Trace.WriteLine("SkillType : " + skillType);
            return skillType != 0;
        }

        public static bool Get380(EquipItem item)
        {
            ushort nlvl = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].NLvl;
            Trace.WriteLine("NLvl : " + nlvl);
            return nlvl == 380;
        }

        public static bool GetQX(EquipItem item)
        {
            byte itemKindA = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindA;
            Trace.WriteLine("ItemKind A : " + itemKindA);
            byte itemKindB = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindB;
            Trace.WriteLine("ItemKind B : " + itemKindB);
            byte itemCategory = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemCategory;
            Trace.WriteLine("ItemCategory : " + itemCategory);
            return itemCategory == 2 || itemKindA == 8;
        }

        public static string GetEquipInfo(EquipItem item)
        {
            if (item == null)
            {
                return "物品信息读取失败！";
            }
            string text = item.Name;
            string str = "";
            string str2 = "";
            if (item.Is380)
            {
                str = "\r\n☆380属性：" + Utils.GetBoolenStr(true);
            }
            if (item.IsSet)
            {
                text += "〖套装〗";
            }
            if (!Utils.GetQX(item) && item.PlusType > 0 && item.PlusLevel > 0)
            {
                text += "〖强化属性〗";
                str2 = "\r\n★强化属性：" + Utils.GetPlusStr(item);
            }
            string text2 = string.Format("物品名称：{0}\r\n物品代码：{1}\r\n物品等级：+{2}\r\n物品持久：{3}{4}\r\n幸运：{5}\r\n技能：{6}\r\n", new object[]
            {
                text,
                item.ToString(),
                item.Level,
                item.Durability,
                str + str2,
                Utils.GetBoolenStr(item.XY),
                Utils.GetBoolenStr(item.JN)
            });
            text2 = text2 + "※卓越属性：" + Utils.GetZY(item) + "\r\n";
            text2 = text2 + "追加属性： 追" + item.Ext * 4;
            if (Utils.GetQX(item))
            {
                byte itemKindA = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindA;
                byte itemKindB = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemKindB;
                byte itemCategory = EquipEditor.xItem[(int)(item.Type * 512 + item.Code)].ItemCategory;
                if (itemKindA == 8)
                {
                    if (itemKindB == 0)
                    {
                        if (item.XQ1 == 255)
                        {
                            text2 += "\r\n※元素属性1：无属性";
                        }
                        else if (item.XQ1 == 0)
                        {
                            text2 += "\r\n※元素属性1：无属性";
                        }
                        if (item.XQ2 == 255)
                        {
                            text2 += "\r\n※元素属性2：无属性";
                        }
                        else if (item.XQ2 == 0)
                        {
                            text2 += "\r\n※元素属性2：无属性";
                        }
                        if (item.XQ3 == 255)
                        {
                            text2 += "\r\n※元素属性3：无属性";
                        }
                        else if (item.XQ3 == 0)
                        {
                            text2 += "\r\n※元素属性3：无属性";
                        }
                        if (item.XQ4 == 255)
                        {
                            text2 += "\r\n※元素属性4：无属性";
                        }
                        else if (item.XQ4 == 0)
                        {
                            text2 += "\r\n※元素属性4：无属性";
                        }
                        if (item.XQ5 == 255)
                        {
                            text2 += "\r\n※元素属性5：无属性";
                        }
                        else if (item.XQ5 == 0)
                        {
                            text2 += "\r\n※元素属性5：无属性";
                        }
                    }
                    else if (itemKindB == 43)
                    {
                        if (item.XQ1 == 255)
                        {
                            text2 += "\r\n※元素属性1：未开孔";
                        }
                        else if (item.XQ1 == 254)
                        {
                            text2 += "\r\n※元素属性1：愤怒的元素之魂";
                        }
                        else
                        {
                            text2 += "\r\n※元素属性1：愤怒的元素之魂(镶嵌)";
                        }
                        if (item.XQ2 == 255)
                        {
                            text2 += "\r\n※元素属性2：未开孔";
                        }
                        else if (item.XQ2 == 254)
                        {
                            text2 += "\r\n※元素属性2：庇护的元素之魂";
                        }
                        else
                        {
                            text2 += "\r\n※元素属性2：庇护的元素之魂(镶嵌)";
                        }
                        if (item.XQ3 == 255)
                        {
                            text2 += "\r\n※元素属性3：未开孔";
                        }
                        else if (item.XQ3 == 254)
                        {
                            text2 += "\r\n※元素属性3：高贵的元素之魂";
                        }
                        else
                        {
                            text2 += "\r\n※元素属性3：高贵的元素之魂(镶嵌)";
                        }
                        if (item.XQ4 == 255)
                        {
                            text2 += "\r\n※元素属性4：未开孔";
                        }
                        else if (item.XQ4 == 254)
                        {
                            text2 += "\r\n※元素属性4：神圣的元素之魂";
                        }
                        else
                        {
                            text2 += "\r\n※元素属性4：神圣的元素之魂(镶嵌)";
                        }
                        if (item.XQ5 == 255)
                        {
                            text2 += "\r\n※元素属性5：未开孔";
                        }
                        else if (item.XQ5 == 254)
                        {
                            text2 += "\r\n※元素属性5：狂喜的元素之魂";
                        }
                        else
                        {
                            text2 += "\r\n※元素属性5：狂喜的元素之魂(镶嵌)";
                        }
                    }
                    else if (itemKindB == 44)
                    {
                        if (item.XQ1 == 255)
                        {
                            text2 += "\r\n※元素属性1：无属性";
                        }
                        else if (item.XQ1 == 17)
                        {
                            text2 += "\r\n※元素属性1：1阶属性 +1";
                        }
                        else if (item.XQ1 == 33)
                        {
                            text2 += "\r\n※元素属性1：1阶属性 +2";
                        }
                        else if (item.XQ1 == 49)
                        {
                            text2 += "\r\n※元素属性1：1阶属性 +3";
                        }
                        else if (item.XQ1 == 65)
                        {
                            text2 += "\r\n※元素属性1：1阶属性 +4";
                        }
                        else if (item.XQ1 == 81)
                        {
                            text2 += "\r\n※元素属性1：1阶属性 +5";
                        }
                        else if (item.XQ1 == 97)
                        {
                            text2 += "\r\n※元素属性1：1阶属性 +6";
                        }
                        else if (item.XQ1 == 113)
                        {
                            text2 += "\r\n※元素属性1：1阶属性 +7";
                        }
                        else if (item.XQ1 == 129)
                        {
                            text2 += "\r\n※元素属性1：1阶属性 +8";
                        }
                        else if (item.XQ1 == 145)
                        {
                            text2 += "\r\n※元素属性1：1阶属性 +9";
                        }
                        else
                        {
                            text2 += "\r\n※元素属性1：1阶属性 +10";
                        }
                        if (item.XQ2 == 255)
                        {
                            text2 += "\r\n※元素属性2：无属性";
                        }
                        else if (item.XQ2 == 17)
                        {
                            text2 += "\r\n※元素属性2：2阶属性 +1";
                        }
                        else if (item.XQ2 == 33)
                        {
                            text2 += "\r\n※元素属性2：2阶属性 +2";
                        }
                        else if (item.XQ2 == 49)
                        {
                            text2 += "\r\n※元素属性2：2阶属性 +3";
                        }
                        else if (item.XQ2 == 65)
                        {
                            text2 += "\r\n※元素属性2：2阶属性 +4";
                        }
                        else if (item.XQ2 == 81)
                        {
                            text2 += "\r\n※元素属性2：2阶属性 +5";
                        }
                        else if (item.XQ2 == 97)
                        {
                            text2 += "\r\n※元素属性2：2阶属性 +6";
                        }
                        else if (item.XQ2 == 113)
                        {
                            text2 += "\r\n※元素属性2：2阶属性 +7";
                        }
                        else if (item.XQ2 == 129)
                        {
                            text2 += "\r\n※元素属性2：2阶属性 +8";
                        }
                        else if (item.XQ2 == 145)
                        {
                            text2 += "\r\n※元素属性2：2阶属性 +9";
                        }
                        else
                        {
                            text2 += "\r\n※元素属性2：2阶属性 +10";
                        }
                        if (item.XQ3 == 255)
                        {
                            text2 += "\r\n※元素属性3：无属性";
                        }
                        else if (item.XQ3 == 17)
                        {
                            text2 += "\r\n※元素属性3：3阶属性 +1";
                        }
                        else if (item.XQ3 == 33)
                        {
                            text2 += "\r\n※元素属性3：3阶属性 +2";
                        }
                        else if (item.XQ3 == 49)
                        {
                            text2 += "\r\n※元素属性3：3阶属性 +3";
                        }
                        else if (item.XQ3 == 65)
                        {
                            text2 += "\r\n※元素属性3：3阶属性 +4";
                        }
                        else if (item.XQ3 == 81)
                        {
                            text2 += "\r\n※元素属性3：3阶属性 +5";
                        }
                        else if (item.XQ3 == 97)
                        {
                            text2 += "\r\n※元素属性3：3阶属性 +6";
                        }
                        else if (item.XQ3 == 113)
                        {
                            text2 += "\r\n※元素属性3：3阶属性 +7";
                        }
                        else if (item.XQ3 == 129)
                        {
                            text2 += "\r\n※元素属性3：3阶属性 +8";
                        }
                        else if (item.XQ3 == 145)
                        {
                            text2 += "\r\n※元素属性3：3阶属性 +9";
                        }
                        else
                        {
                            text2 += "\r\n※元素属性3：3阶属性 +10";
                        }
                        if (item.XQ4 == 255)
                        {
                            text2 += "\r\n※元素属性4：无属性";
                        }
                        else if (item.XQ4 == 17)
                        {
                            text2 += "\r\n※元素属性4：4阶属性 +1";
                        }
                        else if (item.XQ4 == 33)
                        {
                            text2 += "\r\n※元素属性4：4阶属性 +2";
                        }
                        else if (item.XQ4 == 49)
                        {
                            text2 += "\r\n※元素属性4：4阶属性 +3";
                        }
                        else if (item.XQ4 == 65)
                        {
                            text2 += "\r\n※元素属性4：4阶属性 +4";
                        }
                        else if (item.XQ4 == 81)
                        {
                            text2 += "\r\n※元素属性4：4阶属性 +5";
                        }
                        else if (item.XQ4 == 97)
                        {
                            text2 += "\r\n※元素属性4：4阶属性 +6";
                        }
                        else if (item.XQ4 == 113)
                        {
                            text2 += "\r\n※元素属性4：4阶属性 +7";
                        }
                        else if (item.XQ4 == 129)
                        {
                            text2 += "\r\n※元素属性4：4阶属性 +8";
                        }
                        else if (item.XQ4 == 145)
                        {
                            text2 += "\r\n※元素属性4：4阶属性 +9";
                        }
                        else
                        {
                            text2 += "\r\n※元素属性4：4阶属性 +10";
                        }
                        if (item.XQ5 == 255)
                        {
                            text2 += "\r\n※元素属性5：无属性";
                        }
                        else if (item.XQ5 == 17)
                        {
                            text2 += "\r\n※元素属性5：5阶属性 +1";
                        }
                        else if (item.XQ5 == 33)
                        {
                            text2 += "\r\n※元素属性5：5阶属性 +2";
                        }
                        else if (item.XQ5 == 49)
                        {
                            text2 += "\r\n※元素属性5：5阶属性 +3";
                        }
                        else if (item.XQ5 == 65)
                        {
                            text2 += "\r\n※元素属性5：5阶属性 +4";
                        }
                        else if (item.XQ5 == 81)
                        {
                            text2 += "\r\n※元素属性5：5阶属性 +5";
                        }
                        else if (item.XQ5 == 97)
                        {
                            text2 += "\r\n※元素属性5：5阶属性 +6";
                        }
                        else if (item.XQ5 == 113)
                        {
                            text2 += "\r\n※元素属性5：5阶属性 +7";
                        }
                        else if (item.XQ5 == 129)
                        {
                            text2 += "\r\n※元素属性5：5阶属性 +8";
                        }
                        else if (item.XQ5 == 145)
                        {
                            text2 += "\r\n※元素属性5：5阶属性 +9";
                        }
                        else
                        {
                            text2 += "\r\n※元素属性5：5阶属性 +10";
                        }
                    }
                    if (item.YG >= 0 && (int)(item.YG - 17) < Utils.YSS.Length)
                    {
                        text2 = text2 + "\r\n※元素属性：" + Utils.YSS[(int)(item.YG - 17)];
                    }
                    else
                    {
                        text2 = text2 + "\r\n※元素属性：" + Utils.YSS[0];
                    }
                }
                else
                {
                    if (item.XQ1 == 255)
                    {
                        text2 += "\r\n※镶嵌属性1：未开孔";
                    }
                    else if (item.XQ1 == 254)
                    {
                        text2 += "\r\n※镶嵌属性1：无属性";
                    }
                    else
                    {
                        int num = (int)(item.XQ1 % 50);
                        int num2 = ((int)item.XQ1 - num) / 50;
                        string text3 = text2;
                        text2 = string.Concat(new string[]
                        {
                            text3,
                            "\r\n※镶嵌属性1：",
                            frmMain.ByteToString(EquipEditor.xSocket[num].byte_0, 64),
                            " +",
                            EquipEditor.xSocket[num].uint_4[num2].ToString()
                        });
                    }
                    if (item.XQ2 == 255)
                    {
                        text2 += "\r\n※镶嵌属性2：未开孔";
                    }
                    else if (item.XQ2 == 254)
                    {
                        text2 += "\r\n※镶嵌属性2：无属性";
                    }
                    else
                    {
                        int num3 = (int)(item.XQ2 % 50);
                        int num4 = ((int)item.XQ2 - num3) / 50;
                        string text4 = text2;
                        text2 = string.Concat(new string[]
                        {
                            text4,
                            "\r\n※镶嵌属性2：",
                            frmMain.ByteToString(EquipEditor.xSocket[num3].byte_0, 64),
                            " +",
                            EquipEditor.xSocket[num3].uint_4[num4].ToString()
                        });
                    }
                    if (item.XQ3 == 255)
                    {
                        text2 += "\r\n※镶嵌属性3：未开孔";
                    }
                    else if (item.XQ3 == 254)
                    {
                        text2 += "\r\n※镶嵌属性3：无属性";
                    }
                    else
                    {
                        int num5 = (int)(item.XQ3 % 50);
                        int num6 = ((int)item.XQ3 - num5) / 50;
                        string text5 = text2;
                        text2 = string.Concat(new string[]
                        {
                            text5,
                            "\r\n※镶嵌属性3：",
                            frmMain.ByteToString(EquipEditor.xSocket[num5].byte_0, 64),
                            " +",
                            EquipEditor.xSocket[num5].uint_4[num6].ToString()
                        });
                    }
                    if (item.XQ4 == 255)
                    {
                        text2 += "\r\n※镶嵌属性4：未开孔";
                    }
                    else if (item.XQ4 == 254)
                    {
                        text2 += "\r\n※镶嵌属性4：无属性";
                    }
                    else
                    {
                        int num7 = (int)(item.XQ4 % 50);
                        int num8 = ((int)item.XQ4 - num7) / 50;
                        string text6 = text2;
                        text2 = string.Concat(new string[]
                        {
                            text6,
                            "\r\n※镶嵌属性4：",
                            frmMain.ByteToString(EquipEditor.xSocket[num7].byte_0, 64),
                            " +",
                            EquipEditor.xSocket[num7].uint_4[num8].ToString()
                        });
                    }
                    if (item.XQ5 == 255)
                    {
                        text2 += "\r\n※镶嵌属性5：未开孔";
                    }
                    else if (item.XQ5 == 254)
                    {
                        text2 += "\r\n※镶嵌属性5：无属性";
                    }
                    else
                    {
                        int num9 = (int)(item.XQ5 % 50);
                        int num10 = ((int)item.XQ5 - num9) / 50;
                        string text7 = text2;
                        text2 = string.Concat(new string[]
                        {
                            text7,
                            "\r\n※镶嵌属性5：",
                            frmMain.ByteToString(EquipEditor.xSocket[num9].byte_0, 64),
                            " +",
                            EquipEditor.xSocket[num9].uint_4[num10].ToString()
                        });
                    }
                    if (item.YG >= 0 && (int)item.YG < Utils.YGS.Length - 1)
                    {
                        text2 = text2 + "\r\n※荧光属性：" + Utils.YGS[(int)(item.YG + 1)];
                    }
                    else
                    {
                        text2 = text2 + "\r\n※荧光属性：" + Utils.YGS[0];
                    }
                }
            }
            return text2 + string.Format("\r\n物品编号：{0} 【{1}】", item.SN, Utils.GetSNStr(item.SN));
        }

        public static string GetBoolenStr(bool val)
        {
            if (!val)
            {
                return "×";
            }
            return "√";
        }

        public static string GetSNStr(int sn)
        {
            if (sn < 0)
            {
                return "GM物品";
            }
            if (sn != 0)
            {
                return "正常物品";
            }
            return "商店物品";
        }

        public static SKILL_SQL_GS SKILL_SQL2GS(byte[] szSQLSKILL)
        {
            int num = (int)szSQLSKILL[0];
            bool flag = (szSQLSKILL[1] & 7) != 0;
            byte skillLv = 0;
            if (flag)
            {
                skillLv = (byte)(szSQLSKILL[1] / 8);
                num = num * (int)(szSQLSKILL[1] & 7) + (int)szSQLSKILL[2];
            }
            return new SKILL_SQL_GS
            {
                SKillLv = skillLv,
                GSSkillID = num
            };
        }

        public static string SKILL_GS2SQL(SKILL_SQL_GS ssg)
        {
            byte[] array = new byte[3];
            byte[] array2 = array;
            int gsskillID = ssg.GSSkillID;
            int num = gsskillID;
            byte skillLv = ssg.SKillLv;
            int num2 = 0;
            int num3;
            if (gsskillID > 765)
            {
                num3 = 3;
                num = 255;
                num2 = gsskillID - 765;
            }
            else if (gsskillID > 510)
            {
                num3 = 2;
                num = 255;
                num2 = gsskillID - 510;
            }
            else if (gsskillID > 255)
            {
                num3 = 1;
                num = 255;
                num2 = gsskillID - 255;
            }
            else
            {
                num3 = 0;
            }
            array2[0] = (byte)num;
            array2[1] = (byte)((int)(skillLv * 8) | (num3 & 7));
            array2[2] = (byte)num2;
            return array2[0].ToString("X2") + array2[1].ToString("X2") + array2[2].ToString("X2");
        }

        public static string HexJN(byte[] bytes)
        {
            return bytes[0].ToString("X2") + bytes[1].ToString("X2") + bytes[2].ToString("X2");
        }

        public static string GetZY(EquipItem item)
        {
            string text = "";
            string str = "+魔法值/8|金钱+40%";
            string str2 = "+生命值/8|防+10%";
            string str3 = "+速度+7|反伤";
            string str4 = "+2%攻击|减伤";
            string str5 = "等级/20攻击|魔+4%";
            string str6 = "卓越一击|生+4%";
            switch (item.Type)
            {
                case 12:
                    if ((item.Code >= 3 && item.Code <= 6) || item.Code == 42)
                    {
                        str = "加生";
                        str2 = "加魔";
                        str3 = "无视";
                        str4 = "技能最大值";
                        str5 = "加速";
                        str6 = "追/回";
                    }
                    else if ((item.Code >= 36 && item.Code <= 40) || item.Code == 43)
                    {
                        str = "无视";
                        str2 = "还原攻击";
                        str3 = "恢复生命";
                        str4 = "恢复魔法";
                        str5 = "追/回";
                        str6 = "追/回";
                    }
                    break;
                case 13:
                    {
                        ushort code = item.Code;
                        if (code != 30)
                        {
                            if (code == 37)
                            {
                                str = "黑狼";
                                str2 = "青狼";
                                str3 = "金狼";
                            }
                        }
                        else
                        {
                            str = "加生";
                            str2 = "加魔";
                            str3 = "无视";
                            str4 = "加声望";
                        }
                        break;
                    }
            }
            text += (item.ZY1 ? ("\r\n\t" + str) : "");
            text += (item.ZY2 ? ("\r\n\t" + str2) : "");
            text += (item.ZY3 ? ("\r\n\t" + str3) : "");
            text += (item.ZY4 ? ("\r\n\t" + str4) : "");
            text += (item.ZY5 ? ("\r\n\t" + str5) : "");
            text += (item.ZY6 ? ("\r\n\t" + str6) : "");
            if (!(text == ""))
            {
                return text;
            }
            return Utils.GetBoolenStr(false);
        }

        public static byte[] StringToBytes(string strCode)
        {
            strCode = strCode.Replace("0x", "");
            byte[] array = new byte[strCode.Length / 2];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToByte(strCode.Substring(i * 2, 2), 16);
            }
            return array;
        }

        public static List<SKILL_SQL_GS> lstSSG = new List<SKILL_SQL_GS>(150);

        public static string ErrorMsg = "未授权";

        public static string[] YGS = new string[]
        {
            "无属性",
            "武器攻击力 + 11",
            "武器技能攻击力 + 11",
            "法杖攻击力/魔法攻击力 + 5",
            "法杖技能攻击力 + 11",
            "装备防御力 + 24",
            "装备最大生命值 + 29"
        };

        public static string[] YSS = new string[]
        {
            "火属性",
            "水属性",
            "土属性",
            "风属性",
            "暗属性"
        };

        public static string[] strPlusA = new string[]
        {
            " ---无--- ",
            "最小攻击力 提升",
            "最大攻击力 提升",
            "减少所需力量",
            "减少所需敏捷",
            "最小/最大攻击力 提升",
            "加重攻击力 提升",
            "技能攻击力 提升",
            "攻击成功率 提升(PVP)",
            "SD减少率 提升",
            "攻击时无视 SD 几率 提升"
        };

        public static string[] strPlusB = new string[]
        {
            " ---无--- ",
            "防御力 提升",
            "最大 AG 提升",
            "最大 HP 提升",
            "生命值自动增加量 提升",
            "魔法值自动增加量 提升",
            "防御成功率 提升(PVP)",
            "伤害减少量 提升",
            "SD 比率 提升"
        };

        public static string[] strPlusC = new string[]
        {
            " ---无--- ",
            "魔法 提升",
            "所需力量 减少",
            "所需敏捷 减少",
            "技能攻击力 提升",
            "加重攻击力 提升",
            "SD 减少率 提升",
            "攻击成功率 提升(PVP)",
            "攻击时无视 SD 几率 提升"
        };

        public static string[] SearchNames = "大于|等于|小于|不等于|包含".Split(new char[]
        {
            '|'
        });

        public static string[] SearchValues = ">|=|<|<>|like".Split(new char[]
        {
            '|'
        });

        public static int SN = 0;

        public static List<string> ListWareHouse = new List<string>();

        public static List<string> ListPackage = new List<string>();
    }
}
