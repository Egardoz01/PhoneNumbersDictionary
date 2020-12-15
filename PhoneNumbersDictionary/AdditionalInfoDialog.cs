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
    public partial class AdditionalInfoDialog : Form
    {
        public AdditionalInfo AdditionalInfo;
        public AdditionalInfoDialog(AdditionalInfo info = null)
        {
            InitializeComponent();
            AdditionalInfo = info;
            if (AdditionalInfo != null)
            {
                txtbxInfoData.Text = AdditionalInfo.InfoData;
                txtbxInfoType.Text = AdditionalInfo.InfoType;
            }
            else
                AdditionalInfo = new AdditionalInfo();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!doCeck())
                return;
            AdditionalInfo.InfoData = txtbxInfoData.Text;
            AdditionalInfo.InfoType = txtbxInfoType.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool doCeck()
        {
            if (txtbxInfoType.Text == "")
            {
                lblErrors.Text = "Название доп. информации не может быть пустым";
                lblErrors.Visible = true;
                return false;
            }

            if (txtbxInfoData.Text == "")
            {
                lblErrors.Text = "Значение доп. информции не может быть пустым";
                lblErrors.Visible = true;
                return false;
            }
           

            return true;
        }
    }
}
