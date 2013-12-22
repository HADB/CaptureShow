namespace CaptureShow
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxLocationX = new System.Windows.Forms.TextBox();
            this.groupBoxOutSetting = new System.Windows.Forms.GroupBox();
            this.labelOpacity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hScrollBarOpacity = new System.Windows.Forms.HScrollBar();
            this.checkBoxMovable = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxLocationY = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxDevicesList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotification = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.labelVersion = new System.Windows.Forms.Label();
            this.groupBoxOutSetting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStripNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLocationX
            // 
            this.textBoxLocationX.Location = new System.Drawing.Point(99, 25);
            this.textBoxLocationX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLocationX.Name = "textBoxLocationX";
            this.textBoxLocationX.Size = new System.Drawing.Size(83, 23);
            this.textBoxLocationX.TabIndex = 0;
            this.textBoxLocationX.Text = "0";
            // 
            // groupBoxOutSetting
            // 
            this.groupBoxOutSetting.Controls.Add(this.labelOpacity);
            this.groupBoxOutSetting.Controls.Add(this.label8);
            this.groupBoxOutSetting.Controls.Add(this.hScrollBarOpacity);
            this.groupBoxOutSetting.Controls.Add(this.checkBoxMovable);
            this.groupBoxOutSetting.Controls.Add(this.label4);
            this.groupBoxOutSetting.Controls.Add(this.label3);
            this.groupBoxOutSetting.Controls.Add(this.label2);
            this.groupBoxOutSetting.Controls.Add(this.textBoxHeight);
            this.groupBoxOutSetting.Controls.Add(this.label1);
            this.groupBoxOutSetting.Controls.Add(this.textBoxWidth);
            this.groupBoxOutSetting.Controls.Add(this.textBoxLocationY);
            this.groupBoxOutSetting.Controls.Add(this.textBoxLocationX);
            this.groupBoxOutSetting.Location = new System.Drawing.Point(12, 87);
            this.groupBoxOutSetting.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOutSetting.Name = "groupBoxOutSetting";
            this.groupBoxOutSetting.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOutSetting.Size = new System.Drawing.Size(385, 126);
            this.groupBoxOutSetting.TabIndex = 1;
            this.groupBoxOutSetting.TabStop = false;
            this.groupBoxOutSetting.Text = "输出设置";
            // 
            // labelOpacity
            // 
            this.labelOpacity.AutoSize = true;
            this.labelOpacity.Location = new System.Drawing.Point(338, 91);
            this.labelOpacity.Name = "labelOpacity";
            this.labelOpacity.Size = new System.Drawing.Size(40, 17);
            this.labelOpacity.TabIndex = 5;
            this.labelOpacity.Text = "100%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "不透明度：";
            // 
            // hScrollBarOpacity
            // 
            this.hScrollBarOpacity.LargeChange = 1;
            this.hScrollBarOpacity.Location = new System.Drawing.Point(185, 91);
            this.hScrollBarOpacity.Name = "hScrollBarOpacity";
            this.hScrollBarOpacity.Size = new System.Drawing.Size(141, 17);
            this.hScrollBarOpacity.TabIndex = 3;
            this.hScrollBarOpacity.Value = 100;
            this.hScrollBarOpacity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarOpacity_Scroll);
            // 
            // checkBoxMovable
            // 
            this.checkBoxMovable.AutoSize = true;
            this.checkBoxMovable.Location = new System.Drawing.Point(26, 90);
            this.checkBoxMovable.Name = "checkBoxMovable";
            this.checkBoxMovable.Size = new System.Drawing.Size(63, 21);
            this.checkBoxMovable.TabIndex = 2;
            this.checkBoxMovable.Text = "可移动";
            this.checkBoxMovable.UseVisualStyleBackColor = true;
            this.checkBoxMovable.CheckedChanged += new System.EventHandler(this.checkBoxMovable_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "高度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "宽度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "垂直位置：";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(274, 56);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(83, 23);
            this.textBoxHeight.TabIndex = 0;
            this.textBoxHeight.Text = "170";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "水平位置：";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(274, 25);
            this.textBoxWidth.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(83, 23);
            this.textBoxWidth.TabIndex = 0;
            this.textBoxWidth.Text = "257";
            // 
            // textBoxLocationY
            // 
            this.textBoxLocationY.Location = new System.Drawing.Point(99, 55);
            this.textBoxLocationY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLocationY.Name = "textBoxLocationY";
            this.textBoxLocationY.Size = new System.Drawing.Size(83, 23);
            this.textBoxLocationY.TabIndex = 0;
            this.textBoxLocationY.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonHide);
            this.groupBox1.Controls.Add(this.buttonShow);
            this.groupBox1.Location = new System.Drawing.Point(404, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作控制";
            // 
            // buttonHide
            // 
            this.buttonHide.AutoSize = true;
            this.buttonHide.Location = new System.Drawing.Point(6, 55);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(75, 27);
            this.buttonHide.TabIndex = 1;
            this.buttonHide.Text = "隐藏";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.AutoSize = true;
            this.buttonShow.Location = new System.Drawing.Point(6, 22);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 27);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "显示";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxDevicesList);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 68);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入设置";
            // 
            // comboBoxDevicesList
            // 
            this.comboBoxDevicesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevicesList.FormattingEnabled = true;
            this.comboBoxDevicesList.Location = new System.Drawing.Point(80, 22);
            this.comboBoxDevicesList.Name = "comboBoxDevicesList";
            this.comboBoxDevicesList.Size = new System.Drawing.Size(277, 25);
            this.comboBoxDevicesList.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "视频设备：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "说明：本页的配置将自动保存";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "制作：邓斌HADB of";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(298, 256);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "HAOest";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "已进入系统托盘";
            this.notifyIcon.BalloonTipTitle = "视频秀";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripNotification;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "视频秀";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStripNotification
            // 
            this.contextMenuStripNotification.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShow,
            this.toolStripMenuItemHide,
            this.toolStripMenuItemAbout,
            this.toolStripMenuItemExit});
            this.contextMenuStripNotification.Name = "contextMenuStripNotification";
            this.contextMenuStripNotification.Size = new System.Drawing.Size(101, 92);
            // 
            // toolStripMenuItemShow
            // 
            this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
            this.toolStripMenuItemShow.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemShow.Text = "显示";
            this.toolStripMenuItemShow.Click += new System.EventHandler(this.toolStripMenuItemShow_Click);
            // 
            // toolStripMenuItemHide
            // 
            this.toolStripMenuItemHide.Name = "toolStripMenuItemHide";
            this.toolStripMenuItemHide.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemHide.Text = "隐藏";
            this.toolStripMenuItemHide.Click += new System.EventHandler(this.toolStripMenuItemHide_Click);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemAbout.Text = "关于";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemExit.Text = "退出";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(356, 256);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelVersion.Size = new System.Drawing.Size(129, 17);
            this.labelVersion.TabIndex = 7;
            this.labelVersion.Text = "版本：";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 282);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxOutSetting);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "视频秀1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.groupBoxOutSetting.ResumeLayout(false);
            this.groupBoxOutSetting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStripNotification.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLocationX;
        private System.Windows.Forms.GroupBox groupBoxOutSetting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxLocationY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxDevicesList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBoxMovable;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotification;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHide;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HScrollBar hScrollBarOpacity;
        private System.Windows.Forms.Label labelOpacity;
        private System.Windows.Forms.Label labelVersion;
    }
}

