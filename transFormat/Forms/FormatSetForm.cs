using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Global;
using System.IO;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using System.Text.RegularExpressions;

namespace transFormat
{
    public partial class FormatSetForm : Form
    {
        public FormatSetForm()
        {
            InitializeComponent();
            this.InitializeTreeList();

            createitem(Global.Global.rulepath);//注意这两个函数的次序不能颠倒，因为createitem里有一句命令listView1.clear()
            //                  把所有的列名也都删除了，如果createheader在前，listview就没有列名了。
            this.createHeader();
        }


        #region ListView
        private System.Collections.Specialized.StringCollection colstr = new System.Collections.Specialized.StringCollection();

        private void createHeader()//为listview添加列名
        {
            ColumnHeader ch = new ColumnHeader();
            ch.Text = "文件名";
            this.listView1.Columns.Add(ch);

            ch = new ColumnHeader();
            ch.Text = "大小";
            this.listView1.Columns.Add(ch);

            ch = new ColumnHeader();
            ch.Text = "修改日期";
            this.listView1.Columns.Add(ch);

        }

        private void createitem(string root)
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(root);
            System.IO.DirectoryInfo[] dirs = dir.GetDirectories();
            System.IO.FileInfo[] files = dir.GetFiles();

            listView1.Clear();//注意这个函数是把listview里的所有选项与所列名都删除

            listView1.BeginUpdate();

            foreach (System.IO.DirectoryInfo di in dirs)
            {
                lvi = new ListViewItem();
                lvi.Text = di.Name;
                lvi.Tag = di.FullName;
                lvi.ImageIndex = 0;

                lvsi = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                lvsi.Text = "";
                lvi.SubItems.Add(lvsi);

                lvsi = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                lvsi.Text = di.LastAccessTime.ToString();
                lvi.SubItems.Add(lvsi);

                this.listView1.Items.Add(lvi);
            }
            foreach (System.IO.FileInfo fi in files)//把文件信息添加到listview的选项中
            {
                lvi = new ListViewItem();
                lvi.Text = fi.Name;
                lvi.ImageIndex = 1;
                lvi.Tag = fi.FullName;

                lvsi = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                lvsi.Text = fi.Length.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                lvsi.Text = fi.LastAccessTime.ToString();

                lvi.SubItems.Add(lvsi);

                this.listView1.Items.Add(lvi);

            }
            this.listView1.EndUpdate();
        }

        private void listView1_ItemActivate(object sender, System.EventArgs e)
        {
            ListView lv = (ListView)sender;
            string filename = lv.SelectedItems[0].Tag.ToString();

            if (lv.SelectedItems[0].ImageIndex == 0)//如果是文件夹，就打开它
            {
                createitem(filename);
                createHeader();
                colstr.Add(filename);//把打开的方件夹的路径记录下来，这里是因为我们现在的路径是已知的，不用记录。
            }
            else//如果是文件，就执行它
            {
                //System.Diagnostics.Process.Start(filename);
                //MessageBox.Show(filename);
                try
                {
                    using (StreamReader sr = new StreamReader(filename))
                    {
                        String ruleMessage = sr.ReadToEnd();
                        textBox_rule.Text = ruleMessage;
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    Console.WriteLine("发生错误");
                }
            }
        }

        #endregion

        /// <summary>
        /// Handles the Click event of the btnParse control.
        /// Retreives the HL7 from the text box and attempts to parse it using NHapi.
        /// If successfull, it retreives all of the fields and displays them in the TreeListView
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button_parse_Click(object sender, EventArgs e)
        {
            try
            {
                string hl7 = this.tbMessage.Text;

                PipeParser parser = new PipeParser();
                IMessage hl7Message;
                hl7Message = parser.Parse(hl7);

                if (hl7Message != null)
                {
                    this.lblMessageType.Text = hl7Message.GetStructureName();
                    this.lblMessageVersion.Text = hl7Message.Version;

                    FieldGroup messageGroup = new FieldGroup() { Name = hl7Message.GetStructureName() };
                    this.ProcessStructureGroup((AbstractGroup)hl7Message, messageGroup);

                    this.treeListView1.Objects = messageGroup.FieldList;
                    this.treeListView1.ExpandAll();

                    this.showFieldGroup(messageGroup);                 

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #region Hl7Parsing functions

        /// <summary>
        /// Processes a structure group.
        /// A structure group is, primarily, a group of segments.  This could either be the entire
        /// message or special segments that need to be grouped together.  An example of this is
        /// the result segments (OBR, OBX and NTE), these are grouped together in the model
        /// definition (e.g. REF_I12_RESULTS_NOTES).
        /// </summary>
        /// <param name="structureGroup">The structure group.</param>
        /// <param name="parentNode">The parent node, in the TreeListView.</param>
        private void ProcessStructureGroup(AbstractGroup structureGroup, FieldGroup parentNode)
        {
            foreach (string segName in structureGroup.Names)
            {
                //MessageBox.Show(segName);
                foreach (IStructure struc in structureGroup.GetAll(segName))
                {
                    //MessageBox.Show(struc.GetType().ToString());
                    this.ProcessStructure(struc, parentNode);
                }
            }
        }

        /// <summary>
        /// Processes the structure.
        /// A base structure can be either a segment, or segment group. This function
        /// determines which it is before passing it on.
        /// </summary>
        /// <param name="structure">The structure.</param>
        /// <param name="parentNode">The parent node, in the TreeListView.</param>
        private void ProcessStructure(IStructure structure, FieldGroup parentNode)
        {
            if (structure.GetType().IsSubclassOf(typeof(AbstractSegment)))
            {
                AbstractSegment seg = (AbstractSegment)structure;
                this.ProcessSegment(seg, parentNode);
            }
            else if (structure.GetType().IsSubclassOf(typeof(AbstractGroup)))
            {
                AbstractGroup structureGroup = (AbstractGroup)structure;
                this.ProcessStructureGroup(structureGroup, parentNode);
            }
            else
            {
                parentNode.FieldList.Add(new Field() { Name = "Something Else!!!" });
            }
        }

        /// <summary>
        /// Processes the segment.
        /// Loops through all of the fields within the segment, and parsing them individually.
        /// </summary>
        /// <param name="segment">The segment.</param>
        /// <param name="parentNode">The parent node.</param>
        private void ProcessSegment(AbstractSegment segment, FieldGroup parentNode)
        {
            FieldGroup segmentNode = new FieldGroup() { Name = segment.GetStructureName() };
            int dataItemCount = 0;

            for (int i = 1; i <= segment.NumFields(); i++)
            {
                dataItemCount++;
                IType[] dataItems = segment.GetField(i);
                foreach (IType item in dataItems)
                {
                    this.ProcessField(item, segment.GetFieldDescription(i), dataItemCount.ToString(), segmentNode);
                }
            }

            this.AddChildGroup(parentNode, segmentNode);
        }

        /// <summary>
        /// Processes the field.
        /// Determines the type of field, before passing it onto the more specific parsing functions.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="fieldDescription">The field description.</param>
        /// <param name="fieldCount">The field count.</param>
        /// <param name="parentNode">The parent node.</param>
        private void ProcessField(IType item, string fieldDescription, string fieldCount, FieldGroup parentNode)
        {
            if (item.GetType().IsSubclassOf(typeof(AbstractPrimitive)))
            {
                this.ProcessPrimitiveField((AbstractPrimitive)item, fieldDescription, fieldCount, parentNode);
            }
            else if (item.GetType() == typeof(Varies))
            {
                this.ProcessVaries((Varies)item, fieldDescription, fieldCount, parentNode);
            }
            else if (item.GetType().GetInterfaces().Contains(typeof(IComposite)))
            {
                AbstractType dataType = (AbstractType)item;
                string desc = string.IsNullOrEmpty(dataType.Description) ? fieldDescription : dataType.Description;
                this.ProcessCompositeField((IComposite)item, desc, fieldCount, parentNode);
            }
        }

        /// <summary>
        /// Processes the primitive field.
        /// A primitive field is the most basic type (i.e. no composite fields).  This function retrieves the data
        /// and builds the node in the TreeListView.
        /// </summary>
        /// <param name="dataItem">The data item.</param>
        /// <param name="fieldDescription">The field description.</param>
        /// <param name="fieldCount">The field count.</param>
        /// <param name="parentNode">The parent node.</param>
        private void ProcessPrimitiveField(AbstractPrimitive dataItem, string fieldDescription, string fieldCount, FieldGroup parentNode)
        {
            string desc = fieldDescription == string.Empty ? dataItem.Description : fieldDescription;

            if (checkBoxEmptyFields.Checked || !string.IsNullOrEmpty(dataItem.Value))
            {
                parentNode.FieldList.Add(new Field() { Name = desc, Id = fieldCount, Value = dataItem.Value });
            }
        }

        /// <summary>
        /// Processes the varies.
        /// "Varies" are the data in the OBX segment, the sending application can set the type hence generically the OBX
        /// value field is a variant type.
        /// The "Varies" data parameter contains the data in type IType (hence being passed back to process field).
        /// </summary>
        /// <param name="varies">The varies.</param>
        /// <param name="fieldDescription">The field description.</param>
        /// <param name="fieldCount">The field count.</param>
        /// <param name="parentNode">The parent node.</param>
        private void ProcessVaries(Varies varies, string fieldDescription, string fieldCount, FieldGroup parentNode)
        {
            this.ProcessField(varies.Data, fieldDescription, fieldCount, parentNode);
        }

        /// <summary>
        /// Processes the composite field.
        /// A composite field is a group of fields, such as "Coded Entry".
        /// This function breaks up the composite field and passes each field back to "ProcessField"
        /// </summary>
        /// <param name="composite">The composite.</param>
        /// <param name="fieldDescription">The field description.</param>
        /// <param name="fieldCount">The field count.</param>
        /// <param name="parentNode">The parent node.</param>
        private void ProcessCompositeField(IComposite composite, string fieldDescription, string fieldCount, FieldGroup parentNode)
        {
            FieldGroup subParent = new FieldGroup() { Name = fieldDescription, Id = fieldCount };

            int subItemCount = 0;
            foreach (IType subItem in composite.Components)
            {
                subItemCount++;
                this.ProcessField(subItem, string.Empty, subItemCount.ToString(), subParent);
            }

            this.AddChildGroup(parentNode, subParent);
        }

        #endregion Hl7Parsing functions

        /// <summary>
        /// Adds the child group, to the parent node, only if the child group acutally contains fields.
        /// </summary>
        /// <param name="parentNode">The parent node.</param>
        /// <param name="childGroup">The child group.</param>
        private void AddChildGroup(FieldGroup parentNode, FieldGroup childGroup)
        {
            if (childGroup.FieldList.Count > 0)
            {
                parentNode.FieldList.Add(childGroup);
            }
        }

        /// <summary>
        /// 初始化tree list.
        /// </summary>
        private void InitializeTreeList()
        {
            this.treeListView1.CanExpandGetter = delegate (object x)
            {
                return x is FieldGroup;
            };
            this.treeListView1.ChildrenGetter = delegate (object x)
            {
                FieldGroup grp = (FieldGroup)x;
                return grp.FieldList;
            };
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            this.tbMessage.Text = this.CorrectLineFeeds(this.tbMessage.Text);
        }

        /// <summary>
        /// 处理换行符
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private string CorrectLineFeeds(string message)
        {
            if (Regex.IsMatch(message, "([^\r])\n"))
            {
                return Regex.Replace(message, "([^\r])\n", "$1\r\n");
            }
            if (Regex.IsMatch(message, "\r([^\n])"))
            {
                return Regex.Replace(message, "\r([^\n])", "\r\n$1");
            }
            return message;
        }

        //遍历FieldGroup
        private void showFieldGroup(FieldGroup fieldgroup)
        {
            foreach (var m in fieldgroup.FieldList)
            {
                if (m is FieldGroup)
                {
                    showFieldGroup((FieldGroup)m);
                }
                else if (m is Field)
                {
                    Console.WriteLine(((Field)m).Name + " " + ((Field)m).Id + " " + ((Field)m).Value);
                    //Console.WriteLine(((Field)m).Id);
                    //Console.WriteLine(((Field)m).Value);
                }
            }
        }

        private void tsmi_format_set_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormatSetForm objForm = new FormatSetForm();
            objForm.Show();
        }

        // 文件/退出
        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        //样本总览
        private void tsmi_mes_brief_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm objForm = new transFormat.SearchForm();
            objForm.Show();
        }

        // 消息解析
        private void tsmi_mes_parse_Click(object sender, EventArgs e)
        {
            ParseForm objForm = new ParseForm();
            this.Hide();
            objForm.Show();
            //this.OpenForm(objForm);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (colstr.Count > 1)
            {
                createitem(colstr[colstr.Count - 2]);
                colstr.RemoveAt(colstr.Count - 1);
                createHeader();
            }
            else if (colstr.Count == 1)
            {
                createitem(Global.Global.rulepath);
                createHeader();
                colstr.Clear();
            }
        }

        private void button_add_rule_Click(object sender, EventArgs e)
        {
            StreamWriter myStream;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "请选择b保存位置";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            saveFileDialog1.FilterIndex = 2;

            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)

            {

                myStream = new StreamWriter(saveFileDialog1.FileName);

                myStream.Write(textBox_rule.Text); //写入

                myStream.Close();//关闭流

            }
        }
    }
}
