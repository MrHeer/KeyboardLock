using System;
using System.Windows.Forms;

namespace KeyboardLock
{
    public partial class MainForm : Form
    {
        private bool lockKeyboard = false;              // 键盘状态标志
        private KeyboardHook k_hook = new KeyboardHook();

        public MainForm()
        {
            InitializeComponent();

            k_hook.KeyDownEvent += new KeyEventHandler(Hook_KeyDown);//钩住键按下 

            k_hook.Start();
        }

        private void Hook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F3)
            {
                if (!lockKeyboard)
                {
                    Lock("取消锁定", "键盘已经锁定", false, true);
                }
                else
                {
                    Lock("锁定键盘", "键盘暂未锁定", true, false);
                }

            }
        }

        private void BtnKeyboardLock_Click(object sender, EventArgs e)
        {
            if (!lockKeyboard)
            {
                Lock("取消锁定", "键盘已经锁定", false, true);
            }
            else
            {
                Lock("锁定键盘", "键盘暂未锁定", true, false);
            }
        }

        /// <summary>
        /// 锁定键盘或解锁键盘
        /// </summary>
        /// <param name="BtnText">按键文字</param>
        /// <param name="LabelText">提示文字</param>
        /// <param name="hook_state">钩子状态</param>
        /// <param name="keyboard_state">键盘状态</param>
        private void Lock(string BtnText, string LabelText, bool hook_state, bool keyboard_state)
        {
            BtnKeyboardLock.Text = BtnText;
            Label.Text = LabelText;
            k_hook.Go = hook_state;
            lockKeyboard = keyboard_state;
        }

        ~MainForm()
        {
            k_hook.Start();
        }
    }
}