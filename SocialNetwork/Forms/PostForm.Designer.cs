
namespace SocialNetwork
{
    partial class PostF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostF));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelBodyPost = new System.Windows.Forms.Label();
            this.buttonLikes = new System.Windows.Forms.Button();
            this.buttonComments = new System.Windows.Forms.Button();
            this.labelLikes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PostBodyTextBox = new System.Windows.Forms.TextBox();
            this.EditPostButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoEllipsis = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(160, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(578, 29);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "labelTitle";
            // 
            // labelBodyPost
            // 
            this.labelBodyPost.AutoEllipsis = true;
            this.labelBodyPost.ForeColor = System.Drawing.Color.White;
            this.labelBodyPost.Location = new System.Drawing.Point(160, 41);
            this.labelBodyPost.Name = "labelBodyPost";
            this.labelBodyPost.Size = new System.Drawing.Size(607, 70);
            this.labelBodyPost.TabIndex = 2;
            this.labelBodyPost.Text = "labelBodyPost";
            // 
            // buttonLikes
            // 
            this.buttonLikes.BackColor = System.Drawing.Color.White;
            this.buttonLikes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLikes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLikes.Location = new System.Drawing.Point(577, 114);
            this.buttonLikes.Name = "buttonLikes";
            this.buttonLikes.Size = new System.Drawing.Size(85, 23);
            this.buttonLikes.TabIndex = 3;
            this.buttonLikes.Text = "Like";
            this.buttonLikes.UseVisualStyleBackColor = false;
            this.buttonLikes.Click += new System.EventHandler(this.buttonLikes_Click);
            // 
            // buttonComments
            // 
            this.buttonComments.BackColor = System.Drawing.Color.White;
            this.buttonComments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonComments.Location = new System.Drawing.Point(668, 114);
            this.buttonComments.Name = "buttonComments";
            this.buttonComments.Size = new System.Drawing.Size(117, 23);
            this.buttonComments.TabIndex = 4;
            this.buttonComments.Text = "Сomments";
            this.buttonComments.UseVisualStyleBackColor = false;
            this.buttonComments.Click += new System.EventHandler(this.buttonComments_Click);
            // 
            // labelLikes
            // 
            this.labelLikes.ForeColor = System.Drawing.Color.White;
            this.labelLikes.Location = new System.Drawing.Point(163, 114);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(101, 17);
            this.labelLikes.TabIndex = 5;
            this.labelLikes.Text = "labelLikes";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 1);
            this.panel1.TabIndex = 6;
            // 
            // PostBodyTextBox
            // 
            this.PostBodyTextBox.Location = new System.Drawing.Point(163, 41);
            this.PostBodyTextBox.Multiline = true;
            this.PostBodyTextBox.Name = "PostBodyTextBox";
            this.PostBodyTextBox.Size = new System.Drawing.Size(521, 51);
            this.PostBodyTextBox.TabIndex = 7;
            this.PostBodyTextBox.Visible = false;
            // 
            // EditPostButton
            // 
            this.EditPostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditPostButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EditPostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditPostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPostButton.ForeColor = System.Drawing.Color.White;
            this.EditPostButton.Location = new System.Drawing.Point(482, 114);
            this.EditPostButton.Name = "EditPostButton";
            this.EditPostButton.Size = new System.Drawing.Size(89, 22);
            this.EditPostButton.TabIndex = 8;
            this.EditPostButton.Text = "Edit";
            this.EditPostButton.UseVisualStyleBackColor = true;
            this.EditPostButton.Click += new System.EventHandler(this.EditPostButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(690, 53);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(95, 30);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PostF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(795, 152);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditPostButton);
            this.Controls.Add(this.PostBodyTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.buttonComments);
            this.Controls.Add(this.buttonLikes);
            this.Controls.Add(this.labelBodyPost);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostF";
            this.Text = "Post";
            this.Load += new System.EventHandler(this.PostF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBodyPost;
        private System.Windows.Forms.Button buttonLikes;
        private System.Windows.Forms.Button buttonComments;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PostBodyTextBox;
        private System.Windows.Forms.Button EditPostButton;
        private System.Windows.Forms.Button SaveButton;
    }
}