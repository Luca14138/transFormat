namespace transFormat
{
    partial class FormatSetForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormatSetForm));
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colValue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button_add_rule = new System.Windows.Forms.Button();
            this.button_parse = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxEmptyFields = new System.Windows.Forms.CheckBox();
            this.button_back = new System.Windows.Forms.Button();
            this.button_modify_rule = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox_rule = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblMessageType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMessageVersion = new System.Windows.Forms.Label();
            this.tsmi_programset = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1347, 32);
            this.menuStrip1.TabIndex = 2;
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
            this.tsmi_format.Size = new System.Drawing.Size(58, 28);
            this.tsmi_format.Text = "格式";
            // 
            // tsmi_format_set
            // 
            this.tsmi_format_set.Name = "tsmi_format_set";
            this.tsmi_format_set.Size = new System.Drawing.Size(210, 30);
            this.tsmi_format_set.Text = "格式设置";
            // 
            // tsmi_format_IO
            // 
            this.tsmi_format_IO.Name = "tsmi_format_IO";
            this.tsmi_format_IO.Size = new System.Drawing.Size(210, 30);
            this.tsmi_format_IO.Text = "格式导入";
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 782);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1347, 29);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "当前版本号1.0.0.1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 24);
            this.toolStripStatusLabel1.Text = "当前版本1.0.1";
            // 
            // tbMessage
            // 
            this.tbMessage.AllowDrop = true;
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.Location = new System.Drawing.Point(13, 24);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(0);
            this.tbMessage.MaximumSize = new System.Drawing.Size(18330, 360);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(564, 300);
            this.tbMessage.TabIndex = 10;
            this.tbMessage.WordWrap = false;
            // 
            // treeListView1
            // 
            this.treeListView1.AllColumns.Add(this.colName);
            this.treeListView1.AllColumns.Add(this.colId);
            this.treeListView1.AllColumns.Add(this.colValue);
            this.treeListView1.CellEditUseWholeCell = false;
            this.treeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colId,
            this.colValue});
            this.treeListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListView1.FullRowSelect = true;
            this.treeListView1.GridLines = true;
            this.treeListView1.Location = new System.Drawing.Point(3, 24);
            this.treeListView1.Margin = new System.Windows.Forms.Padding(5);
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.ShowGroups = false;
            this.treeListView1.Size = new System.Drawing.Size(579, 377);
            this.treeListView1.TabIndex = 7;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.View = System.Windows.Forms.View.Details;
            this.treeListView1.VirtualMode = true;
            // 
            // colName
            // 
            this.colName.AspectName = "Name";
            this.colName.Text = "Name";
            this.colName.Width = 217;
            // 
            // colId
            // 
            this.colId.AspectName = "Id";
            this.colId.Text = "Id";
            // 
            // colValue
            // 
            this.colValue.AspectName = "Value";
            this.colValue.FillsFreeSpace = true;
            this.colValue.Text = "Value";
            this.colValue.Width = 180;
            // 
            // button_add_rule
            // 
            this.button_add_rule.Location = new System.Drawing.Point(6, 103);
            this.button_add_rule.Name = "button_add_rule";
            this.button_add_rule.Size = new System.Drawing.Size(98, 35);
            this.button_add_rule.TabIndex = 19;
            this.button_add_rule.Text = "添加规则";
            this.button_add_rule.UseVisualStyleBackColor = true;
            this.button_add_rule.Click += new System.EventHandler(this.button_add_rule_Click);
            // 
            // button_parse
            // 
            this.button_parse.Location = new System.Drawing.Point(6, 65);
            this.button_parse.Name = "button_parse";
            this.button_parse.Size = new System.Drawing.Size(98, 32);
            this.button_parse.TabIndex = 20;
            this.button_parse.Text = "解析";
            this.button_parse.UseVisualStyleBackColor = true;
            this.button_parse.Click += new System.EventHandler(this.button_parse_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.checkBoxEmptyFields);
            this.groupBox3.Controls.Add(this.button_back);
            this.groupBox3.Controls.Add(this.button_modify_rule);
            this.groupBox3.Controls.Add(this.button_add_rule);
            this.groupBox3.Controls.Add(this.button_parse);
            this.groupBox3.Location = new System.Drawing.Point(12, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 431);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "功能";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 23;
            this.button1.Text = "删除规则";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmptyFields
            // 
            this.checkBoxEmptyFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEmptyFields.AutoSize = true;
            this.checkBoxEmptyFields.Location = new System.Drawing.Point(8, 228);
            this.checkBoxEmptyFields.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxEmptyFields.Name = "checkBoxEmptyFields";
            this.checkBoxEmptyFields.Size = new System.Drawing.Size(106, 22);
            this.checkBoxEmptyFields.TabIndex = 13;
            this.checkBoxEmptyFields.Text = "显示空值";
            this.checkBoxEmptyFields.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(6, 27);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(98, 32);
            this.button_back.TabIndex = 22;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_modify_rule
            // 
            this.button_modify_rule.Location = new System.Drawing.Point(6, 144);
            this.button_modify_rule.Name = "button_modify_rule";
            this.button_modify_rule.Size = new System.Drawing.Size(98, 35);
            this.button_modify_rule.TabIndex = 21;
            this.button_modify_rule.Text = "修改规则";
            this.button_modify_rule.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(509, 302);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // textBox_rule
            // 
            this.textBox_rule.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_rule.Location = new System.Drawing.Point(12, 21);
            this.textBox_rule.Multiline = true;
            this.textBox_rule.Name = "textBox_rule";
            this.textBox_rule.Size = new System.Drawing.Size(497, 375);
            this.textBox_rule.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(173, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 329);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "规则列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_rule);
            this.groupBox2.Location = new System.Drawing.Point(173, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 404);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "规则";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbMessage);
            this.groupBox4.Location = new System.Drawing.Point(722, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(585, 330);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "原消息";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.treeListView1);
            this.groupBox5.Location = new System.Drawing.Point(722, 371);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(585, 404);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "消息解析";
            // 
            // lblMessageType
            // 
            this.lblMessageType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessageType.AutoSize = true;
            this.lblMessageType.Location = new System.Drawing.Point(99, 489);
            this.lblMessageType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMessageType.Name = "lblMessageType";
            this.lblMessageType.Size = new System.Drawing.Size(17, 18);
            this.lblMessageType.TabIndex = 8;
            this.lblMessageType.Text = "1";
            this.lblMessageType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "消息类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "消息版本：";
            // 
            // lblMessageVersion
            // 
            this.lblMessageVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessageVersion.AutoSize = true;
            this.lblMessageVersion.Location = new System.Drawing.Point(99, 537);
            this.lblMessageVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMessageVersion.Name = "lblMessageVersion";
            this.lblMessageVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessageVersion.Size = new System.Drawing.Size(17, 18);
            this.lblMessageVersion.TabIndex = 34;
            this.lblMessageVersion.Text = "2";
            this.lblMessageVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsmi_programset
            // 
            this.tsmi_programset.Name = "tsmi_programset";
            this.tsmi_programset.Size = new System.Drawing.Size(210, 30);
            this.tsmi_programset.Text = "软件设置";
            this.tsmi_programset.Click += new System.EventHandler(this.tsmi_programset_Click);
            // 
            // FormatSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1347, 811);
            this.Controls.Add(this.lblMessageVersion);
            this.Controls.Add(this.lblMessageType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormatSetForm";
            this.Text = "HL7消息转换器-格式设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button button_add_rule;
        private System.Windows.Forms.Button button_parse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_modify_rule;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox textBox_rule;
        private System.Windows.Forms.CheckBox checkBoxEmptyFields;
        private BrightIdeasSoftware.TreeListView treeListView1;
        private BrightIdeasSoftware.OLVColumn colName;
        private BrightIdeasSoftware.OLVColumn colId;
        private BrightIdeasSoftware.OLVColumn colValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblMessageType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMessageVersion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_programset;
    }
}