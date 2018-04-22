﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using sqlite;

namespace transFormat
{
    public partial class SearchForm : Form
    {
        SQLiteDataAdapter mAdapter;
        DataTable mTable;
        Sqlite msqlite;
        SQLiteConnection mConn;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void tsmi_mes_parse_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParseForm objForm = new ParseForm();
            objForm.Show();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            //mTable = msqlite.ExecuteDataTable("SELECT * FROM [" + comboTables.Text + "]", null);
            mAdapter = new SQLiteDataAdapter("SELECT * FROM [" + comboTables.Text + "]", mConn);
            mTable = new DataTable(); // Don't forget initialize!
            mAdapter.Fill(mTable);
            dataGridView1.DataSource = mTable;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            //Sqlite msqlite = new Sqlite(Global.Global.dbpath);
            mConn =  new SQLiteConnection(string.Format("Data Source={0};Version=3;", Global.Global.dbpath));
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
                    comboTables.SelectedIndex = 0; // 默认选中第一张表.
                }
            }
        }
    }
}
