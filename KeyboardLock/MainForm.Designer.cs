﻿namespace KeyboardLock
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Label = new System.Windows.Forms.Label();
            this.TestBox = new System.Windows.Forms.TextBox();
            this.TestBookTip = new System.Windows.Forms.ToolTip(this.components);
            this.BtnKeyboardLock = new System.Windows.Forms.Button();
            this.BtnTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label.Location = new System.Drawing.Point(62, 171);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(161, 12);
            this.Label.TabIndex = 2;
            this.Label.Text = "键盘暂未锁定";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestBox
            // 
            this.TestBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestBox.Location = new System.Drawing.Point(92, 72);
            this.TestBox.MaxLength = 10;
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(100, 21);
            this.TestBox.TabIndex = 1;
            this.TestBookTip.SetToolTip(this.TestBox, "检测是否映射成功");
            // 
            // BtnKeyboardLock
            // 
            this.BtnKeyboardLock.Location = new System.Drawing.Point(105, 119);
            this.BtnKeyboardLock.Name = "BtnKeyboardLock";
            this.BtnKeyboardLock.Size = new System.Drawing.Size(75, 23);
            this.BtnKeyboardLock.TabIndex = 0;
            this.BtnKeyboardLock.Text = "锁定键盘";
            this.BtnTip.SetToolTip(this.BtnKeyboardLock, "热键：F3");
            this.BtnKeyboardLock.UseVisualStyleBackColor = true;
            this.BtnKeyboardLock.Click += new System.EventHandler(this.BtnKeyboardLock_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.BtnKeyboardLock;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TestBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.BtnKeyboardLock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "键盘锁定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox TestBox;
        private System.Windows.Forms.ToolTip TestBookTip;
        private System.Windows.Forms.Button BtnKeyboardLock;
        private System.Windows.Forms.ToolTip BtnTip;
    }
}