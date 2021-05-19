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
            this.rtfunction_veriable_list = new System.Windows.Forms.RichTextBox();
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
            this.rtveriable_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtveriable_list.Location = new System.Drawing.Point(582, 194);
            this.rtveriable_list.Name = "rtveriable_list";
            this.rtveriable_list.Size = new System.Drawing.Size(333, 177);
            this.rtveriable_list.TabIndex = 3;
            this.rtveriable_list.Text = "";
            // 
            // rtfunction_list
            // 
            this.rtfunction_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfunction_list.Location = new System.Drawing.Point(582, 376);
            this.rtfunction_list.Name = "rtfunction_list";
            this.rtfunction_list.Size = new System.Drawing.Size(333, 177);
            this.rtfunction_list.TabIndex = 4;
            this.rtfunction_list.Text = "";
            // 
            // rttoken
            // 
            this.rttoken.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rttoken.Location = new System.Drawing.Point(582, 12);
            this.rttoken.Name = "rttoken";
            this.rttoken.Size = new System.Drawing.Size(333, 177);
            this.rttoken.TabIndex = 5;
            this.rttoken.Text = "";
            // 
            // rtfunction_veriable_list
            // 
            this.rtfunction_veriable_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfunction_veriable_list.Location = new System.Drawing.Point(582, 559);
            this.rtfunction_veriable_list.Name = "rtfunction_veriable_list";
            this.rtfunction_veriable_list.Size = new System.Drawing.Size(333, 177);
            this.rtfunction_veriable_list.TabIndex = 6;
            this.rtfunction_veriable_list.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 772);
            this.Controls.Add(this.rtfunction_veriable_list);
            this.Controls.Add(this.rttoken);
            this.Controls.Add(this.rtfunction_list);
            this.Controls.Add(this.rtveriable_list);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtveriable_list;
        private System.Windows.Forms.RichTextBox rtfunction_list;
        private System.Windows.Forms.RichTextBox rttoken;
        private System.Windows.Forms.RichTextBox rtfunction_veriable_list;
    }
}

