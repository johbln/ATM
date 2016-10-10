namespace ATM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmd4 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.cmd6 = new System.Windows.Forms.Button();
            this.cmd8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmd0 = new System.Windows.Forms.Button();
            this.cmd9 = new System.Windows.Forms.Button();
            this.cmd7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdAccept = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter PIN:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPIN
            // 
            this.txtPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPIN.Location = new System.Drawing.Point(214, 45);
            this.txtPIN.MaxLength = 4;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.PasswordChar = '*';
            this.txtPIN.Size = new System.Drawing.Size(93, 49);
            this.txtPIN.TabIndex = 1;
            this.txtPIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPIN_KeyDown);
            // 
            // cmd1
            // 
            this.cmd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd1.Location = new System.Drawing.Point(4, 4);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(100, 100);
            this.cmd1.TabIndex = 0;
            this.cmd1.Text = "1";
            this.cmd1.UseVisualStyleBackColor = true;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd2.Location = new System.Drawing.Point(110, 4);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(100, 100);
            this.cmd2.TabIndex = 1;
            this.cmd2.Text = "2";
            this.cmd2.UseVisualStyleBackColor = true;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd3
            // 
            this.cmd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd3.Location = new System.Drawing.Point(216, 4);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(100, 100);
            this.cmd3.TabIndex = 2;
            this.cmd3.Text = "3";
            this.cmd3.UseVisualStyleBackColor = true;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmd4
            // 
            this.cmd4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd4.Location = new System.Drawing.Point(4, 110);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(100, 100);
            this.cmd4.TabIndex = 3;
            this.cmd4.Text = "4";
            this.cmd4.UseVisualStyleBackColor = true;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmd5
            // 
            this.cmd5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd5.Location = new System.Drawing.Point(110, 110);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(100, 100);
            this.cmd5.TabIndex = 4;
            this.cmd5.Text = "5";
            this.cmd5.UseVisualStyleBackColor = true;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // cmd6
            // 
            this.cmd6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd6.Location = new System.Drawing.Point(216, 110);
            this.cmd6.Name = "cmd6";
            this.cmd6.Size = new System.Drawing.Size(100, 100);
            this.cmd6.TabIndex = 5;
            this.cmd6.Text = "6";
            this.cmd6.UseVisualStyleBackColor = true;
            this.cmd6.Click += new System.EventHandler(this.cmd6_Click);
            // 
            // cmd8
            // 
            this.cmd8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd8.Location = new System.Drawing.Point(110, 216);
            this.cmd8.Name = "cmd8";
            this.cmd8.Size = new System.Drawing.Size(100, 100);
            this.cmd8.TabIndex = 7;
            this.cmd8.Text = "8";
            this.cmd8.UseVisualStyleBackColor = true;
            this.cmd8.Click += new System.EventHandler(this.cmd8_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cmd0);
            this.panel1.Controls.Add(this.cmd9);
            this.panel1.Controls.Add(this.cmd7);
            this.panel1.Controls.Add(this.cmd1);
            this.panel1.Controls.Add(this.cmd2);
            this.panel1.Controls.Add(this.cmd3);
            this.panel1.Controls.Add(this.cmd8);
            this.panel1.Controls.Add(this.cmd4);
            this.panel1.Controls.Add(this.cmd6);
            this.panel1.Controls.Add(this.cmd5);
            this.panel1.Location = new System.Drawing.Point(8, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 433);
            this.panel1.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(216, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 13;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(4, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 12;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmd0
            // 
            this.cmd0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd0.Location = new System.Drawing.Point(110, 322);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(100, 100);
            this.cmd0.TabIndex = 9;
            this.cmd0.Text = "0";
            this.cmd0.UseVisualStyleBackColor = true;
            this.cmd0.Click += new System.EventHandler(this.cmd0_Click);
            // 
            // cmd9
            // 
            this.cmd9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd9.Location = new System.Drawing.Point(216, 216);
            this.cmd9.Name = "cmd9";
            this.cmd9.Size = new System.Drawing.Size(100, 100);
            this.cmd9.TabIndex = 8;
            this.cmd9.Text = "9";
            this.cmd9.UseVisualStyleBackColor = true;
            this.cmd9.Click += new System.EventHandler(this.cmd9_Click);
            // 
            // cmd7
            // 
            this.cmd7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd7.Location = new System.Drawing.Point(4, 216);
            this.cmd7.Name = "cmd7";
            this.cmd7.Size = new System.Drawing.Size(100, 100);
            this.cmd7.TabIndex = 6;
            this.cmd7.Text = "7";
            this.cmd7.UseVisualStyleBackColor = true;
            this.cmd7.Click += new System.EventHandler(this.cmd7_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cmdAccept);
            this.panel2.Controls.Add(this.cmdCancel);
            this.panel2.Controls.Add(this.cmdClear);
            this.panel2.Location = new System.Drawing.Point(340, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 433);
            this.panel2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 100);
            this.button1.TabIndex = 17;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmdAccept
            // 
            this.cmdAccept.BackColor = System.Drawing.Color.Green;
            this.cmdAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAccept.Location = new System.Drawing.Point(3, 216);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(175, 100);
            this.cmdAccept.TabIndex = 2;
            this.cmdAccept.Text = "Accept";
            this.cmdAccept.UseVisualStyleBackColor = false;
            this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Yellow;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(3, 110);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(175, 100);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.Color.Red;
            this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.Location = new System.Drawing.Point(3, 4);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(175, 100);
            this.cmdClear.TabIndex = 0;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "ATM - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd3;
        private System.Windows.Forms.Button cmd4;
        private System.Windows.Forms.Button cmd5;
        private System.Windows.Forms.Button cmd6;
        private System.Windows.Forms.Button cmd8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmd9;
        private System.Windows.Forms.Button cmd7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmd0;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdAccept;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button button1;
    }
}

