namespace ATM
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdLogout = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAmount = new System.Windows.Forms.Panel();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.cmdPayout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlComp = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.txt5 = new System.Windows.Forms.NumericUpDown();
            this.txt10 = new System.Windows.Forms.NumericUpDown();
            this.txt20 = new System.Windows.Forms.NumericUpDown();
            this.txt50 = new System.Windows.Forms.NumericUpDown();
            this.txt100 = new System.Windows.Forms.NumericUpDown();
            this.txt200 = new System.Windows.Forms.NumericUpDown();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb20 = new System.Windows.Forms.PictureBox();
            this.pb100 = new System.Windows.Forms.PictureBox();
            this.pb10 = new System.Windows.Forms.PictureBox();
            this.pb50 = new System.Windows.Forms.PictureBox();
            this.pb200 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBalance.SuspendLayout();
            this.pnlAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.pnlComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBalance
            // 
            this.pnlBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBalance.Controls.Add(this.cmdExit);
            this.pnlBalance.Controls.Add(this.cmdLogout);
            this.pnlBalance.Controls.Add(this.txtBalance);
            this.pnlBalance.Controls.Add(this.label2);
            this.pnlBalance.Location = new System.Drawing.Point(12, 138);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(366, 108);
            this.pnlBalance.TabIndex = 1;
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.Red;
            this.cmdExit.Location = new System.Drawing.Point(241, 55);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(118, 46);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.TabStop = false;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdLogout
            // 
            this.cmdLogout.BackColor = System.Drawing.Color.Yellow;
            this.cmdLogout.Location = new System.Drawing.Point(241, 7);
            this.cmdLogout.Name = "cmdLogout";
            this.cmdLogout.Size = new System.Drawing.Size(118, 46);
            this.cmdLogout.TabIndex = 2;
            this.cmdLogout.TabStop = false;
            this.cmdLogout.Text = "Log Out";
            this.cmdLogout.UseVisualStyleBackColor = false;
            this.cmdLogout.Click += new System.EventHandler(this.cmdLogout_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(10, 46);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(135, 31);
            this.txtBalance.TabIndex = 1;
            this.txtBalance.TabStop = false;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Balance";
            // 
            // pnlAmount
            // 
            this.pnlAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAmount.Controls.Add(this.txtAmount);
            this.pnlAmount.Controls.Add(this.cmdPayout);
            this.pnlAmount.Controls.Add(this.label3);
            this.pnlAmount.Location = new System.Drawing.Point(621, 138);
            this.pnlAmount.Name = "pnlAmount";
            this.pnlAmount.Size = new System.Drawing.Size(366, 108);
            this.pnlAmount.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtAmount.Location = new System.Drawing.Point(94, 32);
            this.txtAmount.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(105, 35);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.ValueChanged += new System.EventHandler(this.txtAmount_ValueChanged);
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // cmdPayout
            // 
            this.cmdPayout.BackColor = System.Drawing.Color.Green;
            this.cmdPayout.Location = new System.Drawing.Point(241, 29);
            this.cmdPayout.Name = "cmdPayout";
            this.cmdPayout.Size = new System.Drawing.Size(118, 46);
            this.cmdPayout.TabIndex = 1;
            this.cmdPayout.Text = "Pay out";
            this.cmdPayout.UseVisualStyleBackColor = false;
            this.cmdPayout.Click += new System.EventHandler(this.cmdPayout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // pnlComp
            // 
            this.pnlComp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlComp.Controls.Add(this.label4);
            this.pnlComp.Controls.Add(this.cmdOK);
            this.pnlComp.Controls.Add(this.txt5);
            this.pnlComp.Controls.Add(this.txt10);
            this.pnlComp.Controls.Add(this.txt20);
            this.pnlComp.Controls.Add(this.txt50);
            this.pnlComp.Controls.Add(this.txt100);
            this.pnlComp.Controls.Add(this.txt200);
            this.pnlComp.Controls.Add(this.pb5);
            this.pnlComp.Controls.Add(this.pb20);
            this.pnlComp.Controls.Add(this.pb100);
            this.pnlComp.Controls.Add(this.pb10);
            this.pnlComp.Controls.Add(this.pb50);
            this.pnlComp.Controls.Add(this.pb200);
            this.pnlComp.Location = new System.Drawing.Point(12, 253);
            this.pnlComp.Name = "pnlComp";
            this.pnlComp.Size = new System.Drawing.Size(975, 325);
            this.pnlComp.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Please choose:";
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.Color.Green;
            this.cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.Location = new System.Drawing.Point(908, 3);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(60, 60);
            this.cmdOK.TabIndex = 17;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // txt5
            // 
            this.txt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt5.Location = new System.Drawing.Point(868, 242);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(105, 35);
            this.txt5.TabIndex = 16;
            // 
            // txt10
            // 
            this.txt10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt10.Location = new System.Drawing.Point(868, 97);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(105, 35);
            this.txt10.TabIndex = 15;
            // 
            // txt20
            // 
            this.txt20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt20.Location = new System.Drawing.Point(541, 242);
            this.txt20.Name = "txt20";
            this.txt20.Size = new System.Drawing.Size(105, 35);
            this.txt20.TabIndex = 13;
            // 
            // txt50
            // 
            this.txt50.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt50.Location = new System.Drawing.Point(541, 97);
            this.txt50.Name = "txt50";
            this.txt50.Size = new System.Drawing.Size(105, 35);
            this.txt50.TabIndex = 12;
            // 
            // txt100
            // 
            this.txt100.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt100.Location = new System.Drawing.Point(222, 242);
            this.txt100.Name = "txt100";
            this.txt100.Size = new System.Drawing.Size(105, 35);
            this.txt100.TabIndex = 10;
            // 
            // txt200
            // 
            this.txt200.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt200.Location = new System.Drawing.Point(222, 97);
            this.txt200.Name = "txt200";
            this.txt200.Size = new System.Drawing.Size(105, 35);
            this.txt200.TabIndex = 9;
            // 
            // pb5
            // 
            this.pb5.Image = global::ATM.Properties.Resources.Euro5;
            this.pb5.Location = new System.Drawing.Point(652, 204);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(205, 105);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 5;
            this.pb5.TabStop = false;
            // 
            // pb20
            // 
            this.pb20.Image = global::ATM.Properties.Resources.Euro20;
            this.pb20.Location = new System.Drawing.Point(333, 204);
            this.pb20.Name = "pb20";
            this.pb20.Size = new System.Drawing.Size(205, 105);
            this.pb20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb20.TabIndex = 4;
            this.pb20.TabStop = false;
            // 
            // pb100
            // 
            this.pb100.Image = global::ATM.Properties.Resources.Euro100;
            this.pb100.Location = new System.Drawing.Point(10, 204);
            this.pb100.Name = "pb100";
            this.pb100.Size = new System.Drawing.Size(205, 105);
            this.pb100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb100.TabIndex = 3;
            this.pb100.TabStop = false;
            // 
            // pb10
            // 
            this.pb10.Image = global::ATM.Properties.Resources.Euro10;
            this.pb10.Location = new System.Drawing.Point(652, 59);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(205, 105);
            this.pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb10.TabIndex = 2;
            this.pb10.TabStop = false;
            // 
            // pb50
            // 
            this.pb50.Image = global::ATM.Properties.Resources.Euro50;
            this.pb50.Location = new System.Drawing.Point(333, 59);
            this.pb50.Name = "pb50";
            this.pb50.Size = new System.Drawing.Size(205, 105);
            this.pb50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb50.TabIndex = 1;
            this.pb50.TabStop = false;
            // 
            // pb200
            // 
            this.pb200.Image = global::ATM.Properties.Resources.Euro200;
            this.pb200.Location = new System.Drawing.Point(10, 59);
            this.pb200.Name = "pb200";
            this.pb200.Size = new System.Drawing.Size(205, 105);
            this.pb200.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb200.TabIndex = 0;
            this.pb200.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ATM.Properties.Resources.Github;
            this.pictureBox2.Location = new System.Drawing.Point(957, 593);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM.Properties.Resources.LED_atm_sign;
            this.pictureBox1.Location = new System.Drawing.Point(324, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "by xXP4trickXx";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlComp);
            this.Controls.Add(this.pnlAmount);
            this.Controls.Add(this.pnlBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.pnlAmount.ResumeLayout(false);
            this.pnlAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.pnlComp.ResumeLayout(false);
            this.pnlComp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAmount;
        private System.Windows.Forms.Button cmdLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdPayout;
        private System.Windows.Forms.Panel pnlComp;
        private System.Windows.Forms.NumericUpDown txt5;
        private System.Windows.Forms.NumericUpDown txt10;
        private System.Windows.Forms.NumericUpDown txt20;
        private System.Windows.Forms.NumericUpDown txt50;
        private System.Windows.Forms.NumericUpDown txt100;
        private System.Windows.Forms.NumericUpDown txt200;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb20;
        private System.Windows.Forms.PictureBox pb100;
        private System.Windows.Forms.PictureBox pb10;
        private System.Windows.Forms.PictureBox pb50;
        private System.Windows.Forms.PictureBox pb200;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}