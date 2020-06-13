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

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxId.Text = dgvContactList.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxFirstName.Text = dgvContactList.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dgvContactList.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxAddress.Text = dgvContactList.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxEmail.Text = dgvContactList.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxPhone.Text = dgvContactList.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxCompany.Text = dgvContactList.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
