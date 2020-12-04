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
    public partial class OrganizationForm : Form
    {

        private readonly Db db;
        private Organization org;
        private bool _edit=false;
        public OrganizationForm(Db database, Organization organization = null)
        {
            db = database;
            InitializeComponent();
            AddContextMenu();
            if (organization == null)
            {
                org = new Organization();
            }
            else
            {
                org = organization;
                FillOrganizationData();
                _edit = true;
                lblMain.Text = "View/Edit Organization Data";
                btnAddOrganization.Text = "Save Changes";
                btnRemoveOrganization.Visible = true;
            }
        }

        private void AddContextMenu()
        {
            ContextMenu menu_phone = new ContextMenu();

            MenuItem editItem = new MenuItem();
            editItem.Text = "Edit";
            editItem.Click += new EventHandler(EditPhoneNumberItem);

            MenuItem removeItem = new MenuItem();
            removeItem.Text = "Remove";
            removeItem.Click += new EventHandler(RemovePhoneNumberItem);


            menu_phone.MenuItems.Add(editItem);
            menu_phone.MenuItems.Add(removeItem);
            lbPhoneNumbers.ContextMenu = menu_phone;

            ContextMenu menu_info = new ContextMenu();

            MenuItem editItem2 = new MenuItem();
            editItem2.Text = "Edit";
            editItem2.Click += new EventHandler(EditInfoItem);

            MenuItem removeItem2 = new MenuItem();
            removeItem2.Text = "Remove";
            removeItem2.Click += new EventHandler(RemoveInfoItem);


            menu_info.MenuItems.Add(editItem2);
            menu_info.MenuItems.Add(removeItem2);
            lbAdditionalInfo.ContextMenu = menu_info;



        }

        private void FillOrganizationData()
        {
            txtbxName.Text = org.Name;
            txtbxProfile.Text = org.Profile;
            txtbxLocation.Text = org.Location;

            foreach (var phone in org.PhoneNumbers)
            {
                lbPhoneNumbers.Items.Add(phone);
            }
            foreach (var info in org.AdditionalInfos)
            {
                lbAdditionalInfo.Items.Add(info);
            }

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
                org.AdditionalInfosToAdd.Add(dlg.AdditionalInfo);
            }
        }

        private void btnAddOrganization_Click(object sender, EventArgs e)
        {
      
            org.Name = txtbxName.Text;
            org.Profile = txtbxProfile.Text;
            org.Location = txtbxLocation.Text;

            if (!_edit)
            {
                db.AddOrganization(org);

                MessageBox.Show("Organization " + org.Name + " was successfully added");
            }
            else
            {
                db.EditOrganization(org);

                MessageBox.Show("Organization " + org.Name + " was successfully Saved");
            }
            Close();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void EditPhoneNumberItem(object sender, EventArgs e)
        {
            PhoneNumber phone = (PhoneNumber)lbPhoneNumbers.SelectedItem;
            if (phone != null)
            {
                PhoneNumberDialog dialog = new PhoneNumberDialog(new PhoneNumber(phone));
                dialog.ShowDialog();

                if (dialog.DialogResult == DialogResult.OK)
                {

                    if (org.PhoneNumbersToAdd.Contains(phone))
                    {
                        org.PhoneNumbersToAdd.Remove(phone);
                        org.PhoneNumbersToAdd.Add(dialog.PhoneNumber);
                    }
                    else
                    {
                        org.PhoneNumbersToEdit.RemoveAll(p => p.Id == dialog.PhoneNumber.Id);
                        org.PhoneNumbersToEdit.Add(dialog.PhoneNumber);
                    }
                    lbPhoneNumbers.Items[lbPhoneNumbers.SelectedIndex] = dialog.PhoneNumber;
                   
                }
            }
          
        }

        private void RemovePhoneNumberItem(object sender, EventArgs e)
        {
            PhoneNumber phone = (PhoneNumber)lbPhoneNumbers.SelectedItem;
            if (phone != null)
            {
                var result = MessageBox.Show("Do you really want to remove selected phone Number?", "Remove Phone Number",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    lbPhoneNumbers.Items.Remove(phone);
                    org.PhoneNumbersToEdit.RemoveAll(p => p.Id == phone.Id);
                    var item = org.PhoneNumbersToAdd.FirstOrDefault(p => p.Name == phone.Name && p.PhoneNumberstr == phone.PhoneNumberstr);
                    if (item != null)
                        org.PhoneNumbersToAdd.Remove(item);
                    if (org.Id != 0)
                        org.PhoneNumbersToRemove.Add(phone);
                }
            }
        }

        private void EditInfoItem(object sender, EventArgs e)
        {
            AdditionalInfo info = (AdditionalInfo)lbAdditionalInfo.SelectedItem;
            if (info != null)
            {
                AdditionalInfoDialog dialog = new AdditionalInfoDialog(new AdditionalInfo(info));
                dialog.ShowDialog();

                if (dialog.DialogResult == DialogResult.OK)
                {

                    if (org.AdditionalInfosToAdd.Contains(info))
                    {
                        org.AdditionalInfosToAdd.Remove(info);
                        org.AdditionalInfosToAdd.Add(dialog.AdditionalInfo);
                    }
                    else
                    {
                        org.AdditionalInfosToEdit.RemoveAll(p => p.Id == dialog.AdditionalInfo.Id);
                        org.AdditionalInfosToEdit.Add(dialog.AdditionalInfo);
                    }
                    lbAdditionalInfo.Items[lbAdditionalInfo.SelectedIndex] = dialog.AdditionalInfo;

                }
            }

        }

        private void RemoveInfoItem(object sender, EventArgs e)
        {
            AdditionalInfo info = (AdditionalInfo)lbAdditionalInfo.SelectedItem;
            if (info != null)
            {
                var result = MessageBox.Show("Do you really want to remove selected Additional Info?", "Remove Additional Info",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    lbAdditionalInfo.Items.Remove(info);
                    org.AdditionalInfosToEdit.RemoveAll(p => p.Id == info.Id);
                    var item = org.AdditionalInfosToAdd.FirstOrDefault(p => p.InfoData == info.InfoData && p.InfoType == info.InfoType);
                    if (item != null)
                        org.AdditionalInfosToAdd.Remove(item);
                    if (org.Id != 0)
                        org.AdditionalInfosToRemove.Add(info);
                }
            }
        }


        private void btnRemoveOrganization_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Remove Organization",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                db.RemoveOrganization(org);

                MessageBox.Show("Organization " + org.Name + " was successfullyremoved");
                Close();
            }
        }
    }
}
