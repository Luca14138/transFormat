using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace transFormat
{
    public partial class SearchForm : Form
    {
        SQLiteDataAdapter mAdapter;
        DataTable mTable;
        //Sqlite msqlite;
        SQLiteConnection mConn;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
            mConn.Close();
        }

        private void tsmi_mes_parse_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParseForm objForm = new ParseForm();
            objForm.Show();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string table = comboTables.Text;
            bool existFilter = false; //是否存在查询条件
            string sql = null;

            if (table != null)
            {
                if(table =="OMessage"|| table == "TMessage")
                {
                    sql = "select * from " + table;
                    if (comboBox_mes_type.Text.Trim() != "" || tb_PID.Text.Trim() != "" || tb_SampleID.Text.Trim() != "" || tb_PName.Text.Trim() != "")
                    {
                        sql += " where ";

                        if(tb_PName.Text.Trim() != "")
                        {
                            if (existFilter != false)
                            {
                                sql += " and ";
                            }
                            sql = "select * from " + table + ",Patient where " + table + ".PID = Patient.PID and Patient.NAME = "+'"'+ tb_PName.Text + '"';
                            existFilter = true;
                        }

                        if (comboBox_mes_type.Text.Trim() != "")
                        {
                            if (existFilter != false)
                            {
                                sql += " and ";
                            }
                            sql += "MesDescription = " + '"'+comboBox_mes_type.Text+'"';
                            existFilter = true;
                        }
                        if (tb_SampleID.Text.Trim() != "")
                        {
                            if (existFilter != false)
                            {
                                sql += " and ";
                            }
                            sql += "SampleID = " + '"' + tb_SampleID.Text + '"';
                            existFilter = true;

                        }
                        if (tb_PID.Text.Trim() != "")
                        {
                            if (existFilter != false)
                            {
                                sql += " and ";
                            }
                            sql += "PID = " + '"' + tb_PID.Text + '"';
                            existFilter = true;
                        }
                    }
                }
                else if(table == "SharedFile")
                {
                    sql = "select * from " + table;
                }
                else if(table == "Patient")
                {
                    sql = "select * from " + table;
                    if (tb_PID.Text.Trim() != "" || tb_PName.Text.Trim() != "")
                    {
                        sql += " where ";
                        if (tb_PID.Text.Trim() != "")
                        {
                            if (existFilter != false)
                            {
                                sql += " and ";
                            }
                            sql += "PID = " + '"' + tb_PID.Text + '"';
                            existFilter = true;
                        }
                        if (tb_PName.Text.Trim() != "")
                        {
                            if (existFilter != false)
                            {
                                sql += " and ";
                            }
                            sql += "NAME = " + '"' + tb_PName.Text + '"';
                            existFilter = true;
                        }
                    }
                }
            }

            if(sql != null)
            {
                mAdapter = new SQLiteDataAdapter(sql, mConn);
                mTable = new DataTable(); // Don't forget initialize!
                mAdapter.Fill(mTable);
                dataGridView1.DataSource = mTable;
                if(mTable.Rows.Count == 0)
                {
                    MessageBox.Show("无搜索结果！");
                }
            }
            else
            {
                MessageBox.Show("请输入查询条件");
            }

            
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            //Sqlite msqlite = new Sqlite(Global.Global.dbpath);
            mConn =  new SQLiteConnection(string.Format("Data Source={0};Version=3;", Global.dbpath));
            mConn.Open();

            //获取数据库中表,加载到comboBox中
            //表 "Tables"中字段 "TABLE_NAME" 包含所有表名信息.
            using (DataTable mTables = mConn.GetSchema("Tables")) // "Tables"包含系统表详细信息；
            {
                for (int i = 0; i < mTables.Rows.Count; i++)
                {
                    comboTables.Items.Add(mTables.Rows[i].ItemArray[mTables.Columns.IndexOf("TABLE_NAME")].ToString());
                }
                if (comboTables.Items.Count > 0)
                {
                    comboTables.SelectedIndex = 2; // 默认选中第一张表.
                }
            }
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

        private void tsmi_format_IO_Click(object sender, EventArgs e)
        {
            this.Hide();
            RulePathSetForm objForm = new RulePathSetForm();
            objForm.Show();
        }
    }
}
