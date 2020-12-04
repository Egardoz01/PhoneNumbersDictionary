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
        private Organization org;
        public MainForm()
        {
            db = new Db();
            InitializeComponent();
            AddContextMenu();

           org = new Organization();
        }

        private void AddContextMenu()
        {
            ContextMenu menu = new ContextMenu();

            MenuItem editItem = new MenuItem();
            editItem.Text = "Edit";
            editItem.Click += new EventHandler(EditPhoneNumberItem);

            MenuItem removeItem = new MenuItem();
            removeItem.Text = "Remove";
            removeItem.Click += new EventHandler(RemovePhoneNumberItem);


            menu.MenuItems.Add(editItem);
            menu.MenuItems.Add(removeItem);
            lbPhoneNumbers.ContextMenu = menu;
        }

        private void btnAddPhoneNumber_Click(object sender, EventArgs e)
        {
            PhoneNumberDialog dlg = new PhoneNumberDialog();
            dlg.ShowDialog();
            if (dlg.DialogResult == DialogResult.OK)
            {
                lbPhoneNumbers.Items.Add(dlg.PhoneNumber);
                org.PhoneNumbersToAdd.Add(dlg.PhoneNumber);
            }
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            AdditionalInfoDialog dlg = new AdditionalInfoDialog();
            dlg.ShowDialog();
            if (dlg.DialogResult == DialogResult.OK)
            {
                lbAdditionalInfo.Items.Add(dlg.AdditionalInfo);
                org.AdditionaInfosToAdd.Add(dlg.AdditionalInfo);
            }
        }

        private void btnAddOrganization_Click(object sender, EventArgs e)
        {
      
            org.Name = txtbxName.Text;
            org.Profile = txtbxProfile.Text;
            org.Location = txtbxLocation.Text;

            db.AddOrganization(org);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void EditPhoneNumberItem(object sender, EventArgs e)
        {
            PhoneNumber phone = (PhoneNumber)lbPhoneNumbers.SelectedItem;

          
        }

        private void RemovePhoneNumberItem(object sender, EventArgs e)
        {
            PhoneNumber phone = (PhoneNumber)lbPhoneNumbers.SelectedItem;
        }

        private void tabAddOrganization_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbAdditionalInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbxProfile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbPhoneNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
