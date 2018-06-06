using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MuEditor.Properties;

namespace MuEditor
{
    public class EquipImageCache
    {
        private EquipImageCache()
        {
        }

        public static EquipImageCache Instance
        {
            get
            {
                return EquipImageCache.Nested.instance;
            }
        }

        public EquipItem getItem(string name)
        {
            EquipItem equipItem = null;
            if ((equipItem = (EquipItem)this.cache[name]) == null)
            {
                lock (this.cache)
                {
                    if ((equipItem = (EquipItem)this.cache[name]) == null)
                    {
                        equipItem = this.getItemFromDb(name);
                        if (equipItem == null)
                        {
                            equipItem = EquipItem.UnknownItem;
                        }
                        this.cache[name] = equipItem;
                        this.cache[equipItem.CodeType] = equipItem;
                    }
                }
            }
            return equipItem;
        }

        public EquipItem getItemByCodeType(string codeType)
        {
            EquipItem equipItem = null;
            if ((equipItem = (EquipItem)this.cache[codeType]) == null)
            {
                lock (this.cache)
                {
                    if ((equipItem = (EquipItem)this.cache[codeType]) == null)
                    {
                        equipItem = this.getItemFromDb(EquipItem.getItemCode(codeType), (ushort)EquipItem.getItemType(codeType));
                        if (equipItem == null)
                        {
                            equipItem = EquipItem.UnknownItem;
                        }
                        this.cache[codeType] = equipItem;
                        this.cache[equipItem.Name] = equipItem;
                    }
                }
            }
            return equipItem;
        }

        public static bool ExistsFile(string FilePath)
        {
            return File.Exists(FilePath);
        }

        private byte[] imageToByteArray(string FilePath)
        {
            byte[] result;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (Image image = Image.FromFile(FilePath))
                {
                    using (Bitmap bitmap = new Bitmap(image))
                    {
                        bitmap.Save(memoryStream, image.RawFormat);
                    }
                }
                result = memoryStream.ToArray();
            }
            return result;
        }

        public static byte[] BitmapToBytes(Bitmap Bitmap)
        {
            MemoryStream memoryStream = null;
            byte[] result;
            try
            {
                memoryStream = new MemoryStream();
                Bitmap.Save(memoryStream, Bitmap.RawFormat);
                byte[] array = new byte[memoryStream.Length];
                array = memoryStream.ToArray();
                result = array;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            finally
            {
                memoryStream.Close();
            }
            return result;
        }

        private Image byteArrayToImage(byte[] Bytes)
        {
            Image result;
            using (MemoryStream memoryStream = new MemoryStream(Bytes))
            {
                Image image = Image.FromStream(memoryStream);
                result = image;
            }
            return result;
        }

        protected EquipItem getItemFromDb(string ItemName)
        {
            EquipItem equipItem = null;
            try
            {
                for (int i = 0; i < EquipEditor.xItem.Length; i++)
                {
                    if (EquipEditor.xItem[i] != null && frmMain.ByteToString(EquipEditor.xItem[i].Name, 30) == ItemName)
                    {
                        int profs = (int)(EquipEditor.xItem[i].iClassNumber.WIZARD + EquipEditor.xItem[i].iClassNumber.KNIGHT) << (int)(1 + EquipEditor.xItem[i].iClassNumber.ELF) << (int)(2 + EquipEditor.xItem[i].iClassNumber.MAGUMSA) << (int)(3 + EquipEditor.xItem[i].iClassNumber.DARKLORD) << 4;
                        bool isfz = EquipEditor.xItem[i].iClassNumber.WIZARD != 0 || EquipEditor.xItem[i].iClassNumber.SUMMONER != 0;
                        equipItem = new EquipItem(EquipEditor.xItem[i].Index, frmMain.ByteToString(EquipEditor.xItem[i].Name, 30), EquipEditor.xItem[i].TwoHand, EquipEditor.xItem[i].Group, EquipEditor.xItem[i].X, EquipEditor.xItem[i].Y, profs, isfz);
                        string text = Application.StartupPath + "\\Item\\{0}-{1}.jpg";
                        text = string.Format(text, EquipEditor.xItem[i].Index, EquipEditor.xItem[i].Group);
                        byte[] bytes;
                        if (EquipImageCache.ExistsFile(text))
                        {
                            bytes = this.imageToByteArray(text);
                        }
                        else
                        {
                            bytes = EquipImageCache.BitmapToBytes(Resources.unknownItem);
                        }
                        Image img = this.byteArrayToImage(bytes);
                        equipItem.Img = img;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.WarningMessage(string.Concat(new string[]
                {
                    "getItemFromDb：\nError:",
                    ex.Message,
                    "\nSource:",
                    ex.Source,
                    "\nTrace:",
                    ex.StackTrace
                }));
            }
            return equipItem;
        }

        protected EquipItem getItemFromDb(ushort ItemIndex, ushort ItemType)
        {
            EquipItem equipItem = null;
            try
            {
                int num = (int)(ItemType * 512 + ItemIndex);
                if (EquipEditor.xItem[num] != null)
                {
                    int profs = (int)(EquipEditor.xItem[num].iClassNumber.WIZARD + EquipEditor.xItem[num].iClassNumber.KNIGHT) << (int)(1 + EquipEditor.xItem[num].iClassNumber.ELF) << (int)(2 + EquipEditor.xItem[num].iClassNumber.MAGUMSA) << (int)(3 + EquipEditor.xItem[num].iClassNumber.DARKLORD) << 4;
                    bool isfz = EquipEditor.xItem[num].iClassNumber.KNIGHT == 0 && (EquipEditor.xItem[num].iClassNumber.WIZARD.ToString() + EquipEditor.xItem[num].iClassNumber.SUMMONER.ToString()).Replace("0", "") != "";
                    equipItem = new EquipItem(EquipEditor.xItem[num].Index, frmMain.ByteToString(EquipEditor.xItem[num].Name, 30), EquipEditor.xItem[num].TwoHand, EquipEditor.xItem[num].Group, EquipEditor.xItem[num].X, EquipEditor.xItem[num].Y, profs, isfz);
                    string text = Application.StartupPath + "\\Item\\{0}-{1}.jpg";
                    text = string.Format(text, EquipEditor.xItem[num].Index, EquipEditor.xItem[num].Group);
                    byte[] bytes;
                    if (EquipImageCache.ExistsFile(text))
                    {
                        bytes = this.imageToByteArray(text);
                    }
                    else
                    {
                        bytes = EquipImageCache.BitmapToBytes(Resources.unknownItem);
                    }
                    Image img = this.byteArrayToImage(bytes);
                    equipItem.Img = img;
                }
            }
            catch (Exception ex)
            {
                Utils.WarningMessage(string.Concat(new string[]
                {
                    "getItemFromDb：\nError:",
                    ex.Message,
                    "\nSource:",
                    ex.Source,
                    "\nTrace:",
                    ex.StackTrace
                }));
            }
            return equipItem;
        }

        private Hashtable cache = new Hashtable();

        private class Nested
        {
            internal static readonly EquipImageCache instance = new EquipImageCache();
        }
    }
}
