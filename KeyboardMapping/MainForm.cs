using System;
using System.Windows.Forms;

namespace KeyboardMapping
{
    public partial class MainForm : Form
    {
        private bool switchFlag = false;                // 状态标志

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            if (!switchFlag)
            {
                BtnSwitch.Text = "取消映射";
                Label.Text = "Caps Look 和 Ctrl 已经对调";
                switchFlag = true;
            }
            else
            {
                BtnSwitch.Text = "开始映射";
                Label.Text = "Caps Look 和 Ctrl 没有对调";
                switchFlag = false;
            }
        }
    }
}