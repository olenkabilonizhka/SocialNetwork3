using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SocialNetwork.Forms
{
    public partial class AddComment : Form
    {
        public Comment newComment;
        public AddComment()
        {
            InitializeComponent();
        }
        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            newComment = new Comment { CommentBody = textBoxBody.Text, Likes = 0, LikesUsers = new List<string>() };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
