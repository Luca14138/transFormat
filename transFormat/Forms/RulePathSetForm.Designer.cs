namespace transFormat
{
    partial class RulePathSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulePathSetForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_message = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mes_brief = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mes_parse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_format = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_format_set = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_format_IO = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_programset = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Order_RuleFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Result_RuleFile = new System.Windows.Forms.TextBox();
            this.tb_Seen_RuleFile = new System.Windows.Forms.TextBox();
            this.bt_saveRuleFile = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(757, 29);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "当前版本号1.0.0.1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 24);
            this.toolStripStatusLabel1.Text = "当前版本1.0.1";
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
            this.menuStrip1.Size = new System.Drawing.Size(757, 32);
            this.menuStrip1.TabIndex = 19;
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
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.Size = new System.Drawing.Size(128, 30);
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
            this.tsmi_mes_brief.Size = new System.Drawing.Size(164, 30);
            this.tsmi_mes_brief.Text = "样本总览";
            this.tsmi_mes_brief.Click += new System.EventHandler(this.tsmi_mes_brief_Click);
            // 
            // tsmi_mes_parse
            // 
            this.tsmi_mes_parse.Name = "tsmi_mes_parse";
            this.tsmi_mes_parse.Size = new System.Drawing.Size(164, 30);
            this.tsmi_mes_parse.Text = "消息解析";
            this.tsmi_mes_parse.Click += new System.EventHandler(this.tsmi_mes_parse_Click);
            // 
            // tsmi_format
            // 
            this.tsmi_format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_format_set,
            this.tsmi_format_IO,
            this.tsmi_programset});
            this.tsmi_format.Name = "tsmi_format";
            this.tsmi_format.Size = new System.Drawing.Size(63, 28);
            this.tsmi_format.Text = " 格式";
            // 
            // tsmi_format_set
            // 
            this.tsmi_format_set.Name = "tsmi_format_set";
            this.tsmi_format_set.Size = new System.Drawing.Size(164, 30);
            this.tsmi_format_set.Text = "格式设置";
            this.tsmi_format_set.Click += new System.EventHandler(this.tsmi_format_set_Click);
            // 
            // tsmi_format_IO
            // 
            this.tsmi_format_IO.Name = "tsmi_format_IO";
            this.tsmi_format_IO.Size = new System.Drawing.Size(164, 30);
            this.tsmi_format_IO.Text = "格式导入";
            // 
            // tsmi_programset
            // 
            this.tsmi_programset.Name = "tsmi_programset";
            this.tsmi_programset.Size = new System.Drawing.Size(164, 30);
            this.tsmi_programset.Text = "软件设置";
            this.tsmi_programset.Click += new System.EventHandler(this.tsmi_programset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_saveRuleFile);
            this.groupBox1.Controls.Add(this.tb_Seen_RuleFile);
            this.groupBox1.Controls.Add(this.tb_Result_RuleFile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_Order_RuleFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 469);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "转换规则";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(59, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order";
            // 
            // tb_Order_RuleFile
            // 
            this.tb_Order_RuleFile.Location = new System.Drawing.Point(169, 68);
            this.tb_Order_RuleFile.Name = "tb_Order_RuleFile";
            this.tb_Order_RuleFile.Size = new System.Drawing.Size(244, 28);
            this.tb_Order_RuleFile.TabIndex = 4;
            this.tb_Order_RuleFile.Click += new System.EventHandler(this.tb_Order_RuleFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(59, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(59, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seen";
            // 
            // tb_Result_RuleFile
            // 
            this.tb_Result_RuleFile.Location = new System.Drawing.Point(169, 160);
            this.tb_Result_RuleFile.Name = "tb_Result_RuleFile";
            this.tb_Result_RuleFile.Size = new System.Drawing.Size(244, 28);
            this.tb_Result_RuleFile.TabIndex = 7;
            this.tb_Result_RuleFile.Click += new System.EventHandler(this.tb_Result_RuleFile_Click);
            // 
            // tb_Seen_RuleFile
            // 
            this.tb_Seen_RuleFile.Location = new System.Drawing.Point(169, 260);
            this.tb_Seen_RuleFile.Name = "tb_Seen_RuleFile";
            this.tb_Seen_RuleFile.Size = new System.Drawing.Size(244, 28);
            this.tb_Seen_RuleFile.TabIndex = 8;
            this.tb_Seen_RuleFile.Click += new System.EventHandler(this.tb_Seen_RuleFile_Click);
            // 
            // bt_saveRuleFile
            // 
            this.bt_saveRuleFile.Location = new System.Drawing.Point(519, 68);
            this.bt_saveRuleFile.Name = "bt_saveRuleFile";
            this.bt_saveRuleFile.Size = new System.Drawing.Size(103, 42);
            this.bt_saveRuleFile.TabIndex = 9;
            this.bt_saveRuleFile.Text = "保存";
            this.bt_saveRuleFile.UseVisualStyleBackColor = true;
            this.bt_saveRuleFile.Click += new System.EventHandler(this.bt_saveRuleFile_Click);
            // 
            // RulePathSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "RulePathSetForm";
            this.Text = "HL7格式转换器-格式导入";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgramSetForm_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_message;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mes_brief;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mes_parse;
        private System.Windows.Forms.ToolStripMenuItem tsmi_format;
        private System.Windows.Forms.ToolStripMenuItem tsmi_format_set;
        private System.Windows.Forms.ToolStripMenuItem tsmi_format_IO;
        private System.Windows.Forms.ToolStripMenuItem tsmi_programset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Order_RuleFile;
        private System.Windows.Forms.TextBox tb_Seen_RuleFile;
        private System.Windows.Forms.TextBox tb_Result_RuleFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_saveRuleFile;
    }
}