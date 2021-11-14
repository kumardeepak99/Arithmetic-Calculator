namespace WindApp
{
    partial class Add
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblAddSign = new System.Windows.Forms.Label();
            this.ANum1 = new System.Windows.Forms.TextBox();
            this.ANum2 = new System.Windows.Forms.TextBox();
            this.GetSumVal = new System.Windows.Forms.Button();
            this.Sumval = new System.Windows.Forms.TextBox();
            this.LoginPage = new System.Windows.Forms.Button();
            this.BackToAddSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(192, 125);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(51, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "First Num";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(192, 175);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(69, 13);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Second Num";
            // 
            // lblAddSign
            // 
            this.lblAddSign.AutoSize = true;
            this.lblAddSign.Location = new System.Drawing.Point(153, 151);
            this.lblAddSign.Name = "lblAddSign";
            this.lblAddSign.Size = new System.Drawing.Size(13, 13);
            this.lblAddSign.TabIndex = 2;
            this.lblAddSign.Text = "+";
            // 
            // ANum1
            // 
            this.ANum1.Location = new System.Drawing.Point(302, 122);
            this.ANum1.Name = "ANum1";
            this.ANum1.Size = new System.Drawing.Size(100, 20);
            this.ANum1.TabIndex = 3;
            // 
            // ANum2
            // 
            this.ANum2.Location = new System.Drawing.Point(302, 172);
            this.ANum2.Name = "ANum2";
            this.ANum2.Size = new System.Drawing.Size(100, 20);
            this.ANum2.TabIndex = 4;
            // 
            // GetSumVal
            // 
            this.GetSumVal.Location = new System.Drawing.Point(195, 223);
            this.GetSumVal.Name = "GetSumVal";
            this.GetSumVal.Size = new System.Drawing.Size(75, 23);
            this.GetSumVal.TabIndex = 5;
            this.GetSumVal.Text = "Get Sum";
            this.GetSumVal.UseVisualStyleBackColor = true;
            this.GetSumVal.Click += new System.EventHandler(this.GetSumVal_Click);
            // 
            // Sumval
            // 
            this.Sumval.Location = new System.Drawing.Point(302, 223);
            this.Sumval.Name = "Sumval";
            this.Sumval.Size = new System.Drawing.Size(100, 20);
            this.Sumval.TabIndex = 6;
            // 
            // LoginPage
            // 
            this.LoginPage.BackColor = System.Drawing.Color.LightCoral;
            this.LoginPage.Location = new System.Drawing.Point(686, 30);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(83, 42);
            this.LoginPage.TabIndex = 7;
            this.LoginPage.Text = "Login";
            this.LoginPage.UseVisualStyleBackColor = false;
            this.LoginPage.Click += new System.EventHandler(this.LoginPage_Click);
            // 
            // BackToAddSum
            // 
            this.BackToAddSum.BackColor = System.Drawing.Color.OrangeRed;
            this.BackToAddSum.Location = new System.Drawing.Point(12, 30);
            this.BackToAddSum.Name = "BackToAddSum";
            this.BackToAddSum.Size = new System.Drawing.Size(77, 42);
            this.BackToAddSum.TabIndex = 8;
            this.BackToAddSum.Text = "<---";
            this.BackToAddSum.UseVisualStyleBackColor = false;
            this.BackToAddSum.Click += new System.EventHandler(this.BackToAddSum_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToAddSum);
            this.Controls.Add(this.LoginPage);
            this.Controls.Add(this.Sumval);
            this.Controls.Add(this.GetSumVal);
            this.Controls.Add(this.ANum2);
            this.Controls.Add(this.ANum1);
            this.Controls.Add(this.lblAddSign);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add";
            this.Text = "Add Two Num";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblAddSign;
        private System.Windows.Forms.TextBox ANum1;
        private System.Windows.Forms.TextBox ANum2;
        private System.Windows.Forms.Button GetSumVal;
        private System.Windows.Forms.TextBox Sumval;
        private System.Windows.Forms.Button LoginPage;
        private System.Windows.Forms.Button BackToAddSum;
    }
}