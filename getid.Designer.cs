
namespace Project_DataBase
{
    partial class getid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(getid));
            this.Get_T_ID = new System.Windows.Forms.Button();
            this.Team_id = new System.Windows.Forms.TextBox();
            this.Team_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Get_T_ID
            // 
            this.Get_T_ID.BackColor = System.Drawing.Color.LimeGreen;
            this.Get_T_ID.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Get_T_ID.FlatAppearance.BorderSize = 5;
            this.Get_T_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Get_T_ID.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.Get_T_ID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Get_T_ID.Location = new System.Drawing.Point(144, 301);
            this.Get_T_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Get_T_ID.Name = "Get_T_ID";
            this.Get_T_ID.Size = new System.Drawing.Size(155, 52);
            this.Get_T_ID.TabIndex = 9;
            this.Get_T_ID.Text = "Get Team ID";
            this.Get_T_ID.UseVisualStyleBackColor = false;
            this.Get_T_ID.Click += new System.EventHandler(this.Get_T_ID_Click);
            // 
            // Team_id
            // 
            this.Team_id.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team_id.Location = new System.Drawing.Point(190, 162);
            this.Team_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Team_id.Name = "Team_id";
            this.Team_id.PasswordChar = '*';
            this.Team_id.Size = new System.Drawing.Size(199, 32);
            this.Team_id.TabIndex = 13;
            // 
            // Team_Name
            // 
            this.Team_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team_Name.Location = new System.Drawing.Point(190, 88);
            this.Team_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Team_Name.Name = "Team_Name";
            this.Team_Name.Size = new System.Drawing.Size(199, 32);
            this.Team_Name.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(39, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Team ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(39, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Team Name";
            // 
            // getid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 496);
            this.Controls.Add(this.Team_id);
            this.Controls.Add(this.Team_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Get_T_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "getid";
            this.Text = "getid";
            this.Load += new System.EventHandler(this.getid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Get_T_ID;
        private System.Windows.Forms.TextBox Team_id;
        private System.Windows.Forms.TextBox Team_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}