namespace transFormat
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboTables = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_mes_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_mes_direc = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(945, 32);
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
            this.tsmi_mes_parse.Size = new System.Drawing.Size(164, 30);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 741);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(945, 29);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "当前版本号1.0.0.1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 24);
            this.toolStripStatusLabel1.Text = "当前版本1.0.1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 636);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "消息总览";
            // 
            // comboTables
            // 
            this.comboTables.FormattingEnabled = true;
            this.comboTables.Location = new System.Drawing.Point(103, 79);
            this.comboTables.Name = "comboTables";
            this.comboTables.Size = new System.Drawing.Size(162, 26);
            this.comboTables.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(909, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_mes_direc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox_mes_type);
            this.groupBox2.Controls.Add(this.comboTables);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.search_button);
            this.groupBox2.Location = new System.Drawing.Point(6, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(909, 222);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询危急值";
            // 
            // comboBox_mes_type
            // 
            this.comboBox_mes_type.FormattingEnabled = true;
            this.comboBox_mes_type.Items.AddRange(new object[] {
            "OrderResults",
            "TestRequests",
            "SampleResult",
            "SampleQuery",
            "SampleEvent"});
            this.comboBox_mes_type.Location = new System.Drawing.Point(103, 26);
            this.comboBox_mes_type.Name = "comboBox_mes_type";
            this.comboBox_mes_type.Size = new System.Drawing.Size(162, 26);
            this.comboBox_mes_type.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "信息名称";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(718, 148);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(146, 55);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "搜索";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "表信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "方向";
            // 
            // comboBox_mes_direc
            // 
            this.comboBox_mes_direc.FormattingEnabled = true;
            this.comboBox_mes_direc.Items.AddRange(new object[] {
            "IN",
            "OUT"});
            this.comboBox_mes_direc.Location = new System.Drawing.Point(103, 121);
            this.comboBox_mes_direc.Name = "comboBox_mes_direc";
            this.comboBox_mes_direc.Size = new System.Drawing.Size(162, 26);
            this.comboBox_mes_direc.TabIndex = 6;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 770);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SearchForm";
            this.Text = "HL7消息转换器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchForm_FormClosed);
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboTables;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_mes_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.ComboBox comboBox_mes_direc;
        private System.Windows.Forms.Label label3;
    }
}