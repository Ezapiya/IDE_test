using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IDE_test
{
    public partial class Form1 : Form
    {
        List<String> tokens_list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            //Parse();
            Cls_c_process cpro = new Cls_c_process();
            cpro.code = rt1.Text;
            String[] token= cpro.Parse();
            rttoken.Text = "";
            for (int i = 0; i < token.Length; i++)
            {
                rttoken.Text = rttoken.Text + token[i] + "\n";
            }

            String[] veriable = cpro.get_veriable();
            rtveriable_list.Text = "";
            for (int i = 0; i < veriable.Length; i++)
            {
                rtveriable_list.Text = rtveriable_list.Text + veriable[i] + "\n";
            }

            String[] function = cpro.get_function();
            rtfunction_list.Text = "";
            for (int i = 0; i < function.Length; i++)
            {
                rtfunction_list.Text = rtfunction_list.Text + function[i] + "\n";
            }



        }
    }
}
