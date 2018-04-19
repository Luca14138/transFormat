namespace transFormat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_message = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mes_brief = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mes_parse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_format = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_message,
            this.tsmi_format});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_file
            // 
            this.tsmi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsmi_exit});
            this.tsmi_file.Name = "tsmi_file";
            this.tsmi_file.Size = new System.Drawing.Size(58, 28);
            this.tsmi_file.Text = "开始";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.Size = new System.Drawing.Size(210, 30);
            this.tsmi_exit.Text = "退出";
            this.tsmi_exit.Click += new System.EventHandler(this.tsmi_exit_Click);
            // 
            // tsmi_message
            // 
            this.tsmi_message.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_mes_brief,
            this.tsmi_mes_parse});
            this.tsmi_message.Name = "tsmi_message";
            this.tsmi_message.Size = new System.Drawing.Size(58, 28);
            this.tsmi_message.Text = "消息";
            // 
            // tsmi_mes_brief
            // 
            this.tsmi_mes_brief.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_mes_brief.Image")));
            this.tsmi_mes_brief.Name = "tsmi_mes_brief";
            this.tsmi_mes_brief.Size = new System.Drawing.Size(210, 30);
            this.tsmi_mes_brief.Text = "样本总览";
            // 
            // tsmi_mes_parse
            // 
            this.tsmi_mes_parse.Name = "tsmi_mes_parse";
            this.tsmi_mes_parse.Size = new System.Drawing.Size(210, 30);
            this.tsmi_mes_parse.Text = "消息解析";
            this.tsmi_mes_parse.Click += new System.EventHandler(this.tsmi_mes_parse_Click);
            // 
            // tsmi_format
            // 
            this.tsmi_format.Name = "tsmi_format";
            this.tsmi_format.Size = new System.Drawing.Size(58, 28);
            this.tsmi_format.Text = "格式";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1017);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(999, 29);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "当前版本号1.0.0.1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 24);
            this.toolStripStatusLabel1.Text = "当前版本1.0.1";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 985);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(999, 1046);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "HL7消息转换器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_message;
        private System.Windows.Forms.ToolStripMenuItem tsmi_format;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mes_brief;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mes_parse;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exit;
        private System.Windows.Forms.Panel panel1;
    }
}

