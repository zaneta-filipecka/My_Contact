using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Contact.Tests
{
    [TestClass()]
    public class formMyContactTests
    {
        [TestMethod()]
        public void formMyContactCleanFormTest()
        {
            var contactForm = new formMyContact();
            contactForm.textBoxId.Text = "1";
            contactForm.textBoxAddress.Text = "Address";

            contactForm.btnClean_Click();

            Assert.AreEqual("", contactForm.textBoxId.Text);
            Assert.AreEqual("", contactForm.textBoxAddress.Text);
        }
    }
}