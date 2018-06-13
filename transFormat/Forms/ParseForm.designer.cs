// -----------------------------------------------------------------------
// <copyright file="MainForm.Designer.cs" company="Veraida Pty Ltd">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace transFormat
{
    /// <summary>
    /// The MainForm designer partial - describes all of the visual components on the form.
    /// </summary>
    public partial class ParseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnParse;

        private BrightIdeasSoftware.HeaderFormatStyle headerFormatStyle1;

        private BrightIdeasSoftware.TreeListView treeListView1;

        private BrightIdeasSoftware.OLVColumn colName;

        private BrightIdeasSoftware.OLVColumn colId;

        private BrightIdeasSoftware.OLVColumn colValue;

        private System.Windows.Forms.Label lblMessageType;

        private System.Windows.Forms.Label lblMessageVersion;

        private System.Windows.Forms.TextBox tbMessage;

        private System.Windows.Forms.TextBox tbVersion;

        private System.Windows.Forms.Label label1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle1 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle2 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle3 = new BrightIdeasSoftware.HeaderStateStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParseForm));
            this.btnParse = new System.Windows.Forms.Button();
            this.headerFormatStyle1 = new BrightIdeasSoftware.HeaderFormatStyle();
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colValue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblMessageType = new System.Windows.Forms.Label();
            this.lblMessageVersion = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxEmptyFields = new System.Windows.Forms.CheckBox();
            this.groupBox_Parse = new System.Windows.Forms.GroupBox();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            this.groupBox_Parse.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnParse
            // 
            this.btnParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParse.Location = new System.Drawing.Point(665, 13);
            this.btnParse.Margin = new System.Windows.Forms.Padding(5);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(66, 31);
            this.btnParse.TabIndex = 0;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // headerFormatStyle1
            // 
            this.headerFormatStyle1.Hot = headerStateStyle1;
            this.headerFormatStyle1.Normal = headerStateStyle2;
            this.headerFormatStyle1.Pressed = headerStateStyle3;
            // 
            // treeListView1
            // 
            this.treeListView1.AllColumns.Add(this.colName);
            this.treeListView1.AllColumns.Add(this.colId);
            this.treeListView1.AllColumns.Add(this.colValue);
            this.treeListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView1.CellEditUseWholeCell = false;
            this.treeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colId,
            this.colValue});
            this.treeListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListView1.FullRowSelect = true;
            this.treeListView1.GridLines = true;
            this.treeListView1.Location = new System.Drawing.Point(12, 238);
            this.treeListView1.Margin = new System.Windows.Forms.Padding(5);
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.ShowGroups = false;
            this.treeListView1.Size = new System.Drawing.Size(719, 286);
            this.treeListView1.TabIndex = 6;
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
            // lblMessageType
            // 
            this.lblMessageType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessageType.AutoSize = true;
            this.lblMessageType.Location = new System.Drawing.Point(8, 209);
            this.lblMessageType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMessageType.Name = "lblMessageType";
            this.lblMessageType.Size = new System.Drawing.Size(21, 24);
            this.lblMessageType.TabIndex = 7;
            this.lblMessageType.Text = "1";
            this.lblMessageType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMessageVersion
            // 
            this.lblMessageVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessageVersion.AutoSize = true;
            this.lblMessageVersion.Location = new System.Drawing.Point(710, 209);
            this.lblMessageVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMessageVersion.Name = "lblMessageVersion";
            this.lblMessageVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessageVersion.Size = new System.Drawing.Size(21, 24);
            this.lblMessageVersion.TabIndex = 8;
            this.lblMessageVersion.Text = "2";
            this.lblMessageVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.Location = new System.Drawing.Point(12, 53);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(0);
            this.tbMessage.MaximumSize = new System.Drawing.Size(18330, 360);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessage.Size = new System.Drawing.Size(719, 156);
            this.tbMessage.TabIndex = 9;
            this.tbMessage.WordWrap = false;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            // 
            // tbVersion
            // 
            this.tbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVersion.Location = new System.Drawing.Point(614, 15);
            this.tbVersion.Margin = new System.Windows.Forms.Padding(5);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(41, 31);
            this.tbVersion.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Version:";
            // 
            // checkBoxEmptyFields
            // 
            this.checkBoxEmptyFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEmptyFields.AutoSize = true;
            this.checkBoxEmptyFields.Location = new System.Drawing.Point(317, 17);
            this.checkBoxEmptyFields.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxEmptyFields.Name = "checkBoxEmptyFields";
            this.checkBoxEmptyFields.Size = new System.Drawing.Size(212, 28);
            this.checkBoxEmptyFields.TabIndex = 12;
            this.checkBoxEmptyFields.Text = "Display Empty fields";
            this.checkBoxEmptyFields.UseVisualStyleBackColor = true;
            // 
            // groupBox_Parse
            // 
            this.groupBox_Parse.Controls.Add(this.btnParse);
            this.groupBox_Parse.Controls.Add(this.tbVersion);
            this.groupBox_Parse.Controls.Add(this.label1);
            this.groupBox_Parse.Controls.Add(this.checkBoxEmptyFields);
            this.groupBox_Parse.Controls.Add(this.tbMessage);
            this.groupBox_Parse.Controls.Add(this.lblMessageVersion);
            this.groupBox_Parse.Controls.Add(this.treeListView1);
            this.groupBox_Parse.Controls.Add(this.lblMessageType);
            this.groupBox_Parse.Location = new System.Drawing.Point(12, 35);
            this.groupBox_Parse.Name = "groupBox_Parse";
            this.groupBox_Parse.Size = new System.Drawing.Size(739, 532);
            this.groupBox_Parse.TabIndex = 13;
            this.groupBox_Parse.TabStop = false;
            this.groupBox_Parse.Text = "消息解析";
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
            this.menuStrip1.Size = new System.Drawing.Size(763, 32);
            this.menuStrip1.TabIndex = 14;
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
            this.tsmi_format_set.Size = new System.Drawing.Size(164, 30);
            this.tsmi_format_set.Text = "格式设置";
            this.tsmi_format_set.Click += new System.EventHandler(this.tsmi_format_set_Click);
            // 
            // tsmi_format_IO
            // 
            this.tsmi_format_IO.Name = "tsmi_format_IO";
            this.tsmi_format_IO.Size = new System.Drawing.Size(164, 30);
            this.tsmi_format_IO.Text = "格式导入";
            this.tsmi_format_IO.Click += new System.EventHandler(this.tsmi_format_IO_Click);
            // 
            // tsmi_programset
            // 
            this.tsmi_programset.Name = "tsmi_programset";
            this.tsmi_programset.Size = new System.Drawing.Size(164, 30);
            this.tsmi_programset.Text = "软件设置";
            this.tsmi_programset.Click += new System.EventHandler(this.tsmi_programset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(763, 29);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "当前版本号1.0.0.1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 24);
            this.toolStripStatusLabel1.Text = "当前版本1.0.1";
            // 
            // ParseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 599);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox_Parse);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ParseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HL7消息转换器-消息解析";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParseForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.groupBox_Parse.ResumeLayout(false);
            this.groupBox_Parse.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEmptyFields;
        private System.Windows.Forms.GroupBox groupBox_Parse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_message;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mes_brief;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mes_parse;
        private System.Windows.Forms.ToolStripMenuItem tsmi_format;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_format_set;
        private System.Windows.Forms.ToolStripMenuItem tsmi_format_IO;
        private System.Windows.Forms.ToolStripMenuItem tsmi_programset;
    }
}