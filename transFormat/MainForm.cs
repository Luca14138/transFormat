using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sqlite;
using Global;

namespace transFormat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Sqlite msqlite = new Sqlite(Global.Global.dbpath);

        private void btSetFormat_Click(object sender, EventArgs e)
        {
            
            msqlite.CreatTable();
        }
    }
}
