namespace WindApp
{
    partial class AddSub
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
            this.Add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Tomato;
            this.Add.Location = new System.Drawing.Point(241, 69);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(134, 49);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.Color.Tomato;
            this.Sub.Location = new System.Drawing.Point(241, 182);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(134, 49);
            this.Sub.TabIndex = 1;
            this.Sub.Text = "Sub";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Salmon;
            this.Login.Location = new System.Drawing.Point(687, 12);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(91, 49);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // AddSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Add);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSub";
            this.Text = "Go For Calculation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Login;
    }
}