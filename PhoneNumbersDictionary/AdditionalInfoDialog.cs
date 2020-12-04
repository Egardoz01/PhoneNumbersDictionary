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
        public AdditionaInfo AdditionalInfo;
        public AdditionalInfoDialog(AdditionaInfo info = null)
        {
            InitializeComponent();
            AdditionalInfo = info;
            if (AdditionalInfo != null)
            {
                txtbxInfoData.Text = AdditionalInfo.InfoData;
                txtbxInfoType.Text = AdditionalInfo.InfoType;
            }
            else
                AdditionalInfo = new AdditionaInfo();
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
                lblErrors.Text = "Info Type shuld not be empty";
                lblErrors.Visible = true;
                return false;
            }

            if (txtbxInfoData.Text == "")
            {
                lblErrors.Text = "Info Data shuld not be empty";
                lblErrors.Visible = true;
                return false;
            }
           

            return true;
        }
    }
}
