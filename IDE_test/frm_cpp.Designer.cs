namespace IDE_test
{
    partial class frm_cpp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cpp));
            this.rt1 = new System.Windows.Forms.RichTextBox();
            this.lstclassess = new System.Windows.Forms.ListBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.lstveriable_and_function_of_class = new System.Windows.Forms.ListBox();
            this.txtveriable_of_function = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rt1
            // 
            this.rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt1.Location = new System.Drawing.Point(5, 4);
            this.rt1.Name = "rt1";
            this.rt1.Size = new System.Drawing.Size(572, 739);
            this.rt1.TabIndex = 1;
            this.rt1.Text = resources.GetString("rt1.Text");
            this.rt1.WordWrap = false;
            // 
            // lstclassess
            // 
            this.lstclassess.FormattingEnabled = true;
            this.lstclassess.Location = new System.Drawing.Point(584, 4);
            this.lstclassess.Name = "lstclassess";
            this.lstclassess.Size = new System.Drawing.Size(497, 134);
            this.lstclassess.TabIndex = 2;
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(585, 149);
            this.txtclass.Multiline = true;
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(495, 222);
            this.txtclass.TabIndex = 3;
            // 
            // lstveriable_and_function_of_class
            // 
            this.lstveriable_and_function_of_class.FormattingEnabled = true;
            this.lstveriable_and_function_of_class.Location = new System.Drawing.Point(583, 377);
            this.lstveriable_and_function_of_class.Name = "lstveriable_and_function_of_class";
            this.lstveriable_and_function_of_class.Size = new System.Drawing.Size(497, 134);
            this.lstveriable_and_function_of_class.TabIndex = 4;
            // 
            // txtveriable_of_function
            // 
            this.txtveriable_of_function.Location = new System.Drawing.Point(583, 522);
            this.txtveriable_of_function.Multiline = true;
            this.txtveriable_of_function.Name = "txtveriable_of_function";
            this.txtveriable_of_function.Size = new System.Drawing.Size(495, 222);
            this.txtveriable_of_function.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 750);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1073, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_cpp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 774);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtveriable_of_function);
            this.Controls.Add(this.lstveriable_and_function_of_class);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.lstclassess);
            this.Controls.Add(this.rt1);
            this.Name = "frm_cpp";
            this.Text = "frm_cpp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt1;
        private System.Windows.Forms.ListBox lstclassess;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.ListBox lstveriable_and_function_of_class;
        private System.Windows.Forms.TextBox txtveriable_of_function;
        private System.Windows.Forms.Button button1;
    }
}