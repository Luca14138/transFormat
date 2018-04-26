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

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(System.IO.Directory.GetCurrentDirectory());
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
        }
    }
}
