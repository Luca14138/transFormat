using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace transFormat
{
    public partial class RulePathSetForm : Form
    {
        public RulePathSetForm()
        {
            InitializeComponent();
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
            SearchForm objForm = new SearchForm();
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

        private void tsmi_format_set_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormatSetForm objForm = new FormatSetForm();
            objForm.Show();
        }

        private void tsmi_programset_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProgramSetForm objForm = new ProgramSetForm();
            objForm.Show();
        }

        private void ProgramSetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void tb_Order_RuleFile_Click(object sender, EventArgs e)
        {
            string filename = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择要导入的ORM_O01规则";
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {               
                FileInfo mOldfile = new FileInfo(Global.ORM_O01rulepath);
                string backrule = Global.rulebackpath + "\\ORM_O01_" + DateTime.Now.ToString("yyyy-MM-dd")+"_"+ DateTime.Now.Hour.ToString()+"_"+ DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() +".txt";
                mOldfile.MoveTo(backrule);

                filename = openFileDialog.FileName;
                FileInfo myfile = new FileInfo(filename);
                myfile.MoveTo(Global.ORM_O01rulepath);

                this.tb_Order_RuleFile.Text = "ORM_O01";
            }
            
        }

        private void tb_Result_RuleFile_Click(object sender, EventArgs e)
        {
            string filename = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择要导入的ORU_R01规则";
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo mOldfile = new FileInfo(Global.ORU_R01rulepath);
                string backrule = Global.rulebackpath + "\\ORU_R01_" + DateTime.Now.ToString("yyyy-MM-dd") + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".txt";
                mOldfile.MoveTo(backrule);

                filename = openFileDialog.FileName;
                FileInfo myfile = new FileInfo(filename);
                myfile.MoveTo(Global.ORU_R01rulepath);

                this.tb_Result_RuleFile.Text = "ORU_R01";
            }
            
        }

        private void tb_Seen_RuleFile_Click(object sender, EventArgs e)
        {
            string filename = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择要导入的SSU_U03规则";
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo mOldfile = new FileInfo(Global.SSU_U03rulepath);
                string backrule = Global.rulebackpath + "\\SSU_U03_" + DateTime.Now.ToString("yyyy-MM-dd") + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".txt";
                mOldfile.MoveTo(backrule);

                filename = openFileDialog.FileName;
                FileInfo myfile = new FileInfo(filename);
                myfile.MoveTo(Global.SSU_U03rulepath);

                this.tb_Seen_RuleFile.Text = "SSU_U03";
            }
            
        }

        private void bt_saveRuleFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("保存成功");
        }
    }
}
