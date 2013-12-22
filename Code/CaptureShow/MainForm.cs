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
    public partial class MainForm : Form
    {
        private CaptureForm cf;
        private int locationX;
        private int locationY;
        private int width;
        private int height;
        public bool movable;

        private FilterInfoCollection videoDevices;

        public MainForm()
        {
            InitializeComponent();
            cf = new CaptureForm(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // 枚举所有视频输入设备
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0) throw new ApplicationException();
                foreach (FilterInfo device in videoDevices)
                {
                    comboBoxDevicesList.Items.Add(device.Name);
                }
                try { comboBoxDevicesList.SelectedIndex = Settings.Default.SelectedItemIndex; }
                catch { comboBoxDevicesList.SelectedIndex = 0; }
            }
            catch (ApplicationException)
            {
                comboBoxDevicesList.Items.Add("没有摄像头设备");
                videoDevices = null;
            }

            //首次打开则按照分辨率加载预制的配置
            if (Settings.Default.FirstOpen)
            {
                Rectangle resolution = new Rectangle();
                resolution = Screen.GetWorkingArea(this);
                if (resolution.Width == 1366)
                {
                    textBoxLocationX.Text = 1095 + "";
                    textBoxLocationY.Text = 596 + "";
                    textBoxWidth.Text = 257 + "";
                    textBoxHeight.Text = 170 + "";
                }
                //如果列表中开头是USB的，则优先选择
                for (int i = 0; i < comboBoxDevicesList.Items.Count; i++)
                {
                    if (comboBoxDevicesList.Items[i].ToString().StartsWith("USB")) comboBoxDevicesList.SelectedIndex = i;
                }
                checkBoxMovable.Checked = true;
                hScrollBarOpacity.Value = 100;
                labelOpacity.Text = "100%";
            }

            //否则读取保存的配置
            else
            {
                GetSettings();
                labelOpacity.Text = hScrollBarOpacity.Value + "%";
            }

            locationX = Convert.ToInt16(textBoxLocationX.Text);
            locationY = Convert.ToInt16(textBoxLocationY.Text);
            width = Convert.ToInt16(textBoxWidth.Text);
            height = Convert.ToInt16(textBoxHeight.Text);

            //显示版本号
            Version ApplicationVersion = new Version(Application.ProductVersion);
            labelVersion.Text = "版本：" +  ApplicationVersion.ToString();
        }


        /// <summary>
        /// 显示按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            locationX = Convert.ToInt16(textBoxLocationX.Text);
            locationY = Convert.ToInt16(textBoxLocationY.Text);
            width = Convert.ToInt16(textBoxWidth.Text);
            height = Convert.ToInt16(textBoxHeight.Text);

            SaveSettings();

            cf.Activate();
            cf.StopVideo();
            cf.SetDevice(videoDevices[comboBoxDevicesList.SelectedIndex].MonikerString);
            cf.Location = new System.Drawing.Point(locationX, locationY);
            cf.Size = new Size(width, height);
            cf.ShowVideo();
            cf.Show();
        }

        /// <summary>
        /// 隐藏按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHide_Click(object sender, EventArgs e)
        {
            cf.StopVideo();
            cf.Hide();
        }

        /// <summary>
        /// 窗口关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            buttonHide_Click(null, null);//先关闭CaptureForm窗口
            SaveSettings();//保存设置
        }


        /// <summary>
        /// 更新位置的TextBox，由CaptureForm窗口调用
        /// </summary>
        /// <param name="locationX"></param>
        /// <param name="locationY"></param>
        public void UpdateLocationText(int locationX, int locationY)
        {
            this.locationX = locationX;
            this.locationY = locationY;
            textBoxLocationX.Text = locationX + "";
            textBoxLocationY.Text = locationY + "";
        }

        /// <summary>
        /// 更新checkBoxMovable的选中情况，由CaptureForm窗口调用
        /// </summary>
        /// <param name="movable"></param>
        public void UpdateCheckBoxMovable(bool movable)
        {
            this.movable = movable;
            checkBoxMovable.Checked = movable;
        }

        /// <summary>
        /// checkBoxMovable的CheckedChanged事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxMovable_CheckedChanged(object sender, EventArgs e)
        {
            movable = checkBoxMovable.Checked;
        }

        /// <summary>
        /// 窗口大小变化，主要用来判断是否最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //如果最小化，则隐藏窗口，显示通知图标
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon.Visible = true;
                this.notifyIcon.ShowBalloonTip(5);
            }
        }

        /// <summary>
        /// 通知图标鼠标单击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            //判断如果是左键单击则显示主界面
            if (e.Button == MouseButtons.Left)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.notifyIcon.Visible = false;
            }
        }

        /// <summary>
        /// 点击通知菜单上的显示按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemShow_Click(object sender, EventArgs e)
        {
            buttonShow_Click(null, null);
        }

        /// <summary>
        /// 点击通知菜单上的隐藏按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemHide_Click(object sender, EventArgs e)
        {
            buttonHide_Click(null, null);
        }

        /// <summary>
        /// 点击通知菜单上的退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 滚动不透明度调节条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBarOpacity_Scroll(object sender, ScrollEventArgs e)
        {
            labelOpacity.Text = hScrollBarOpacity.Value + "%";
            cf.Opacity = (double)hScrollBarOpacity.Value / 100;
        }

        /// <summary>
        /// 保存设置
        /// </summary>
        private void SaveSettings()
        {
            if (Settings.Default.FirstOpen) Settings.Default.FirstOpen = false;
            Settings.Default.LocationX = locationX;
            Settings.Default.LocationY = locationY;
            Settings.Default.Width = width;
            Settings.Default.Height = height;
            Settings.Default.SelectedItemIndex = comboBoxDevicesList.SelectedIndex;
            Settings.Default.Movable = checkBoxMovable.Checked;
            Settings.Default.Opacity = hScrollBarOpacity.Value;
            Settings.Default.Save();
        }

        /// <summary>
        /// 获取设置
        /// </summary>
        private void GetSettings()
        {
            textBoxLocationX.Text = Settings.Default.LocationX.ToString();
            textBoxLocationY.Text = Settings.Default.LocationY.ToString();
            textBoxWidth.Text = Settings.Default.Width.ToString();
            textBoxHeight.Text = Settings.Default.Height.ToString();
            checkBoxMovable.Checked = Settings.Default.Movable;
            hScrollBarOpacity.Value = Settings.Default.Opacity;
        }

        /// <summary>
        /// 点击LinkLabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.haoest.com");
        }

    }
}
