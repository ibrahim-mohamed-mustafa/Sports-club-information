
namespace Project_DataBase
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
            this.Pass = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.passw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 17.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(71, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.BackColor = System.Drawing.Color.Transparent;
            this.Pass.Font = new System.Drawing.Font("Snap ITC", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.Yellow;
            this.Pass.Location = new System.Drawing.Point(71, 136);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(147, 30);
            this.Pass.TabIndex = 1;
            this.Pass.Text = "Password";
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(245, 69);
            this.user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(199, 32);
            this.user.TabIndex = 2;
            // 
            // passw
            // 
            this.passw.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passw.Location = new System.Drawing.Point(245, 137);
            this.passw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passw.Name = "passw";
            this.passw.PasswordChar = '*';
            this.passw.Size = new System.Drawing.Size(199, 32);
            this.passw.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 7;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Snap ITC", 17.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(76, 272);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.Cyan;
            this.Log.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Log.FlatAppearance.BorderSize = 7;
            this.Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log.Font = new System.Drawing.Font("Snap ITC", 17.25F, System.Drawing.FontStyle.Bold);
            this.Log.ForeColor = System.Drawing.Color.DarkBlue;
            this.Log.Location = new System.Drawing.Point(328, 272);
            this.Log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(116, 53);
            this.Log.TabIndex = 5;
            this.Log.Text = "Login";
            this.Log.UseVisualStyleBackColor = false;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 398);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.user);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox passw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Log;
    }
}