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

        private void rt1_KeyDown(object sender, KeyEventArgs e)
        {
            //int key = e.KeyValue;
            //MessageBox.Show(key.ToString());
            if (e.KeyValue == 40 || e.KeyValue == 38 || e.KeyValue == 13)
            {
                Cls_c_process cpro = new Cls_c_process();
                cpro.code = rt1.Text;
                cpro.Parse();
                cmbfunction.Items.Clear();
                String[] functions = cpro.get_function();
                for (int i = 0; i < functions.Count(); i++)
                {
                    cmbfunction.Items.Add(functions[i]);
                }

                txtgloble_fuction.Text = "";
                String[] globle_veriable = cpro.get_function();
                for (int i = 0; i < globle_veriable.Count(); i++)
                {
                    txtgloble_fuction.Text = txtgloble_fuction.Text + globle_veriable[i] + "   "; 
                    
                }

                //rt1.WordWrap = false;
                int lineIndex = rt1.GetLineFromCharIndex(rt1.SelectionStart);
               // lineIndex++;
                //rt1.WordWrap = true;
               // int lineIndex = get_rt_current_line();
                txtcurrent_function.Text = "";
                txtcurrent_function.Text = cpro.get_current_function(lineIndex);
            }
        }
        private int get_rt_current_line()
        {
            rt1.WordWrap = false;
            int lineIndex = rt1.GetLineFromCharIndex(rt1.SelectionStart);
            lineIndex++;
            rt1.WordWrap = true;
            return lineIndex;
        }
        private void cmbfunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cls_c_process cpro = new Cls_c_process();
            cpro.code = rt1.Text;
            cpro.Parse();
            txtfunction_veriable.Text = "";
            String[] variables = cpro.get_variable_of(cmbfunction.Text);
            for (int i = 0; i < variables.Count(); i++)
            {
                txtfunction_veriable.Text = txtfunction_veriable.Text + variables[i] + "   ";
            }
        }
        ///
    }
}
