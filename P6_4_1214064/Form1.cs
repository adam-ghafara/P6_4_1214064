using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Media;

namespace P6_4_1214064
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                errorProvider.SetError(tbEmail, "");
                checkProvider.SetError(tbEmail, "Email Available");
                warnProvider.SetError(tbEmail, "");
            }
            else
            {
                errorProvider.SetError(tbEmail, "Email filled with wrong format. Example: name@domain.dmn");
                checkProvider.SetError(tbEmail, "");
                warnProvider.SetError(tbEmail, "");
            }
            if ((tbEmail.Text) == "" )
            {
                errorProvider.SetError(tbEmail, "");
                checkProvider.SetError(tbEmail, "");
                warnProvider.SetError(tbEmail, "Please fill the Email");
            }
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 15)
            {
                errorProvider.SetError(tbName, "Maximum Nickname Length is 15");
                warnProvider.SetError(tbName, "");
                checkProvider.SetError(tbName, "");
            }
            else if (tbName.Text.Length < 15)
            {
                errorProvider.SetError(tbName, "");
                warnProvider.SetError(tbName, "");
                checkProvider.SetError(tbName, "Nickname Available");
            }
            if ((tbName.Text) == "")
            {
                errorProvider.SetError(tbName, "");
                warnProvider.SetError(tbName, "Please fill the Nickname");
                checkProvider.SetError(tbName, "");
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btUppercase_Click(object sender, EventArgs e)
        {
            tbName.Text = tbName.Text.ToUpper();
        }

        private void btLowercase_Click(object sender, EventArgs e)
        {
            tbName.Text = tbName.Text.ToLower();
        }

        private void tbPhone_Leave(object sender, EventArgs e)
        {
            if ((tbPhone.Text).All(Char.IsNumber))
            {
                errorProvider.SetError(tbPhone, "");
                warnProvider.SetError(tbPhone, "");
                checkProvider.SetError(tbPhone, "Phone Number Available");
            }
            else
            {
                errorProvider.SetError(tbPhone, "Numbers Only");
                warnProvider.SetError(tbPhone, "");
                checkProvider.SetError(tbPhone, "");
            }
            if ((tbPhone.Text) == "")
            {
                errorProvider.SetError(tbPhone, "");
                warnProvider.SetError(tbPhone, "Please fill the Phone Number!");
                checkProvider.SetError(tbPhone, "");
            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if ((tbName.Text) == "")
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nickname required, please fill the Nickname!");
            }
            if ((tbPhone.Text) == "")
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Phone Number required, please fill the Phone Number!");
            }
            if ((tbEmail.Text) == "")
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Email required, please fill the Email!");
            }
            else
            {
                MessageBox.Show("Register Successful!");
            }
        }

        private void tbTwitter_Leave(object sender, EventArgs e)
        {
            if ((tbTwitter.Text).All(Char.IsUpper))
            {
                errorProvider.SetError(tbTwitter, "Lowercase Only");
                warnProvider.SetError(tbTwitter, "");
                checkProvider.SetError(tbTwitter, "");
            }
            else if ((tbTwitter.Text).All(Char.IsLower))
            {
                errorProvider.SetError(tbTwitter, "");
                warnProvider.SetError(tbTwitter, "");
                checkProvider.SetError(tbTwitter, "Ok!");
            }
        }

        private void tbInstagram_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbInstagram_Leave(object sender, EventArgs e)
        {
            if ((tbInstagram.Text).All(Char.IsUpper))
            {
                errorProvider.SetError(tbInstagram, "Lowercase Only");
                warnProvider.SetError(tbInstagram, "");
                checkProvider.SetError(tbInstagram, "");
            }
            else if ((tbInstagram.Text).All(Char.IsLower))
            {
                errorProvider.SetError(tbInstagram, "");
                warnProvider.SetError(tbInstagram, "");
                checkProvider.SetError(tbInstagram, "Ok!");
            }
        }

        private void tbFacebook_Leave(object sender, EventArgs e)
        {
            if ((tbFacebook.Text).All(Char.IsLower))
            {
                errorProvider.SetError(tbFacebook, "Uppercase Only");
                warnProvider.SetError(tbFacebook, "");
                checkProvider.SetError(tbFacebook, "");
            }
            else if ((tbFacebook.Text).All(Char.IsUpper))
            {
                errorProvider.SetError(tbFacebook, "");
                warnProvider.SetError(tbFacebook, "");
                checkProvider.SetError(tbFacebook, "Ok!");
            }
        }
    }
}
