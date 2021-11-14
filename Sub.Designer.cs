namespace WindApp
{
    partial class Sub
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
            this.lblSubSign = new System.Windows.Forms.Label();
            this.SNum1 = new System.Windows.Forms.TextBox();
            this.SNum2 = new System.Windows.Forms.TextBox();
            this.SubVal = new System.Windows.Forms.TextBox();
            this.GetSubVal = new System.Windows.Forms.Button();
            this.GotToLoginPage = new System.Windows.Forms.Button();
            this.GoToAddSub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(222, 101);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(51, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "First Num";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(222, 156);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(69, 13);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Second Num";
            // 
            // lblSubSign
            // 
            this.lblSubSign.AutoSize = true;
            this.lblSubSign.Location = new System.Drawing.Point(180, 130);
            this.lblSubSign.Name = "lblSubSign";
            this.lblSubSign.Size = new System.Drawing.Size(13, 13);
            this.lblSubSign.TabIndex = 2;
            this.lblSubSign.Text = "--";
            // 
            // SNum1
            // 
            this.SNum1.Location = new System.Drawing.Point(327, 101);
            this.SNum1.Name = "SNum1";
            this.SNum1.Size = new System.Drawing.Size(100, 20);
            this.SNum1.TabIndex = 3;
            // 
            // SNum2
            // 
            this.SNum2.Location = new System.Drawing.Point(327, 156);
            this.SNum2.Name = "SNum2";
            this.SNum2.Size = new System.Drawing.Size(100, 20);
            this.SNum2.TabIndex = 4;
            // 
            // SubVal
            // 
            this.SubVal.Location = new System.Drawing.Point(327, 210);
            this.SubVal.Name = "SubVal";
            this.SubVal.Size = new System.Drawing.Size(100, 20);
            this.SubVal.TabIndex = 5;
            // 
            // GetSubVal
            // 
            this.GetSubVal.Location = new System.Drawing.Point(225, 206);
            this.GetSubVal.Name = "GetSubVal";
            this.GetSubVal.Size = new System.Drawing.Size(75, 23);
            this.GetSubVal.TabIndex = 6;
            this.GetSubVal.Text = "Get Sub";
            this.GetSubVal.UseVisualStyleBackColor = true;
            this.GetSubVal.Click += new System.EventHandler(this.GetSubVal_Click);
            // 
            // GotToLoginPage
            // 
            this.GotToLoginPage.BackColor = System.Drawing.Color.LightCoral;
            this.GotToLoginPage.Location = new System.Drawing.Point(693, 33);
            this.GotToLoginPage.Name = "GotToLoginPage";
            this.GotToLoginPage.Size = new System.Drawing.Size(75, 38);
            this.GotToLoginPage.TabIndex = 7;
            this.GotToLoginPage.Text = "Login";
            this.GotToLoginPage.UseVisualStyleBackColor = false;
            this.GotToLoginPage.Click += new System.EventHandler(this.GotToLoginPage_Click);
            // 
            // GoToAddSub
            // 
            this.GoToAddSub.BackColor = System.Drawing.Color.OrangeRed;
            this.GoToAddSub.Location = new System.Drawing.Point(31, 33);
            this.GoToAddSub.Name = "GoToAddSub";
            this.GoToAddSub.Size = new System.Drawing.Size(75, 38);
            this.GoToAddSub.TabIndex = 8;
            this.GoToAddSub.Text = "<---";
            this.GoToAddSub.UseVisualStyleBackColor = false;
            this.GoToAddSub.Click += new System.EventHandler(this.GoToAddSub_Click);
            // 
            // Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.GoToAddSub);
            this.Controls.Add(this.GotToLoginPage);
            this.Controls.Add(this.GetSubVal);
            this.Controls.Add(this.SubVal);
            this.Controls.Add(this.SNum2);
            this.Controls.Add(this.SNum1);
            this.Controls.Add(this.lblSubSign);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sub";
            this.Text = "Subtract Two Num";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblSubSign;
        private System.Windows.Forms.TextBox SNum1;
        private System.Windows.Forms.TextBox SNum2;
        private System.Windows.Forms.TextBox SubVal;
        private System.Windows.Forms.Button GetSubVal;
        private System.Windows.Forms.Button GotToLoginPage;
        private System.Windows.Forms.Button GoToAddSub;
    }
}