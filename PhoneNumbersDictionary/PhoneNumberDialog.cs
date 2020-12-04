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
    public partial class PhoneNumberDialog : Form
    {

        public PhoneNumber PhoneNumber { get; set; }
        public PhoneNumberDialog()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!doCheck())
                return;
            PhoneNumber = new PhoneNumber();
            PhoneNumber.Name = txtbxtName.Text;
            PhoneNumber.PhoneNumberstr = txtbxPhoneNumber.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool doCheck()
        {
            if (txtbxPhoneNumber.Text == "")
            {
                lblErrors.Text = "Phone Number should not be empty";
                lblErrors.Visible = true;
                return false;
            }

            if (txtbxtName.Text == "")
            {
                lblErrors.Text = "Contact Name should not be empty";
                lblErrors.Visible = true;
                return false;
            }

            return true;
        }
    }
}
