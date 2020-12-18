using System;
using System.Drawing;
using System.IO;
using System.Linq;
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
                lblMain.Text = "Данные об Организации:";
                btnRemoveOrganization.Visible = true;
            }
        }

        private void AddContextMenu()
        {
            ContextMenu menu_phone = new ContextMenu();

            MenuItem editItem = new MenuItem();
            editItem.Text = "Изменить";
            editItem.Click += new EventHandler(EditPhoneNumberItem);

            MenuItem removeItem = new MenuItem();
            removeItem.Text = "Удалить";
            removeItem.Click += new EventHandler(RemovePhoneNumberItem);


            menu_phone.MenuItems.Add(editItem);
            menu_phone.MenuItems.Add(removeItem);
            lbPhoneNumbers.ContextMenu = menu_phone;

            ContextMenu menu_info = new ContextMenu();

            MenuItem editItem2 = new MenuItem();
            editItem2.Text = "Изменить";
            editItem2.Click += new EventHandler(EditInfoItem);

            MenuItem removeItem2 = new MenuItem();
            removeItem2.Text = "Удалить";
            removeItem2.Click += new EventHandler(RemoveInfoItem);

            menu_info.MenuItems.Add(editItem2);
            menu_info.MenuItems.Add(removeItem2);
            lbAdditionalInfo.ContextMenu = menu_info;


            ContextMenu menu_file = new ContextMenu();

            MenuItem openItem = new MenuItem();
            openItem.Text = "Изменить";
            openItem.Click += new EventHandler(OpenFileItem);

            MenuItem removeItem3 = new MenuItem();
            removeItem3.Text = "Удалить";
            removeItem3.Click += new EventHandler(RemoveFileItem);


            menu_file.MenuItems.Add(openItem);
            menu_file.MenuItems.Add(removeItem3);
            lbFiles.ContextMenu = menu_file;



        }

        private void FillOrganizationData()
        {
            db.LoadOrganizationData(org);

            if (File.Exists(org.PhotoPath))
            {
                try
                {
                    pbOrgPhoto.Image = new Bitmap(org.PhotoPath);
                    pbOrgPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке изображения "+ex.Message);
                }
            }

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
            foreach (var file in org.OrganizationFiles)
            {
                lbFiles.Items.Add(file);
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
            }
            else
            {
                db.EditOrganization(org);
            }

            MessageBox.Show("Организация " + org.Name + " Успешно Сохранена");
            Close();

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
                var result = MessageBox.Show("Вы действительно хотите удалить выбранный номер телефона?", "Удаление Номера Телефона",
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
                var result = MessageBox.Show("Вы действительно хотите удалить выбранную дополнительную информацию?", "Удаление доп. информации",
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

        private void RemoveFileItem(object sender, EventArgs e)
        {
            OrganizationFile file = (OrganizationFile)lbFiles.SelectedItem;
            if (file != null)
            {
                var result = MessageBox.Show("Вы действительно хотите удалить выбранный файл?", "Удаление файла",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    lbFiles.Items.Remove(file);
                  
                    var item = org.OrganizationFilesToAdd.FirstOrDefault(p => p.Path == file.Path);
                    if (item != null)
                        org.OrganizationFilesToAdd.Remove(item);
                    if (org.Id != 0)
                        org.OrganizationFilesToRemove.Add(file);
                }
            }
        }

        private void OpenFileItem(object sender, EventArgs e)
        {
            OrganizationFile file = (OrganizationFile)lbFiles.SelectedItem;
            if (file != null)
            {
                if (File.Exists(file.Path))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(file.Path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при открытии файла "+ ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Файл не найден");
                }
            }
        }


        private void btnRemoveOrganization_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены?", "Удалить Организацию",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                db.RemoveOrganization(org);

                MessageBox.Show("Организация " + org.Name + " Была успешно удалена");
                Close();
            }
        }

        private void btnBrowsePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Добавить изображение";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string localPath = db.copyFileLocally(org, dlg.FileName);
                    if(pbOrgPhoto.Image!=null)
                        pbOrgPhoto.Image.Dispose();
                    pbOrgPhoto.Image = new Bitmap(localPath);
                    pbOrgPhoto.SizeMode = PictureBoxSizeMode.StretchImage;

                    db.deleteFile(org.PhotoPath);
                    org.PhotoPath = localPath;
                }
            }

        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Добавить файл";
               
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string localPath = db.copyFileLocally(org, dlg.FileName);

                    OrganizationFile file = new OrganizationFile();
                    file.Name = Path.GetFileName(dlg.FileName);
                    file.Path = localPath;
                    org.OrganizationFilesToAdd.Add(file);
                    lbFiles.Items.Add(file);
                }
            }
        }
    }
}
