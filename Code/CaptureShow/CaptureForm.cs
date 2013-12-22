using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace CaptureShow
{
    public partial class CaptureForm : Form
    {
        private VideoCaptureDevice videoSource;
        private int startCursorPositionX;
        private int startCursorPositionY;
        private int startFormLocationX;
        private int startFormLocationY;
        private int newFormLocationX;
        private int newFormLocationY;
        private int moveDistanceX;
        private int moveDistanceY;
        private Boolean isMoving = false;
        private MainForm mainForm;
        public CaptureForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

        }

        public void SetDevice(String deviceMoniker)
        {
            videoSource = new VideoCaptureDevice(deviceMoniker);
        }

        public void ShowVideo()
        {
            videoSource.DesiredFrameSize = new Size(320, 240);
            videoSource.DesiredFrameRate = 0;
            videoSourcePlayer.VideoSource = videoSource;
            videoSourcePlayer.Start();
        }

        public void StopVideo()
        {
            videoSourcePlayer.SignalToStop();
            videoSourcePlayer.WaitForStop();
        }

        private void videoSourcePlayer_MouseDown(object sender, MouseEventArgs e)
        {
            startCursorPositionX = Cursor.Position.X;
            startCursorPositionY = Cursor.Position.Y;
            startFormLocationX = this.Location.X;
            startFormLocationY = this.Location.Y;
            isMoving = true;//标记为正在移动
        }

        private void videoSourcePlayer_MouseMove(object sender, MouseEventArgs e)
        {
            if (mainForm.movable && isMoving)//可移动并且正在移动
            {
                moveDistanceX = Cursor.Position.X - startCursorPositionX;
                moveDistanceY = Cursor.Position.Y - startCursorPositionY;
                newFormLocationX = startFormLocationX + moveDistanceX;
                newFormLocationY = startFormLocationY + moveDistanceY;
                this.Location = new System.Drawing.Point(newFormLocationX, newFormLocationY);
                mainForm.UpdateLocationText(newFormLocationX, newFormLocationY);
            }
        }

        private void videoSourcePlayer_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;//标记为不在移动
        }

        private void ToolStripMenuItemMovable_Click(object sender, EventArgs e)
        {
            if (mainForm.movable)
            {
                mainForm.UpdateCheckBoxMovable(false);
                toolStripMenuItemMovable.Checked = false;
            }
            else
            {
                mainForm.UpdateCheckBoxMovable(true);
                toolStripMenuItemMovable.Checked = true;
            }
        }

        private void videoSourcePlayer_MouseEnter(object sender, EventArgs e)
        {
            toolStripMenuItemMovable.Checked = mainForm.movable;//更新右键菜单中的勾勾
        }

        private void toolStripMenuItemHide_Click(object sender, EventArgs e)
        {
            this.StopVideo();
            this.Hide();
        }
    }
}
