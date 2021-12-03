
namespace SocialNetwork.Forms
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.labelAllName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelHobbies = new System.Windows.Forms.Label();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelLengthToUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAllName
            // 
            this.labelAllName.AutoEllipsis = true;
            this.labelAllName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllName.ForeColor = System.Drawing.Color.White;
            this.labelAllName.Location = new System.Drawing.Point(220, 66);
            this.labelAllName.Name = "labelAllName";
            this.labelAllName.Size = new System.Drawing.Size(275, 23);
            this.labelAllName.TabIndex = 1;
            this.labelAllName.Text = "labelName";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoEllipsis = true;
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(222, 100);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(273, 23);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "labelEmail";
            // 
            // labelHobbies
            // 
            this.labelHobbies.AutoEllipsis = true;
            this.labelHobbies.ForeColor = System.Drawing.Color.White;
            this.labelHobbies.Location = new System.Drawing.Point(222, 132);
            this.labelHobbies.Name = "labelHobbies";
            this.labelHobbies.Size = new System.Drawing.Size(273, 23);
            this.labelHobbies.TabIndex = 4;
            this.labelHobbies.Text = "Hobbies: ";
            // 
            // buttonFriends
            // 
            this.buttonFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFriends.ForeColor = System.Drawing.Color.White;
            this.buttonFriends.Location = new System.Drawing.Point(597, 121);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(230, 34);
            this.buttonFriends.TabIndex = 5;
            this.buttonFriends.Text = "Friends: ";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(225, 13);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(121, 29);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "User info:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 175);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(827, 263);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(746, 12);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(93, 29);
            this.buttonReturn.TabIndex = 9;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // labelLengthToUser
            // 
            this.labelLengthToUser.AutoEllipsis = true;
            this.labelLengthToUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthToUser.ForeColor = System.Drawing.Color.White;
            this.labelLengthToUser.Location = new System.Drawing.Point(597, 44);
            this.labelLengthToUser.Name = "labelLengthToUser";
            this.labelLengthToUser.Size = new System.Drawing.Size(230, 52);
            this.labelLengthToUser.TabIndex = 10;
            this.labelLengthToUser.Text = "Length to User: ";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.labelLengthToUser);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.labelHobbies);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAllName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAllName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelHobbies;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelLengthToUser;
    }
}