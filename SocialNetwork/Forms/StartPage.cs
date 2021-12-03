using SocialNetwork.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DTO;
using BLL;

namespace SocialNetwork
{
    public partial class StartPage : Form
    {
        string userIdCurrent;
        public StartPage(string userIdCurrent)
        {
            InitializeComponent();
            this.userIdCurrent = userIdCurrent;
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            List<Post> postsList = PostManager.GetSortedPosts();

            List<PostF> listItems = new List<PostF>();

            foreach (var item in postsList)
            {
                listItems.Add(new PostF(item.Id, userIdCurrent));
                var last = listItems.Last();
                last.TopLevel = false;
                flowLayoutPanel1.Controls.Add(last);
                last.Show();
            }
        }

        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                var userIdProfile = UserManager.FindUserProfile(textBoxSearchUser.Text);
                UserProfile up = new UserProfile(userIdProfile, userIdCurrent);
                up.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            using (AddPost f = new AddPost())
            {
                var temp = f.ShowDialog();
                if(temp == DialogResult.OK)
                {
                    var newPost = f.newPost;
                    newPost.UserIdPost = userIdCurrent;
                    PostManager.AddPost(newPost);
                    PostF p = new PostF(newPost.Id, userIdCurrent);
                    p.TopLevel = false;
                    flowLayoutPanel1.Controls.Add(p);
                    flowLayoutPanel1.Controls.SetChildIndex(p,0);
                    p.Show();
                }
            }
        }
    }
}
