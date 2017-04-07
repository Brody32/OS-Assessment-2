namespace ConverterApp
{
    partial class frm_Main
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt_CM_TO_INCH = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt_CM_TO_FEET = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt_M_TO_FEET = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txt_KM_TO_MILE = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txt_CELSIUS_TO_FAHREN = new System.Windows.Forms.TextBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.lbl7 = new System.Windows.Forms.Label();
            this.listBox_Out = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(23, 21);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(262, 18);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Please enter numbers to be converted:";
            // 
            // txt_CM_TO_INCH
            // 
            this.txt_CM_TO_INCH.Location = new System.Drawing.Point(26, 78);
            this.txt_CM_TO_INCH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CM_TO_INCH.Name = "txt_CM_TO_INCH";
            this.txt_CM_TO_INCH.Size = new System.Drawing.Size(135, 20);
            this.txt_CM_TO_INCH.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(23, 61);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(112, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Centimetres to Inches:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(23, 110);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(101, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Centimetres to Feet:";
            // 
            // txt_CM_TO_FEET
            // 
            this.txt_CM_TO_FEET.Location = new System.Drawing.Point(26, 127);
            this.txt_CM_TO_FEET.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CM_TO_FEET.Name = "txt_CM_TO_FEET";
            this.txt_CM_TO_FEET.Size = new System.Drawing.Size(135, 20);
            this.txt_CM_TO_FEET.TabIndex = 2;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(23, 160);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(78, 13);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Metres to Feet:";
            // 
            // txt_M_TO_FEET
            // 
            this.txt_M_TO_FEET.Location = new System.Drawing.Point(26, 177);
            this.txt_M_TO_FEET.Margin = new System.Windows.Forms.Padding(2);
            this.txt_M_TO_FEET.Name = "txt_M_TO_FEET";
            this.txt_M_TO_FEET.Size = new System.Drawing.Size(135, 20);
            this.txt_M_TO_FEET.TabIndex = 3;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(23, 213);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(97, 13);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "Kilometres to Miles:";
            // 
            // txt_KM_TO_MILE
            // 
            this.txt_KM_TO_MILE.Location = new System.Drawing.Point(26, 230);
            this.txt_KM_TO_MILE.Margin = new System.Windows.Forms.Padding(2);
            this.txt_KM_TO_MILE.Name = "txt_KM_TO_MILE";
            this.txt_KM_TO_MILE.Size = new System.Drawing.Size(135, 20);
            this.txt_KM_TO_MILE.TabIndex = 4;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(23, 264);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(108, 13);
            this.lbl6.TabIndex = 11;
            this.lbl6.Text = "Celsius to Fahrenheit:";
            // 
            // txt_CELSIUS_TO_FAHREN
            // 
            this.txt_CELSIUS_TO_FAHREN.Location = new System.Drawing.Point(26, 282);
            this.txt_CELSIUS_TO_FAHREN.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CELSIUS_TO_FAHREN.Name = "txt_CELSIUS_TO_FAHREN";
            this.txt_CELSIUS_TO_FAHREN.Size = new System.Drawing.Size(135, 20);
            this.txt_CELSIUS_TO_FAHREN.TabIndex = 5;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(163, 333);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(122, 30);
            this.btn_Convert.TabIndex = 12;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(201, 60);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(42, 13);
            this.lbl7.TabIndex = 14;
            this.lbl7.Text = "Output:";
            // 
            // listBox_Out
            // 
            this.listBox_Out.FormattingEnabled = true;
            this.listBox_Out.Location = new System.Drawing.Point(204, 78);
            this.listBox_Out.Name = "listBox_Out";
            this.listBox_Out.Size = new System.Drawing.Size(210, 225);
            this.listBox_Out.TabIndex = 15;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 375);
            this.Controls.Add(this.listBox_Out);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.txt_CELSIUS_TO_FAHREN);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txt_KM_TO_MILE);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txt_M_TO_FEET);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt_CM_TO_FEET);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt_CM_TO_INCH);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Main";
            this.Text = "ATCA Gas Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt_CM_TO_INCH;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt_CM_TO_FEET;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txt_M_TO_FEET;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txt_KM_TO_MILE;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox txt_CELSIUS_TO_FAHREN;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.ListBox listBox_Out;
    }
}

