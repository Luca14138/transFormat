using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace transFormat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Sqlite msqlite = new Sqlite(Global.dbpath);

        private void OpenForm(Form objFrm)
        {
            //将当前子窗体设置成非顶级控件
            objFrm.TopLevel = false;
            //设置窗体最大化
            objFrm.WindowState = FormWindowState.Maximized;
            //去掉窗体边框
            objFrm.FormBorderStyle = FormBorderStyle.None;
            //指定当前子窗体显示的容器
            objFrm.Parent = this.panel1;
            //显示窗体
            objFrm.Show();
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
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

        private void Test_Click(object sender, EventArgs e)
        {
            float a = 5.00f;
            float m = a % 1;
            MessageBox.Show(m.ToString());
        }

        private void tsmi_format_IO_Click(object sender, EventArgs e)
        {
            this.Hide();
            RulePathSetForm objForm = new RulePathSetForm();
            objForm.Show();
        }
    }
}
