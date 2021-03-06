﻿using System;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using My_Contact.DAL;
using My_Contact.Entity;

namespace My_Contact
{
    /// <summary>
    /// This is partial class that runs up the form 
    /// </summary>
    public partial class FormMyContact : Form
    {
        private MyContactContext context = new MyContactContext();
        
        /// <summary>
        /// Method where are initialized components of project
        /// </summary>
        public FormMyContact()
        {
            InitializeComponent();
        }

        private void FormMyContact_Load(object sender, EventArgs e)
        {
            var contacts = context.Contacts.ToList();
            dgvContactList.DataSource = contacts;
        }

        /// <summary>
        /// Method connected to click on clean button
        /// </summary>
        public void BtnClean_Click()
        {
            CleanForm();
        }

        /// <summary>
        /// Method connected with click add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnAdd_Click(object sender, EventArgs e)
        {
            if ("" == textBoxId.Text)
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
                    MessageBox.Show("Contact has been added");
                }
                catch (DbEntityValidationException /* dex*/)
                {
                    MessageBox.Show("Failed to save");
                    context = new MyContactContext();
                }

                var contacts = context.Contacts.ToList();
                dgvContactList.DataSource = contacts;
                CleanForm();
            } else
            {
                MessageBox.Show("Failed to save");
                context = new MyContactContext();
            }
        }

        private void CleanForm()
        {
            textBoxId.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
            textBoxCompany.Text = "";
        }

        /// <summary>
        /// Method connected with clicking on header of row on datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxId.Text = dgvContactList.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxFirstName.Text = dgvContactList.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dgvContactList.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxAddress.Text = dgvContactList.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxEmail.Text = dgvContactList.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxPhone.Text = dgvContactList.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxCompany.Text = dgvContactList.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        /// <summary>
        /// Method connected with clicking on update button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if ("" != textBoxId.Text)
            {
                var contact = new Contact
                {
                    Id = int.Parse(textBoxId.Text),
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    Phone = textBoxPhone.Text,
                    Address = textBoxAddress.Text,
                    Email = textBoxEmail.Text,
                    Company = textBoxCompany.Text
                };

                try
                {
                    context.Contacts.AddOrUpdate(c => c.Id, contact);
                    context.SaveChanges();
                    MessageBox.Show("Contact has been updated");
                }
                catch (DbEntityValidationException /* dex*/)
                {
                    MessageBox.Show("Failed to update");
                    context = new MyContactContext();
                }

                var contacts = context.Contacts.ToList();
                dgvContactList.DataSource = contacts;
                CleanForm();
            } else
            {
                MessageBox.Show("Failed to update");
                context = new MyContactContext();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if ("" != textBoxId.Text)
            {
                try
                {
                    Contact contact = context.Contacts.Find(int.Parse(textBoxId.Text));
                    context.Contacts.Remove(contact);
                    context.SaveChanges();
                    MessageBox.Show("Contact has been deleted");
                }
                catch (DbEntityValidationException /* dex*/)
                {
                    MessageBox.Show("Failed to delete");
                    context = new MyContactContext();
                }

                var contacts = context.Contacts.ToList();
                dgvContactList.DataSource = contacts;
                CleanForm();
            } else
            {
                MessageBox.Show("Failed to delete");
                context = new MyContactContext();
            }
        }

        /// <summary>
        /// Method connected with click on clean button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;
            var contacts = from c in context.Contacts
                           where c.FirstName.Contains(keyword)
                           || c.LastName.Contains(keyword)
                           || c.Email.Contains(keyword)
                           || c.Address.Contains(keyword)
                           || c.Company.Contains(keyword)
                           || c.Phone.Contains(keyword)
                           select c;
            dgvContactList.DataSource = contacts.ToList();

        }
    }
}
