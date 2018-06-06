using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MuEditor
{
    partial class PentagramPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.popMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.muCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.popMenu.SuspendLayout();
            this.muCopy.SuspendLayout();
            this.SuspendLayout();
            // 
            // popMenu
            // 
            this.popMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_2,
            this.toolStripMenuItem_3,
            this.toolStripMenuItem_5,
            this.toolStripMenuItem_1,
            this.toolStripMenuItem_0,
            this.toolStripMenuItem1});
            this.popMenu.Name = "popMenu";
            this.popMenu.Size = new System.Drawing.Size(139, 136);
            // 
            // toolStripMenuItem_2
            // 
            this.toolStripMenuItem_2.Name = "toolStripMenuItem_2";
            this.toolStripMenuItem_2.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem_2.Text = "剪切(&T)";
            // 
            // toolStripMenuItem_3
            // 
            this.toolStripMenuItem_3.Name = "toolStripMenuItem_3";
            this.toolStripMenuItem_3.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem_3.Text = "复制(&C)";
            // 
            // toolStripMenuItem_5
            // 
            this.toolStripMenuItem_5.Name = "toolStripMenuItem_5";
            this.toolStripMenuItem_5.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem_5.Text = "复制全部(&A)";
            // 
            // toolStripMenuItem_1
            // 
            this.toolStripMenuItem_1.Name = "toolStripMenuItem_1";
            this.toolStripMenuItem_1.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem_1.Text = "修改(&E)";
            // 
            // toolStripMenuItem_0
            // 
            this.toolStripMenuItem_0.Name = "toolStripMenuItem_0";
            this.toolStripMenuItem_0.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem_0.Text = "删除(&D)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem1.Text = "清空(&M)";
            // 
            // muCopy
            // 
            this.muCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_6,
            this.toolStripMenuItem2,
            this.toolStripMenuItem_4});
            this.muCopy.Name = "muCopy";
            this.muCopy.Size = new System.Drawing.Size(139, 70);
            // 
            // toolStripMenuItem_6
            // 
            this.toolStripMenuItem_6.Name = "toolStripMenuItem_6";
            this.toolStripMenuItem_6.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem_6.Text = "清空(&C)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem2.Text = "复制全部(&A)";
            // 
            // toolStripMenuItem_4
            // 
            this.toolStripMenuItem_4.Name = "toolStripMenuItem_4";
            this.toolStripMenuItem_4.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem_4.Text = "粘贴(&V)";
            // 
            // ttInfo
            // 
            this.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttInfo.ToolTipTitle = "物品信息";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MuEditor.Properties.Resources.skillbook;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(58, 63);
            this.popMenu.ResumeLayout(false);
            this.muCopy.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        // Token: 0x04000145 RID: 325
        public const int EquipNum = 1;

        // Token: 0x04000146 RID: 326
        private int index = -1;

        // Token: 0x04000147 RID: 327
        private int lastedIndex = -2;

        // Token: 0x04000148 RID: 328
        private bool isShowTip;

        // Token: 0x04000149 RID: 329
        private Rectangle[] positions = new Rectangle[]
        {
            new Rectangle(6, 6, 46, 46)
        };

        // Token: 0x0400014A RID: 330
        private DrawingUnit[] units = new DrawingUnit[1];

        // Token: 0x0400014B RID: 331
        private DrawingUnit curUnit = new DrawingUnit();

        // Token: 0x0400014C RID: 332
        private DrawingUnit selectedUnit;

        // Token: 0x0400014D RID: 333
        private int prof = -1;

        // Token: 0x0400014E RID: 334
        private EquipEditor editor;

        // Token: 0x0400014F RID: 335
        //private IContainer components;

        // Token: 0x04000150 RID: 336
        private ContextMenuStrip popMenu;

        // Token: 0x04000151 RID: 337
        private ToolStripMenuItem toolStripMenuItem_0;

        // Token: 0x04000152 RID: 338
        private ToolStripMenuItem toolStripMenuItem_1;

        // Token: 0x04000153 RID: 339
        private ToolStripMenuItem toolStripMenuItem_2;

        // Token: 0x04000154 RID: 340
        private ToolStripMenuItem toolStripMenuItem_3;

        // Token: 0x04000155 RID: 341
        private ContextMenuStrip muCopy;

        // Token: 0x04000156 RID: 342
        private ToolStripMenuItem toolStripMenuItem_4;

        // Token: 0x04000157 RID: 343
        private ToolTip ttInfo;

        // Token: 0x04000158 RID: 344
        private ToolStripMenuItem toolStripMenuItem_5;

        // Token: 0x04000159 RID: 345
        private ToolStripMenuItem toolStripMenuItem_6;

        // Token: 0x0400015A RID: 346
        private ToolStripMenuItem toolStripMenuItem2;

        // Token: 0x0400015B RID: 347
        private ToolStripMenuItem toolStripMenuItem1;
        #endregion
    }
}
