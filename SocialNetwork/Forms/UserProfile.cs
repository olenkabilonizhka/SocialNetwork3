using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SocialNetwork.Forms
{
    public partial class UserProfile : Form
    {
        string userIdProfile;
        string userIdCurrent;

        public UserProfile(string userIdProfile, string userIdCurrent)
        {
            InitializeComponent();
            this.userIdProfile = userIdProfile;
            this.userIdCurrent = userIdCurrent;
            buttonFriends.Text = (UserManager.IfFollower(userIdCurrent, userIdProfile)) ? "You are following" : "Follow";
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            List<Post> postsList = PostManager.GetUserPosts(userIdProfile);

            List<PostF> listItems = new List<PostF>();

            foreach (var item in postsList)
            {
                listItems.Add(new PostF(item.Id, userIdCurrent));
                var last = listItems.Last();
                last.TopLevel = false;
                flowLayoutPanel1.Controls.Add(last);
                last.Show();
            }

            User u = UserManager.GetUserById(userIdProfile);
            labelAllName.Text = u.FirstName + " " + u.LastName;
            labelEmail.Text = u.Email;
            foreach (var item in u.Hobbies)
            {
                labelHobbies.Text += item +", ";
            }

            var l = UserManager.LengthToUser(userIdCurrent, userIdProfile).ToString();
            switch (l)
            {
                case "0": labelLengthToUser.Text += "Oops, your profile"; break;
                default: labelLengthToUser.Text += l; break;
            }

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            StartPage st = new StartPage(userIdCurrent);
            st.Show();
            this.Hide();
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            try
            {
                UserManager.FollowUser(userIdCurrent, userIdProfile);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            buttonFriends.Text = (UserManager.IfFollower(userIdCurrent, userIdProfile)) ? "You are following" : "Follow";
            labelLengthToUser.Text = "Length to User: "; 
            var l = UserManager.LengthToUser(userIdCurrent, userIdProfile).ToString();
            switch (l)
            {
                case "0": labelLengthToUser.Text += "Oops, your profile"; break;
                default: labelLengthToUser.Text += l; break;
            }
        }
    }
}
