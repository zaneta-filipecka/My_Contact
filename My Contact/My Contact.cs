using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using My_Contact.DAL;
using My_Contact.Entity;

namespace My_Contact
{
    public partial class formMyContact : Form
    {
        private MyContactContext context = new MyContactContext();
        public formMyContact()
        {
            InitializeComponent();
        }

        private void formMyContact_Load(object sender, EventArgs e)
        {
            var contacts = context.Contacts.ToList();
            dgvContactList.DataSource = contacts;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var contact = new Contact
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Phone = textBoxPhone.Text,
                Address = textBoxAddress.Text,
                Email = textBoxEmail.Text,
                Company = textBoxCompany.Text
            };

            try
            {
                context.Contacts.Add(contact);
                context.SaveChanges();
                MessageBox.Show("Saved contact");
            }
            catch (DbEntityValidationException /* dex*/)
            {
                MessageBox.Show("Failed to save");
                context = new MyContactContext();
            }

            var contacts = context.Contacts.ToList();
            dgvContactList.DataSource = contacts;
            cleanForm();
        }

        private void cleanForm()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
            textBoxCompany.Text = "";
        }
    }
}
