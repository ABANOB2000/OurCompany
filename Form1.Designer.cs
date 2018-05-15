namespace OurCompany
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.but_Login = new System.Windows.Forms.Button();
            this.but_Cansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Name";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(154, 76);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(241, 20);
            this.pass.TabIndex = 9;
            this.pass.Text = "1254887";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(154, 40);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(241, 20);
            this.user.TabIndex = 8;
            this.user.Text = "abanob";
            // 
            // but_Login
            // 
            this.but_Login.Location = new System.Drawing.Point(22, 129);
            this.but_Login.Name = "but_Login";
            this.but_Login.Size = new System.Drawing.Size(97, 23);
            this.but_Login.TabIndex = 12;
            this.but_Login.Text = "Login";
            this.but_Login.UseVisualStyleBackColor = true;
            this.but_Login.Click += new System.EventHandler(this.but_Login_Click);
            // 
            // but_Cansel
            // 
            this.but_Cansel.Location = new System.Drawing.Point(300, 129);
            this.but_Cansel.Name = "but_Cansel";
            this.but_Cansel.Size = new System.Drawing.Size(95, 23);
            this.but_Cansel.TabIndex = 13;
            this.but_Cansel.Text = "Cansel";
            this.but_Cansel.UseVisualStyleBackColor = true;
            this.but_Cansel.Click += new System.EventHandler(this.but_Cansel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 175);
            this.ControlBox = false;
            this.Controls.Add(this.but_Cansel);
            this.Controls.Add(this.but_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Name = "Form1";
            this.Text = "PassWord";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button but_Login;
        private System.Windows.Forms.Button but_Cansel;

    }
}

