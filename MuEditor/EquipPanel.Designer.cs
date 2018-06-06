using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MuEditor
{
    partial class EquipPanel
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
            this.components = new Container();
            this.popMenu = new ContextMenuStrip(this.components);
            this.toolStripMenuItem_1 = new ToolStripMenuItem();
            this.toolStripMenuItem_2 = new ToolStripMenuItem();
            this.toolStripMenuItem_4 = new ToolStripMenuItem();
            this.toolStripMenuItem4 = new ToolStripMenuItem();
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.muCopy = new ContextMenuStrip(this.components);
            this.toolStripMenuItem_5 = new ToolStripMenuItem();
            this.toolStripMenuItem_6 = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.toolStripMenuItem_3 = new ToolStripMenuItem();
            this.ttInfo = new ToolTip(this.components);
            this.popMenu.SuspendLayout();
            this.muCopy.SuspendLayout();
            base.SuspendLayout();
            this.popMenu.Items.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem_1,
                this.toolStripMenuItem_2,
                this.toolStripMenuItem_4,
                this.toolStripMenuItem4,
                this.toolStripMenuItem1,
                this.toolStripMenuItem_0,
                this.toolStripMenuItem3
            });
            this.popMenu.Name = "popMenu";
            this.popMenu.Size = new Size(137, 158);
            this.toolStripMenuItem_1.Name = "关闭ToolStripMenuItem";
            this.toolStripMenuItem_1.Size = new Size(136, 22);
            this.toolStripMenuItem_1.Text = "剪切(&T)";
            this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
            this.toolStripMenuItem_2.Name = "复制CToolStripMenuItem";
            this.toolStripMenuItem_2.Size = new Size(136, 22);
            this.toolStripMenuItem_2.Text = "复制(&C)";
            this.toolStripMenuItem_2.Click += this.toolStripMenuItem_2_Click;
            this.toolStripMenuItem_4.Name = "复制全部AToolStripMenuItem";
            this.toolStripMenuItem_4.Size = new Size(136, 22);
            this.toolStripMenuItem_4.Text = "复制全部(&A)";
            this.toolStripMenuItem_4.Click += this.toolStripMenuItem2_Click;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new Size(136, 22);
            this.toolStripMenuItem4.Text = "整理(&L)";
            this.toolStripMenuItem4.Click += this.toolStripMenuItem_6_Click;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(136, 22);
            this.toolStripMenuItem1.Text = "修改(&E)";
            this.toolStripMenuItem1.Click += this.toolStripMenuItem1_Click;
            this.toolStripMenuItem_0.Name = "删除ToolStripMenuItem";
            this.toolStripMenuItem_0.Size = new Size(136, 22);
            this.toolStripMenuItem_0.Text = "删除(&D)";
            this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new Size(136, 22);
            this.toolStripMenuItem3.Text = "清空(&M)";
            this.toolStripMenuItem3.Click += this.toolStripMenuItem_5_Click;
            this.muCopy.Items.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem_5,
                this.toolStripMenuItem_6,
                this.toolStripMenuItem2,
                this.toolStripMenuItem_3
            });
            this.muCopy.Name = "muCopy";
            this.muCopy.Size = new Size(153, 114);
            this.muCopy.Opening += this.muCopy_Opening;
            this.toolStripMenuItem_5.Name = "清空CToolStripMenuItem";
            this.toolStripMenuItem_5.Size = new Size(152, 22);
            this.toolStripMenuItem_5.Text = "清空(&C)";
            this.toolStripMenuItem_5.Click += this.toolStripMenuItem_5_Click;
            this.toolStripMenuItem_6.Name = "整理ZToolStripMenuItem";
            this.toolStripMenuItem_6.Size = new Size(152, 22);
            this.toolStripMenuItem_6.Text = "整理(&L)";
            this.toolStripMenuItem_6.Click += this.toolStripMenuItem_6_Click;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(152, 22);
            this.toolStripMenuItem2.Text = "复制全部(&A)";
            this.toolStripMenuItem2.Click += this.toolStripMenuItem2_Click;
            this.toolStripMenuItem_3.Name = "粘贴VToolStripMenuItem";
            this.toolStripMenuItem_3.Size = new Size(152, 22);
            this.toolStripMenuItem_3.Text = "粘贴(&V)";
            this.toolStripMenuItem_3.Click += this.toolStripMenuItem_3_Click;
            this.ttInfo.ToolTipIcon = ToolTipIcon.Info;
            this.ttInfo.ToolTipTitle = "物品信息";
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = Properties.Resources.warehouse_2;
            this.BackgroundImageLayout = ImageLayout.None;
            this.Cursor = Cursors.Default;
            this.DoubleBuffered = true;
            base.Margin = new Padding(0);
            base.Name = "EquipPanel";
            base.Size = new Size(209, 209);
            base.Paint += this.EquipPanel_Paint;
            base.MouseClick += this.EquipPanel_MouseClick;
            base.MouseDoubleClick += this.EquipPanel_MouseDBClick;
            base.MouseEnter += this.EquipPanel_MouseEnter;
            base.MouseLeave += this.EquipPanel_MouseLeave;
            base.MouseMove += this.EquipPanel_MouseMove;
            this.popMenu.ResumeLayout(false);
            this.muCopy.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private ContextMenuStrip popMenu;

        private ToolStripMenuItem toolStripMenuItem_0;

        private ToolStripMenuItem toolStripMenuItem_1;

        private ToolStripMenuItem toolStripMenuItem1;

        private ToolStripMenuItem toolStripMenuItem_2;

        private ContextMenuStrip muCopy;

        private ToolStripMenuItem toolStripMenuItem_3;

        private ToolStripMenuItem toolStripMenuItem_4;

        public ToolTip ttInfo;

        private ToolStripMenuItem toolStripMenuItem_5;

        private ToolStripMenuItem toolStripMenuItem2;

        private ToolStripMenuItem toolStripMenuItem3;

        private ToolStripMenuItem toolStripMenuItem4;

        private ToolStripMenuItem toolStripMenuItem_6;

        #endregion
    }
}
