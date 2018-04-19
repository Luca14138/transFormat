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
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            this.groupBox_Parse.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnParse
            // 
            this.btnParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParse.Location = new System.Drawing.Point(578, 13);
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
            this.treeListView1.Location = new System.Drawing.Point(12, 225);
            this.treeListView1.Margin = new System.Windows.Forms.Padding(5);
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.ShowGroups = false;
            this.treeListView1.Size = new System.Drawing.Size(632, 188);
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
            this.lblMessageType.Location = new System.Drawing.Point(8, 201);
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
            this.lblMessageVersion.Location = new System.Drawing.Point(623, 201);
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
            this.tbMessage.Size = new System.Drawing.Size(632, 148);
            this.tbMessage.TabIndex = 9;
            this.tbMessage.WordWrap = false;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            // 
            // tbVersion
            // 
            this.tbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVersion.Location = new System.Drawing.Point(527, 15);
            this.tbVersion.Margin = new System.Windows.Forms.Padding(5);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(41, 31);
            this.tbVersion.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 18);
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
            this.checkBoxEmptyFields.Location = new System.Drawing.Point(230, 17);
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
            this.groupBox_Parse.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Parse.Name = "groupBox_Parse";
            this.groupBox_Parse.Size = new System.Drawing.Size(652, 547);
            this.groupBox_Parse.TabIndex = 13;
            this.groupBox_Parse.TabStop = false;
            this.groupBox_Parse.Text = "消息解析";
            // 
            // ParseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 425);
            this.Controls.Add(this.groupBox_Parse);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ParseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HL7 Parse";
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.groupBox_Parse.ResumeLayout(false);
            this.groupBox_Parse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEmptyFields;
        private System.Windows.Forms.GroupBox groupBox_Parse;
    }
}