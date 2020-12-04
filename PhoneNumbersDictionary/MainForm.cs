using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneNumbersDictionary
{
    public partial class MainForm : Form
    {
        private readonly Db db; 
        public MainForm()
        {
            InitializeComponent();
            db = new Db();
        }

        private void btnAddOrganization_Click(object sender, EventArgs e)
        {
            OrganizationForm form = new OrganizationForm(db);
            form.ShowDialog();
            LoadOrganizations();
        }


        private void LoadOrganizations(string query = "")
        {
            lbOrganizations.Items.Clear();
            lbOrganizations.Items.AddRange(db.GetOrganizations(query).ToArray());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadOrganizations();
        }

        private void lbOrganizations_DoubleClick(object sender, EventArgs e)
        {
            Organization org = (Organization)lbOrganizations.SelectedItem;
            OrganizationForm form = new OrganizationForm(db,org);
            form.ShowDialog();
            LoadOrganizations();
        }

        private void btnOrgSearch_Click(object sender, EventArgs e)
        {
            string query = OrganizationFilter.GetQuery(txtbxOrgName.Text,rbNameComplete.Checked,
                                                              txtbxOrgLocation.Text,rbLocationComplete.Checked,
                                                              txtbxOrgProfile.Text,rbProfileComplete.Checked);
            LoadOrganizations(query);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadOrganizations();
        }
    }
}
