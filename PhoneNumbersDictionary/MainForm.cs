using System;
using System.Windows.Forms;

namespace PhoneNumbersDictionary
{
    public partial class MainForm : Form
    {
        private readonly Db db;
        private int pageSize;
        private int curPage;
        private IOrganizationFilter lastFilter;
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
            curPage = 1;
            LoadOrganizationsByFilter(new OrganizationBasicFilter());
        }
        private void LoadOrganizationsByFilter(IOrganizationFilter filter)
        {

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            var watch = System.Diagnostics.Stopwatch.StartNew();

            lastFilter = filter;
            pageSize = int.Parse(txtbxPageSIze.Text);

            int amount = db.GetOrganizationsCount(filter);
            lblOrgCount.Text = String.Format("По вашему запросу найдено {0} организаций",amount );
            lblCurPage.Text = String.Format("Страница {0} из {1}",curPage, (amount+pageSize-1)/pageSize);
            if (curPage == 1)
                btnPrevPage.Enabled = false;
            else
                btnPrevPage.Enabled = true;

            if (curPage * pageSize >= amount)
                btnNextPage.Enabled = false;
            else
                btnNextPage.Enabled = true;
            

            lbOrganizations.Items.Clear();
            lbOrganizations.Items.AddRange(db.GetOrganizations(filter, (curPage-1)*pageSize, pageSize).ToArray());


            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            lblExecutionTime.Text = "Выполнение запроса заняло "+elapsedMs/1000.0 +" секунд";

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
            curPage = 1;
            LoadAllOrganizations();
        }

        private void btnPhoneSearch_Click(object sender, EventArgs e)
        {
            curPage = 1;
            OrganizationFilterByPhone filter = new OrganizationFilterByPhone();
            filter.PhoneNumber = txtbxPhoneNumber.Text;
            filter.CompleteMatch = rbPhoneCompleteMatch.Checked;
            filter.IncludeOldNumbers = cbPhoneOldNumbers.Checked;
            LoadOrganizationsByFilter(filter);
        }

        private void btnSearchByInfo_Click(object sender, EventArgs e)
        {
            curPage = 1;
            OrganizationFilterByInfo filter = new OrganizationFilterByInfo();
            filter.InfoData = txtbxInfoData.Text;
            filter.InfoType = txtbxInfoType.Text;
            filter.DataCompleteMatch = rbInfoDataComplete.Checked;
            filter.TypeCompleteMatch = rbInoTypeComlete.Checked;
            LoadOrganizationsByFilter(filter);
        }

        private void btnSearchByFile_Click(object sender, EventArgs e)
        {
            curPage = 1;
            OrganizationFilerByFile filter = new OrganizationFilerByFile();
            filter.Filename = txtbxFileName.Text;
            filter.FilenameCompleteMatch = rbFileComleteMatch.Checked;

            LoadOrganizationsByFilter(filter);
        }

        private void txtbxPageSIze_Leave(object sender, EventArgs e)
        {
            int temp;
            if (!int.TryParse(txtbxPageSIze.Text, out temp))
            {
                MessageBox.Show("Вводимое значение должно быть числом");
                txtbxPageSIze.Focus();
            }
            else
            {
                LoadOrganizationsByFilter(lastFilter);
            }
            

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            curPage++;
            LoadOrganizationsByFilter(lastFilter);
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            curPage--;
            LoadOrganizationsByFilter(lastFilter);
        }
    }
}
