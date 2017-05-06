namespace KeyboardMapping
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
            this.BtnSwitch = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.TestBox = new System.Windows.Forms.TextBox();
            this.TestBookTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // BtnSwitch
            // 
            this.BtnSwitch.Location = new System.Drawing.Point(105, 119);
            this.BtnSwitch.Name = "BtnSwitch";
            this.BtnSwitch.Size = new System.Drawing.Size(75, 23);
            this.BtnSwitch.TabIndex = 0;
            this.BtnSwitch.Text = "开启映射";
            this.BtnSwitch.UseVisualStyleBackColor = true;
            this.BtnSwitch.Click += new System.EventHandler(this.BtnSwitch_Click);
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
            this.Label.Text = "Caps Look 和 Ctrl 没有对调";
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
            // MainForm
            // 
            this.AcceptButton = this.BtnSwitch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TestBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.BtnSwitch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyMap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSwitch;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox TestBox;
        private System.Windows.Forms.ToolTip TestBookTip;
    }
}