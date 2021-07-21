using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_test
{
    public partial class frm_cpp : Form
    {
        Cls_cpp_process cpp_pro = new Cls_cpp_process();
        public frm_cpp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cpp_pro.code = rt1.Text;
            cpp_pro.Parse();
        }
    }
}
