namespace IDE_test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rt1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtveriable_list = new System.Windows.Forms.RichTextBox();
            this.rtfunction_list = new System.Windows.Forms.RichTextBox();
            this.rttoken = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbfunction = new System.Windows.Forms.ComboBox();
            this.txtfunction_veriable = new System.Windows.Forms.TextBox();
            this.txtgloble_fuction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcurrent_function = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rt1
            // 
            this.rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt1.Location = new System.Drawing.Point(4, -1);
            this.rt1.Name = "rt1";
            this.rt1.Size = new System.Drawing.Size(572, 739);
            this.rt1.TabIndex = 0;
            this.rt1.Text = resources.GetString("rt1.Text");
            this.rt1.WordWrap = false;
            this.rt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rt1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 744);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(912, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtveriable_list
            // 
            this.rtveriable_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtveriable_list.Location = new System.Drawing.Point(583, 244);
            this.rtveriable_list.Name = "rtveriable_list";
            this.rtveriable_list.Size = new System.Drawing.Size(230, 215);
            this.rtveriable_list.TabIndex = 3;
            this.rtveriable_list.Text = "";
            // 
            // rtfunction_list
            // 
            this.rtfunction_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfunction_list.Location = new System.Drawing.Point(583, 469);
            this.rtfunction_list.Name = "rtfunction_list";
            this.rtfunction_list.Size = new System.Drawing.Size(230, 215);
            this.rtfunction_list.TabIndex = 4;
            this.rtfunction_list.Text = "";
            // 
            // rttoken
            // 
            this.rttoken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rttoken.Location = new System.Drawing.Point(582, 12);
            this.rttoken.Name = "rttoken";
            this.rttoken.Size = new System.Drawing.Size(230, 215);
            this.rttoken.TabIndex = 5;
            this.rttoken.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(818, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Functions";
            // 
            // cmbfunction
            // 
            this.cmbfunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfunction.FormattingEnabled = true;
            this.cmbfunction.Location = new System.Drawing.Point(904, 12);
            this.cmbfunction.Name = "cmbfunction";
            this.cmbfunction.Size = new System.Drawing.Size(183, 26);
            this.cmbfunction.TabIndex = 7;
            this.cmbfunction.SelectedIndexChanged += new System.EventHandler(this.cmbfunction_SelectedIndexChanged);
            // 
            // txtfunction_veriable
            // 
            this.txtfunction_veriable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfunction_veriable.Location = new System.Drawing.Point(821, 54);
            this.txtfunction_veriable.Multiline = true;
            this.txtfunction_veriable.Name = "txtfunction_veriable";
            this.txtfunction_veriable.Size = new System.Drawing.Size(266, 123);
            this.txtfunction_veriable.TabIndex = 8;
            // 
            // txtgloble_fuction
            // 
            this.txtgloble_fuction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgloble_fuction.Location = new System.Drawing.Point(821, 244);
            this.txtgloble_fuction.Multiline = true;
            this.txtgloble_fuction.Name = "txtgloble_fuction";
            this.txtgloble_fuction.Size = new System.Drawing.Size(266, 123);
            this.txtgloble_fuction.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(818, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Globle Veriable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(819, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Current Functions";
            // 
            // txtcurrent_function
            // 
            this.txtcurrent_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcurrent_function.Location = new System.Drawing.Point(945, 394);
            this.txtcurrent_function.Name = "txtcurrent_function";
            this.txtcurrent_function.Size = new System.Drawing.Size(142, 24);
            this.txtcurrent_function.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 772);
            this.Controls.Add(this.txtcurrent_function);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtgloble_fuction);
            this.Controls.Add(this.txtfunction_veriable);
            this.Controls.Add(this.cmbfunction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rttoken);
            this.Controls.Add(this.rtfunction_list);
            this.Controls.Add(this.rtveriable_list);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtveriable_list;
        private System.Windows.Forms.RichTextBox rtfunction_list;
        private System.Windows.Forms.RichTextBox rttoken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbfunction;
        private System.Windows.Forms.TextBox txtfunction_veriable;
        private System.Windows.Forms.TextBox txtgloble_fuction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcurrent_function;
    }
}

