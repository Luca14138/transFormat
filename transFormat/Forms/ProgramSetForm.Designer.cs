namespace transFormat
{
    partial class ProgramSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramSetForm));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_LIS_Set = new System.Windows.Forms.Button();
            this.tb_LIS_Seen = new System.Windows.Forms.TextBox();
            this.tb_LIS_Result = new System.Windows.Forms.TextBox();
            this.tb_LIS_Order = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Roche_Set = new System.Windows.Forms.Button();
            this.tb_Roche_Seen = new System.Windows.Forms.TextBox();
            this.tb_Roche_Result = new System.Windows.Forms.TextBox();
            this.tb_Roche_Order = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(778, 32);
            this.menuStrip1.TabIndex = 3;
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
            this.tsmi_format_set.Click += new System.EventHandler(this.tsmi_format_set_Click);
            // 
            // tsmi_format_IO
            // 
            this.tsmi_format_IO.Name = "tsmi_format_IO";
            this.tsmi_format_IO.Size = new System.Drawing.Size(210, 30);
            this.tsmi_format_IO.Text = "格式导入";
            this.tsmi_format_IO.Click += new System.EventHandler(this.tsmi_format_IO_Click);
            // 
            // tsmi_programset
            // 
            this.tsmi_programset.Name = "tsmi_programset";
            this.tsmi_programset.Size = new System.Drawing.Size(210, 30);
            this.tsmi_programset.Text = "软件设置";
            this.tsmi_programset.Click += new System.EventHandler(this.tsmi_programset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(778, 29);
            this.statusStrip1.TabIndex = 17;
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
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 502);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "共享文件夹位置";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_LIS_Set);
            this.groupBox3.Controls.Add(this.tb_LIS_Seen);
            this.groupBox3.Controls.Add(this.tb_LIS_Result);
            this.groupBox3.Controls.Add(this.tb_LIS_Order);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(24, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(598, 168);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LIS";
            // 
            // btn_LIS_Set
            // 
            this.btn_LIS_Set.Location = new System.Drawing.Point(486, 25);
            this.btn_LIS_Set.Name = "btn_LIS_Set";
            this.btn_LIS_Set.Size = new System.Drawing.Size(79, 38);
            this.btn_LIS_Set.TabIndex = 6;
            this.btn_LIS_Set.Text = "保存";
            this.btn_LIS_Set.UseVisualStyleBackColor = true;
            this.btn_LIS_Set.Click += new System.EventHandler(this.btn_LIS_Set_Click);
            // 
            // tb_LIS_Seen
            // 
            this.tb_LIS_Seen.Location = new System.Drawing.Point(102, 102);
            this.tb_LIS_Seen.Name = "tb_LIS_Seen";
            this.tb_LIS_Seen.Size = new System.Drawing.Size(309, 28);
            this.tb_LIS_Seen.TabIndex = 5;
            this.tb_LIS_Seen.Click += new System.EventHandler(this.tb_LIS_Seen_Click);
            // 
            // tb_LIS_Result
            // 
            this.tb_LIS_Result.Location = new System.Drawing.Point(102, 64);
            this.tb_LIS_Result.Name = "tb_LIS_Result";
            this.tb_LIS_Result.Size = new System.Drawing.Size(309, 28);
            this.tb_LIS_Result.TabIndex = 4;
            this.tb_LIS_Result.Click += new System.EventHandler(this.tb_LIS_Result_Click);
            // 
            // tb_LIS_Order
            // 
            this.tb_LIS_Order.Location = new System.Drawing.Point(102, 25);
            this.tb_LIS_Order.Name = "tb_LIS_Order";
            this.tb_LIS_Order.Size = new System.Drawing.Size(309, 28);
            this.tb_LIS_Order.TabIndex = 3;
            this.tb_LIS_Order.Click += new System.EventHandler(this.tb_LIS_Order_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Order";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Roche_Set);
            this.groupBox2.Controls.Add(this.tb_Roche_Seen);
            this.groupBox2.Controls.Add(this.tb_Roche_Result);
            this.groupBox2.Controls.Add(this.tb_Roche_Order);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(24, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 161);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roche";
            // 
            // btn_Roche_Set
            // 
            this.btn_Roche_Set.Location = new System.Drawing.Point(486, 25);
            this.btn_Roche_Set.Name = "btn_Roche_Set";
            this.btn_Roche_Set.Size = new System.Drawing.Size(81, 38);
            this.btn_Roche_Set.TabIndex = 6;
            this.btn_Roche_Set.Text = "保存";
            this.btn_Roche_Set.UseVisualStyleBackColor = true;
            this.btn_Roche_Set.Click += new System.EventHandler(this.btn_Roche_Set_Click);
            // 
            // tb_Roche_Seen
            // 
            this.tb_Roche_Seen.Location = new System.Drawing.Point(102, 102);
            this.tb_Roche_Seen.Name = "tb_Roche_Seen";
            this.tb_Roche_Seen.Size = new System.Drawing.Size(309, 28);
            this.tb_Roche_Seen.TabIndex = 5;
            this.tb_Roche_Seen.Click += new System.EventHandler(this.tb_Roche_Seen_Click);
            // 
            // tb_Roche_Result
            // 
            this.tb_Roche_Result.Location = new System.Drawing.Point(102, 64);
            this.tb_Roche_Result.Name = "tb_Roche_Result";
            this.tb_Roche_Result.Size = new System.Drawing.Size(309, 28);
            this.tb_Roche_Result.TabIndex = 4;
            this.tb_Roche_Result.Click += new System.EventHandler(this.tb_Roche_Result_Click);
            // 
            // tb_Roche_Order
            // 
            this.tb_Roche_Order.Location = new System.Drawing.Point(102, 25);
            this.tb_Roche_Order.Name = "tb_Roche_Order";
            this.tb_Roche_Order.Size = new System.Drawing.Size(309, 28);
            this.tb_Roche_Order.TabIndex = 3;
            this.tb_Roche_Order.Click += new System.EventHandler(this.tb_Roche_Order_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order";
            // 
            // ProgramSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ProgramSetForm";
            this.Text = "HL7格式转换器-软件设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgramSetForm_FormClosed);
            this.Load += new System.EventHandler(this.ProgramSetForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem tsmi_format_set;
        private System.Windows.Forms.ToolStripMenuItem tsmi_format_IO;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Roche_Set;
        private System.Windows.Forms.TextBox tb_Roche_Seen;
        private System.Windows.Forms.TextBox tb_Roche_Result;
        private System.Windows.Forms.TextBox tb_Roche_Order;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_LIS_Set;
        private System.Windows.Forms.TextBox tb_LIS_Seen;
        private System.Windows.Forms.TextBox tb_LIS_Result;
        private System.Windows.Forms.TextBox tb_LIS_Order;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem tsmi_programset;
    }
}