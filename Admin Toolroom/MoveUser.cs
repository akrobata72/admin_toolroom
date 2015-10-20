using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;

namespace Admin_Toolroom
{
    public partial class MoveUser : Form
    {
        public MoveUser(string l, string dc, string pwd, string domain, string admin, string dname)
        {
            InitializeComponent();
            lblUser.Text = l;
            lblDC.Text = dc;
            lblPwd.Text = pwd;
            lblDomain.Text = domain;
            lblAdminUser.Text = admin;
            lblDName.Text = dname;

            DirectoryEntry de = new DirectoryEntry("LDAP://" + lblDomain.Text.ToString());

            de.Username = lblAdminUser.Text;
            de.Password = lblPwd.Text;
            DirectorySearcher ds = new DirectorySearcher(de);
            ds.SearchScope = SearchScope.Subtree;
            ds.Filter = "(objectCategory=OrganizationalUnit)";

            ds.PropertiesToLoad.Add("distinguishedName");

            try
            {
                //SearchResultCollection result = ds.FindAll();


                foreach (SearchResult r in ds.FindAll())
                {
                    cmbOU.Items.Add(r.Properties["distinguishedName"][0]);
                }

            }

            catch (Exception f)
            {
                MessageBox.Show("Error: " + f.Message);

            }
        }

        private void btnPremesti_Click(object sender, EventArgs e)
        {
            if (cmbOU.SelectedItem != null)
            {

                string userOU = "LDAP://" + lblDC.Text + @"/" + cmbOU.SelectedItem.ToString();
                string moveUser = lblDName.Text.ToString();

                DirectoryEntry de = new DirectoryEntry("LDAP://" + lblDomain.Text);

                de.Username = lblAdminUser.Text;
                de.Password = lblPwd.Text;

                DirectorySearcher ds = new DirectorySearcher(de);
                ds.SearchScope = SearchScope.Subtree;
                ds.Filter = "(&(objectCategory=User) (samAccountName=" + "*" + lblDName.Text + "*" + "))";
                ds.PropertiesToLoad.Clear();
                ds.PropertiesToLoad.Add("distinguishedName");

                try
                {
                    SearchResult result = ds.FindOne();

                    if (result != null)
                    {
                        string t = "LDAP://" + lblDC.Text + @"/" + result.Properties["distinguishedName"][0].ToString();
                        DirectoryEntry moved = new DirectoryEntry(t);
                        //MessageBox.Show(t);
                        //MessageBox.Show(userOU);
                        moved.MoveTo(new DirectoryEntry(userOU,lblAdminUser.Text,lblPwd.Text,AuthenticationTypes.Secure));
                        moved.CommitChanges();
                        moved.Close();
                     //MessageBox.Show(result.Properties["distinguishedName"][0].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Greška, operacija nije uspela!");
                    }


                }
                catch (Exception f)
                {
                    MessageBox.Show(f.ToString());
                }
            }

        }
    }
}

