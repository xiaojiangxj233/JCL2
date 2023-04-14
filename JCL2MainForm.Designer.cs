namespace JCL2
{
    partial class JCL2MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.VersionList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(50, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "启动游戏";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // VersionList
            // 
            this.VersionList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VersionList.FormattingEnabled = true;
            this.VersionList.Location = new System.Drawing.Point(66, 390);
            this.VersionList.Name = "VersionList";
            this.VersionList.Size = new System.Drawing.Size(243, 25);
            this.VersionList.TabIndex = 1;
            // 
            // JCL2MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 446);
            this.Controls.Add(this.VersionList);
            this.Controls.Add(this.button1);
            this.Name = "JCL2MainForm";
            this.Text = "JCL2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox VersionList;
    }
}

