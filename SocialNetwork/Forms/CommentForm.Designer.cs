
namespace SocialNetwork.Forms
{
    partial class CommentForm
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
            this.labelCommentBody = new System.Windows.Forms.Label();
            this.labelCommentLikes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLikeComment = new System.Windows.Forms.Button();
            this.CommentBodyTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCommentBody
            // 
            this.labelCommentBody.AutoEllipsis = true;
            this.labelCommentBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCommentBody.ForeColor = System.Drawing.Color.White;
            this.labelCommentBody.Location = new System.Drawing.Point(12, 9);
            this.labelCommentBody.Name = "labelCommentBody";
            this.labelCommentBody.Size = new System.Drawing.Size(392, 23);
            this.labelCommentBody.TabIndex = 2;
            this.labelCommentBody.Text = "labelCommentBody";
            // 
            // labelCommentLikes
            // 
            this.labelCommentLikes.AutoEllipsis = true;
            this.labelCommentLikes.ForeColor = System.Drawing.Color.White;
            this.labelCommentLikes.Location = new System.Drawing.Point(14, 49);
            this.labelCommentLikes.Name = "labelCommentLikes";
            this.labelCommentLikes.Size = new System.Drawing.Size(112, 23);
            this.labelCommentLikes.TabIndex = 5;
            this.labelCommentLikes.Text = "Likes: ";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-3, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 1);
            this.panel1.TabIndex = 6;
            // 
            // buttonLikeComment
            // 
            this.buttonLikeComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLikeComment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLikeComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLikeComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLikeComment.Location = new System.Drawing.Point(315, 49);
            this.buttonLikeComment.Name = "buttonLikeComment";
            this.buttonLikeComment.Size = new System.Drawing.Size(89, 27);
            this.buttonLikeComment.TabIndex = 7;
            this.buttonLikeComment.Text = "Like";
            this.buttonLikeComment.UseVisualStyleBackColor = true;
            this.buttonLikeComment.Click += new System.EventHandler(this.buttonLikeComment_Click);
            // 
            // CommentBodyTextBox
            // 
            this.CommentBodyTextBox.Location = new System.Drawing.Point(12, 12);
            this.CommentBodyTextBox.Multiline = true;
            this.CommentBodyTextBox.Name = "CommentBodyTextBox";
            this.CommentBodyTextBox.Size = new System.Drawing.Size(335, 34);
            this.CommentBodyTextBox.TabIndex = 8;
            this.CommentBodyTextBox.Visible = false;
            // 
            // EditButton
            // 
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(220, 49);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(89, 27);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(353, 16);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(51, 27);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveCommentButton_Click);
            // 
            // CommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(416, 81);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CommentBodyTextBox);
            this.Controls.Add(this.buttonLikeComment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCommentLikes);
            this.Controls.Add(this.labelCommentBody);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommentForm";
            this.Text = "CommentF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCommentBody;
        private System.Windows.Forms.Label labelCommentLikes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLikeComment;
        private System.Windows.Forms.TextBox CommentBodyTextBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButton;
    }
}