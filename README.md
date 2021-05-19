# IDE_test
C# appliction  to get veriable and function from c source code





Sample code 



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
