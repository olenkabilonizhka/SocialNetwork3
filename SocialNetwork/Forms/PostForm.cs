using System;
using System.Windows.Forms;
using SocialNetwork.Forms;
using BLL;
using DTO;

namespace SocialNetwork
{
    public partial class PostF : Form
    {
        string postId;
        string userIdCurrent;

        public PostF(string postId, string userIdCurrent)
        {
            this.postId = postId;
            this.userIdCurrent = userIdCurrent;
            InitializeComponent();
        }

        private void PostF_Load(object sender, EventArgs e)
        {
            Post p = PostManager.GetPostById(postId);
            labelTitle.Text = p.Title;
            labelBodyPost.Text = p.Body;
            labelLikes.Text = "Likes: " + p.LikesPost.ToString();
            if (p.UserIdPost != userIdCurrent)
            {
                EditPostButton.Visible = false;
            }
        }

        private void buttonLikes_Click(object sender, EventArgs e)
        {
            PostManager.LikePost(postId, userIdCurrent);

            labelLikes.Text = "Likes: " + PostManager.GetPostById(postId).LikesPost.ToString();
        }

        private void buttonComments_Click(object sender, EventArgs e)
        {
            using (Comments cm = new Comments(postId, userIdCurrent))
            {
                cm.ShowDialog();
            }
        }

        private void EditPostButton_Click(object sender, EventArgs e)
        {
            labelBodyPost.Visible = false;
            PostBodyTextBox.Visible = true;
            PostBodyTextBox.Text = labelBodyPost.Text;
            EditPostButton.Visible = false;
            SaveButton.Visible = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            PostBodyTextBox.Visible = false;
            labelBodyPost.Text = PostBodyTextBox.Text;
            PostManager.SavePost(postId, PostBodyTextBox.Text);
            labelBodyPost.Visible = true;
            EditPostButton.Visible = true;
            SaveButton.Visible = false;
        }
    }
}
