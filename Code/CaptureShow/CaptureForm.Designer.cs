namespace CaptureShow
{
    partial class CaptureForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemMovable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHide = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.ContextMenuStrip = this.contextMenuStrip;
            this.videoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(347, 248);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.videoSourcePlayer_MouseDown);
            this.videoSourcePlayer.MouseEnter += new System.EventHandler(this.videoSourcePlayer_MouseEnter);
            this.videoSourcePlayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.videoSourcePlayer_MouseMove);
            this.videoSourcePlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.videoSourcePlayer_MouseUp);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMovable,
            this.toolStripMenuItemHide});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 70);
            this.contextMenuStrip.Text = "功能";
            // 
            // toolStripMenuItemMovable
            // 
            this.toolStripMenuItemMovable.Checked = true;
            this.toolStripMenuItemMovable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemMovable.Name = "toolStripMenuItemMovable";
            this.toolStripMenuItemMovable.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemMovable.Text = "可移动";
            this.toolStripMenuItemMovable.Click += new System.EventHandler(this.ToolStripMenuItemMovable_Click);
            // 
            // toolStripMenuItemHide
            // 
            this.toolStripMenuItemHide.Name = "toolStripMenuItemHide";
            this.toolStripMenuItemHide.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemHide.Text = "隐藏";
            this.toolStripMenuItemHide.Click += new System.EventHandler(this.toolStripMenuItemHide_Click);
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 248);
            this.Controls.Add(this.videoSourcePlayer);
            this.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CaptureForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CaptureForm";
            this.TopMost = true;
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMovable;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHide;

    }
}