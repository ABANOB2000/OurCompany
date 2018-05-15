namespace OurCompany
{
    partial class ADD
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
            this.textname = new System.Windows.Forms.TextBox();
            this.textadress = new System.Windows.Forms.TextBox();
            this.textphone = new System.Windows.Forms.TextBox();
            this.textsalary = new System.Windows.Forms.TextBox();
            this.comboDepar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.but_AddNew = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.swtish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(83, 50);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(189, 20);
            this.textname.TabIndex = 0;
            // 
            // textadress
            // 
            this.textadress.Location = new System.Drawing.Point(83, 87);
            this.textadress.Name = "textadress";
            this.textadress.Size = new System.Drawing.Size(189, 20);
            this.textadress.TabIndex = 1;
            // 
            // textphone
            // 
            this.textphone.Location = new System.Drawing.Point(83, 126);
            this.textphone.Name = "textphone";
            this.textphone.Size = new System.Drawing.Size(189, 20);
            this.textphone.TabIndex = 2;
            // 
            // textsalary
            // 
            this.textsalary.Location = new System.Drawing.Point(83, 173);
            this.textsalary.Name = "textsalary";
            this.textsalary.Size = new System.Drawing.Size(189, 20);
            this.textsalary.TabIndex = 3;
            // 
            // comboDepar
            // 
            this.comboDepar.FormattingEnabled = true;
            this.comboDepar.Location = new System.Drawing.Point(83, 218);
            this.comboDepar.Name = "comboDepar";
            this.comboDepar.Size = new System.Drawing.Size(189, 21);
            this.comboDepar.TabIndex = 4;
            this.comboDepar.SelectedIndexChanged += new System.EventHandler(this.comboDepar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Department";
            // 
            // but_AddNew
            // 
            this.but_AddNew.Location = new System.Drawing.Point(12, 253);
            this.but_AddNew.Name = "but_AddNew";
            this.but_AddNew.Size = new System.Drawing.Size(260, 23);
            this.but_AddNew.TabIndex = 10;
            this.but_AddNew.Text = "AddNew";
            this.but_AddNew.UseVisualStyleBackColor = true;
            this.but_AddNew.Click += new System.EventHandler(this.but_AddNew_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(113, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Eployee",
            "Maneger"});
            this.comboBox1.Location = new System.Drawing.Point(116, 282);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // swtish
            // 
            this.swtish.AutoSize = true;
            this.swtish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtish.Location = new System.Drawing.Point(38, 282);
            this.swtish.Name = "swtish";
            this.swtish.Size = new System.Drawing.Size(46, 17);
            this.swtish.TabIndex = 13;
            this.swtish.Text = "swtish";
            // 
            // ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 316);
            this.Controls.Add(this.swtish);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.but_AddNew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDepar);
            this.Controls.Add(this.textsalary);
            this.Controls.Add(this.textphone);
            this.Controls.Add(this.textadress);
            this.Controls.Add(this.textname);
            this.Name = "ADD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADD_FormClosing);
            this.Load += new System.EventHandler(this.ADD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textadress;
        private System.Windows.Forms.TextBox textphone;
        private System.Windows.Forms.TextBox textsalary;
        private System.Windows.Forms.ComboBox comboDepar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button but_AddNew;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label swtish;
    }
}