using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MuEditor
{
    // Token: 0x0200000E RID: 14
    public class TextBox : System.Windows.Forms.TextBox
    {
        // Token: 0x17000017 RID: 23
        // (get) Token: 0x060000CB RID: 203 RVA: 0x000029FD File Offset: 0x00000BFD
        // (set) Token: 0x060000CC RID: 204 RVA: 0x00002A05 File Offset: 0x00000C05
        [Category("Appearance")]
        [Bindable(true)]
        [DefaultValue("false")]
        public bool IsOnlyNumber
        {
            get
            {
                return this.isOnlyNumber;
            }
            set
            {
                this.isOnlyNumber = value;
            }
        }

        // Token: 0x060000CD RID: 205 RVA: 0x00015D78 File Offset: 0x00013F78
        public TextBox()
        {
            base.DoubleClick += this.TextBox_DoubleClick;
            base.KeyUp += this.TextBox_KeyUp;
            base.KeyDown += this.TextBox_KeyDown;
            base.MouseClick += this.TextBox_MouseClick;
        }

        // Token: 0x060000CE RID: 206 RVA: 0x00015DD4 File Offset: 0x00013FD4
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.isOnlyNumber &&
                (e.KeyValue < 48 || e.KeyValue > 57) &&
                (e.KeyValue < 96 || e.KeyValue > 105) &&
                (e.KeyValue < 35 || e.KeyValue > 40) &&
                e.KeyValue != 8 && e.KeyValue != 46)
            {
                e.SuppressKeyPress = true;
            }
        }

        // Token: 0x060000CF RID: 207 RVA: 0x00002A0E File Offset: 0x00000C0E
        private void TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.TextBox_DoubleClick(sender, e);
            }
        }

        // Token: 0x060000D0 RID: 208 RVA: 0x00002A25 File Offset: 0x00000C25
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                this.TextBox_DoubleClick(sender, e);
            }
        }

        // Token: 0x060000D1 RID: 209 RVA: 0x00002A41 File Offset: 0x00000C41
        private void TextBox_DoubleClick(object sender, EventArgs e)
        {
            base.Focus();
            base.SelectAll();
        }

        // Token: 0x04000144 RID: 324
        private bool isOnlyNumber;
    }
}
