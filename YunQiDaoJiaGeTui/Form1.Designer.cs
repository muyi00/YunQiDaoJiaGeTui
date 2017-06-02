namespace YunQiDaoJiaGeTui
{
    partial class Form1
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
            this.push_btn = new System.Windows.Forms.Button();
            this.corpCode_tbox = new System.Windows.Forms.TextBox();
            this.userCode_tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkVersion_cb = new System.Windows.Forms.CheckBox();
            this.checkUpgrade_cb = new System.Windows.Forms.CheckBox();
            this.isDebug_cb = new System.Windows.Forms.CheckBox();
            this.writeLog_cb = new System.Windows.Forms.CheckBox();
            this.uploadLogFile_cb = new System.Windows.Forms.CheckBox();
            this.updatePermissions_cb = new System.Windows.Forms.CheckBox();
            this.clearACache_cb = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logLevel_tbox = new System.Windows.Forms.TextBox();
            this.toJson_btn = new System.Windows.Forms.Button();
            this.json_tbox = new System.Windows.Forms.TextBox();
            this.msg_lbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // push_btn
            // 
            this.push_btn.Location = new System.Drawing.Point(446, 69);
            this.push_btn.Name = "push_btn";
            this.push_btn.Size = new System.Drawing.Size(93, 51);
            this.push_btn.TabIndex = 0;
            this.push_btn.Text = "推送";
            this.push_btn.UseVisualStyleBackColor = true;
            this.push_btn.Click += new System.EventHandler(this.push_btn_Click);
            // 
            // corpCode_tbox
            // 
            this.corpCode_tbox.Location = new System.Drawing.Point(65, 12);
            this.corpCode_tbox.Name = "corpCode_tbox";
            this.corpCode_tbox.Size = new System.Drawing.Size(118, 21);
            this.corpCode_tbox.TabIndex = 1;
            // 
            // userCode_tbox
            // 
            this.userCode_tbox.Location = new System.Drawing.Point(280, 12);
            this.userCode_tbox.Name = "userCode_tbox";
            this.userCode_tbox.Size = new System.Drawing.Size(109, 21);
            this.userCode_tbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "企业编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "员工编号";
            // 
            // checkVersion_cb
            // 
            this.checkVersion_cb.AutoSize = true;
            this.checkVersion_cb.Location = new System.Drawing.Point(8, 53);
            this.checkVersion_cb.Name = "checkVersion_cb";
            this.checkVersion_cb.Size = new System.Drawing.Size(90, 16);
            this.checkVersion_cb.TabIndex = 5;
            this.checkVersion_cb.Text = "检测app升级";
            this.checkVersion_cb.UseVisualStyleBackColor = true;
            // 
            // checkUpgrade_cb
            // 
            this.checkUpgrade_cb.AutoSize = true;
            this.checkUpgrade_cb.Location = new System.Drawing.Point(8, 75);
            this.checkUpgrade_cb.Name = "checkUpgrade_cb";
            this.checkUpgrade_cb.Size = new System.Drawing.Size(96, 16);
            this.checkUpgrade_cb.TabIndex = 6;
            this.checkUpgrade_cb.Text = "检查更新补丁";
            this.checkUpgrade_cb.UseVisualStyleBackColor = true;
            // 
            // isDebug_cb
            // 
            this.isDebug_cb.AutoSize = true;
            this.isDebug_cb.Location = new System.Drawing.Point(312, 53);
            this.isDebug_cb.Name = "isDebug_cb";
            this.isDebug_cb.Size = new System.Drawing.Size(96, 16);
            this.isDebug_cb.TabIndex = 7;
            this.isDebug_cb.Text = "开启调试模式";
            this.isDebug_cb.UseVisualStyleBackColor = true;
            // 
            // writeLog_cb
            // 
            this.writeLog_cb.AutoSize = true;
            this.writeLog_cb.Location = new System.Drawing.Point(312, 97);
            this.writeLog_cb.Name = "writeLog_cb";
            this.writeLog_cb.Size = new System.Drawing.Size(108, 16);
            this.writeLog_cb.TabIndex = 8;
            this.writeLog_cb.Text = "日志写到文件中";
            this.writeLog_cb.UseVisualStyleBackColor = true;
            // 
            // uploadLogFile_cb
            // 
            this.uploadLogFile_cb.AutoSize = true;
            this.uploadLogFile_cb.Location = new System.Drawing.Point(136, 53);
            this.uploadLogFile_cb.Name = "uploadLogFile_cb";
            this.uploadLogFile_cb.Size = new System.Drawing.Size(96, 16);
            this.uploadLogFile_cb.TabIndex = 9;
            this.uploadLogFile_cb.Text = "上传日志文件";
            this.uploadLogFile_cb.UseVisualStyleBackColor = true;
            // 
            // updatePermissions_cb
            // 
            this.updatePermissions_cb.AutoSize = true;
            this.updatePermissions_cb.Location = new System.Drawing.Point(8, 97);
            this.updatePermissions_cb.Name = "updatePermissions_cb";
            this.updatePermissions_cb.Size = new System.Drawing.Size(72, 16);
            this.updatePermissions_cb.TabIndex = 10;
            this.updatePermissions_cb.Text = "同步权限";
            this.updatePermissions_cb.UseVisualStyleBackColor = true;
            // 
            // clearACache_cb
            // 
            this.clearACache_cb.AutoSize = true;
            this.clearACache_cb.Location = new System.Drawing.Point(136, 75);
            this.clearACache_cb.Name = "clearACache_cb";
            this.clearACache_cb.Size = new System.Drawing.Size(108, 16);
            this.clearACache_cb.TabIndex = 11;
            this.clearACache_cb.Text = "清空ACache缓存";
            this.clearACache_cb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "日志打印级别";
            // 
            // logLevel_tbox
            // 
            this.logLevel_tbox.Location = new System.Drawing.Point(394, 74);
            this.logLevel_tbox.MaxLength = 2;
            this.logLevel_tbox.Name = "logLevel_tbox";
            this.logLevel_tbox.Size = new System.Drawing.Size(41, 21);
            this.logLevel_tbox.TabIndex = 12;
            this.logLevel_tbox.Text = "0";
            this.logLevel_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toJson_btn
            // 
            this.toJson_btn.Location = new System.Drawing.Point(446, 3);
            this.toJson_btn.Name = "toJson_btn";
            this.toJson_btn.Size = new System.Drawing.Size(93, 51);
            this.toJson_btn.TabIndex = 14;
            this.toJson_btn.Text = "生成消息";
            this.toJson_btn.UseVisualStyleBackColor = true;
            this.toJson_btn.Click += new System.EventHandler(this.toJson_btn_Click);
            // 
            // json_tbox
            // 
            this.json_tbox.Location = new System.Drawing.Point(3, 123);
            this.json_tbox.Multiline = true;
            this.json_tbox.Name = "json_tbox";
            this.json_tbox.Size = new System.Drawing.Size(536, 93);
            this.json_tbox.TabIndex = 15;
            // 
            // msg_lbox
            // 
            this.msg_lbox.FormattingEnabled = true;
            this.msg_lbox.ItemHeight = 12;
            this.msg_lbox.Location = new System.Drawing.Point(3, 226);
            this.msg_lbox.Name = "msg_lbox";
            this.msg_lbox.Size = new System.Drawing.Size(536, 292);
            this.msg_lbox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 521);
            this.Controls.Add(this.msg_lbox);
            this.Controls.Add(this.json_tbox);
            this.Controls.Add(this.toJson_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logLevel_tbox);
            this.Controls.Add(this.clearACache_cb);
            this.Controls.Add(this.updatePermissions_cb);
            this.Controls.Add(this.uploadLogFile_cb);
            this.Controls.Add(this.writeLog_cb);
            this.Controls.Add(this.isDebug_cb);
            this.Controls.Add(this.checkUpgrade_cb);
            this.Controls.Add(this.checkVersion_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userCode_tbox);
            this.Controls.Add(this.corpCode_tbox);
            this.Controls.Add(this.push_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button push_btn;
        private System.Windows.Forms.TextBox corpCode_tbox;
        private System.Windows.Forms.TextBox userCode_tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkVersion_cb;
        private System.Windows.Forms.CheckBox checkUpgrade_cb;
        private System.Windows.Forms.CheckBox isDebug_cb;
        private System.Windows.Forms.CheckBox writeLog_cb;
        private System.Windows.Forms.CheckBox uploadLogFile_cb;
        private System.Windows.Forms.CheckBox updatePermissions_cb;
        private System.Windows.Forms.CheckBox clearACache_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox logLevel_tbox;
        private System.Windows.Forms.Button toJson_btn;
        private System.Windows.Forms.TextBox json_tbox;
        private System.Windows.Forms.ListBox msg_lbox;
    }
}

