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
            LoadAllOrganizations();
        }


        private void LoadAllOrganizations()
        {
            lbOrganizations.Items.Clear();
            lbOrganizations.Items.AddRange(db.GetOrganizations(new OrganizationBasicFiltet()).ToArray());
        }
        private void LoadOrganizationsByFilter(IOrganizationFilter filter)
        {
            lbOrganizations.Items.Clear();
            lbOrganizations.Items.AddRange(db.GetOrganizations(filter).ToArray());
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAllOrganizations();
        }

        private void lbOrganizations_DoubleClick(object sender, EventArgs e)
        {
            Organization org = (Organization)lbOrganizations.SelectedItem;
            OrganizationForm form = new OrganizationForm(db,org);
            form.ShowDialog();
            LoadAllOrganizations();
        }

        private void btnOrgSearch_Click(object sender, EventArgs e)
        {
            OrganizationFilterByData filter = new OrganizationFilterByData();
            filter.orgName = txtbxOrgName.Text;
            filter.orgNameComplete = rbNameComplete.Checked;
            filter.orgLocation = txtbxOrgLocation.Text;
            filter.orgLocationComplete = rbLocationComplete.Checked;
            filter.orgProfile = txtbxOrgProfile.Text;
            filter.orgProfileComplete = rbProfileComplete.Checked;
            LoadOrganizationsByFilter(filter);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadAllOrganizations();
        }

        private void btnPhoneSearch_Click(object sender, EventArgs e)
        {
            OrganizationFilterByPhone filter = new OrganizationFilterByPhone();
            filter.PhoneNumber = txtbxPhoneNumber.Text;
            filter.CompleteMatch = rbPhoneCompleteMatch.Checked;
            filter.IncludeOldNumbers = cbPhoneOldNumbers.Checked;
            LoadOrganizationsByFilter(filter);
        }

        private void btnSearchByInfo_Click(object sender, EventArgs e)
        {
            OrganizationFilterByInfo filter = new OrganizationFilterByInfo();
            filter.InfoData = txtbxInfoData.Text;
            filter.InfoType = txtbxInfoType.Text;
            filter.DataCompleteMatch = rbInfoDataComplete.Checked;
            filter.TypeCompleteMatch = rbInoTypeComlete.Checked;
            LoadOrganizationsByFilter(filter);
        }

        private void btnSearchByFile_Click(object sender, EventArgs e)
        {
            OrganizationFilerByFile filter = new OrganizationFilerByFile();
            filter.Filename = txtbxFileName.Text;
            filter.FilenameCompleteMatch = rbFileComleteMatch.Checked;

            LoadOrganizationsByFilter(filter);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtbxOrgProfile_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
