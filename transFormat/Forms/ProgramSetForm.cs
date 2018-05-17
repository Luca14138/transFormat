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
    public partial class ProgramSetForm : Form
    {
        public ProgramSetForm()
        {
            InitializeComponent();
        }

        private void btn_Roche_Set_Click(object sender, EventArgs e)
        {
            Global.RocheOrderPath = this.tb_Roche_Order.Text;
            Global.RocheResultPath = this.tb_Roche_Result.Text;
            Global.RocheSeenPath = this.tb_Roche_Seen.Text;

            Sqlite msqlite = new Sqlite(Global.dbpath);
            string sql1 = "UPDATE SharedFile SET PATH = @RocheOrderPath WHERE NAME = 'Roche_Order'";
            string sql2 = "UPDATE SharedFile SET PATH = @RocheResultPath WHERE NAME = 'Roche_Result'";
            string sql3 = "UPDATE SharedFile SET PATH = @RocheSeenPath WHERE NAME = 'Roche_Seen'";

            Dictionary<string, object> param1 = new Dictionary<string, object>();
            Dictionary<string, object> param2 = new Dictionary<string, object>();
            Dictionary<string, object> param3 = new Dictionary<string, object>();

            param1.Add("@RocheOrderPath", Global.RocheOrderPath);
            param2.Add("@RocheResultPath", Global.RocheResultPath);
            param3.Add("@RocheSeenPath", Global.RocheSeenPath);

            try
            {
                msqlite.query(sql1, param1);
                msqlite.query(sql2, param2);
                msqlite.query(sql3, param3);
                MessageBox.Show("保存成功！");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_LIS_Set_Click(object sender, EventArgs e)
        {
            Global.LISOrderPath = this.tb_LIS_Order.Text;
            Global.LISResultPath = this.tb_LIS_Result.Text;
            Global.LISSeenPath = this.tb_LIS_Seen.Text;

            Sqlite msqlite = new Sqlite(Global.dbpath);
            string sql1 = "UPDATE SharedFile SET PATH = @LISOrderPath WHERE NAME = 'LIS_Order'";
            string sql2 = "UPDATE SharedFile SET PATH = @LISResultPath WHERE NAME = 'LIS_Result'";
            string sql3 = "UPDATE SharedFile SET PATH = @LISSeenPath WHERE NAME = 'LIS_Seen'";

            Dictionary<string, object> param1 = new Dictionary<string, object>();
            Dictionary<string, object> param2 = new Dictionary<string, object>();
            Dictionary<string, object> param3 = new Dictionary<string, object>();

            param1.Add("@LISOrderPath", Global.LISOrderPath);
            param2.Add("@LISResultPath", Global.LISResultPath);
            param3.Add("@LISSeenPath", Global.LISSeenPath);

            try
            {
                msqlite.query(sql1, param1);
                msqlite.query(sql2, param2);
                msqlite.query(sql3, param3);
                MessageBox.Show("保存成功！");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
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

        private void ProgramSetForm_Load(object sender, EventArgs e)
        {
            //Roche
            this.tb_Roche_Order.Text = Global.RocheOrderPath;
            this.tb_Roche_Result.Text = Global.RocheResultPath;
            this.tb_Roche_Seen.Text = Global.RocheSeenPath;

            //LIS
            this.tb_LIS_Order.Text = Global.LISOrderPath;
            this.tb_LIS_Result.Text = Global.LISResultPath;
            this.tb_LIS_Seen.Text = Global.LISResultPath;
        }

        private void tb_Roche_Order_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Roche_Order共享文件夹路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Global.RocheOrderPath = dialog.SelectedPath;
                this.tb_Roche_Order.Text = dialog.SelectedPath;
            }
        }

        private void tb_Roche_Result_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Roche_Result共享文件夹路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Global.RocheResultPath = dialog.SelectedPath;
                this.tb_Roche_Result.Text = dialog.SelectedPath;
            }
        }

        private void tb_Roche_Seen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Roche_Seen共享文件夹路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Global.RocheSeenPath = dialog.SelectedPath;
                this.tb_Roche_Seen.Text = dialog.SelectedPath;
            }
        }

        private void tb_LIS_Order_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择LIS_Order共享文件夹路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Global.LISOrderPath = dialog.SelectedPath;
                this.tb_LIS_Order.Text = dialog.SelectedPath;
            }
        }

        private void tb_LIS_Result_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择LIS_Result共享文件夹路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Global.LISResultPath = dialog.SelectedPath;
                this.tb_LIS_Result.Text = dialog.SelectedPath;
            }
        }

        private void tb_LIS_Seen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择LIS_Seen共享文件夹路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Global.LISSeenPath = dialog.SelectedPath;
                this.tb_LIS_Seen.Text = dialog.SelectedPath;
            }
        }

        private void tsmi_format_IO_Click(object sender, EventArgs e)
        {
            this.Hide();
            RulePathSetForm objForm = new RulePathSetForm();
            objForm.Show();
        }
    }
}
