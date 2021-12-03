using System;
using System.Windows.Forms;
using BLL;
using DTO;

namespace SocialNetwork.Forms
{
    public partial class CommentForm : Form
    {
        string postId;
        string userIdCurrent;
        string commentId;

        public CommentForm(string postId, string commentId, string userIdCurrent)
        {
            try
            {
                InitializeComponent();
                this.postId = postId;
                this.userIdCurrent = userIdCurrent;
                this.commentId = commentId;
                Comment cm = PostManager.GetCommentById(postId, commentId);
                labelCommentBody.Text = cm.CommentBody;
                labelCommentLikes.Text = "Likes: " + cm.Likes;
                if (PostManager.GetUserIdByCommentId(commentId) != userIdCurrent)
                {
                    EditButton.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLikeComment_Click(object sender, EventArgs e)
        {
            PostManager.LikeComment(postId, commentId, userIdCurrent);

            labelCommentLikes.Text = "Likes: " + PostManager.GetCommentById(postId,commentId).Likes;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            labelCommentBody.Visible = false;
            CommentBodyTextBox.Visible = true;
            CommentBodyTextBox.Text = labelCommentBody.Text;
            EditButton.Visible = false;
            SaveButton.Visible = true;
        }

        private void SaveCommentButton_Click(object sender, EventArgs e)
        {
            CommentBodyTextBox.Visible = false;
            labelCommentBody.Text = CommentBodyTextBox.Text;
            PostManager.SaveComment(postId,commentId,CommentBodyTextBox.Text);
            labelCommentBody.Visible = true;
            EditButton.Visible = true;
            SaveButton.Visible = false;
        }
    }
}
