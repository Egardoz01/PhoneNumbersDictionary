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
        public PhoneNumberDialog(PhoneNumber phone=null)
        {
            InitializeComponent();
            PhoneNumber = phone;
            if (PhoneNumber == null)
                PhoneNumber = new PhoneNumber();
            else
            {
                txtbxPhoneNumber.Text = PhoneNumber.PhoneNumberstr;
                txtbxtName.Text = PhoneNumber.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!doCheck())
                return;
            PhoneNumber.Name = txtbxtName.Text;
            PhoneNumber.PhoneNumberstr = txtbxPhoneNumber.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool doCheck()
        {
            if (txtbxPhoneNumber.Text == "")
            {
                lblErrors.Text = "Номер телефона не может быть пустым";
                lblErrors.Visible = true;
                return false;
            }

            if (txtbxtName.Text == "")
            {
                lblErrors.Text = "Имя контакта не может быть пустым";
                lblErrors.Visible = true;
                return false;
            }

            return true;
        }
    }
}
