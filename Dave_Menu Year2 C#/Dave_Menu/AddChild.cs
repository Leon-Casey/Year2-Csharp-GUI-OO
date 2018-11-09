using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Dave_Menu
{
    public partial class AddChild : Form
    {
        List<Child> childList = new List<Child>();
        public AddChild(List<Child> children)
        {
            childList = children;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string dob = txtDoB.Text;
            string description = txtDescription.Text;

            Child addChild = new Child(name,DateTime.Parse(dob), description);
            childList.Add(addChild);

            txtName.Text = null;
            txtDoB.Text = null;
            txtDescription.Text = null;

            string xmlPath = @"../../childData.xml";
            XDocument doc = XDocument.Load(xmlPath);
            XElement child = doc.Element("children");
            child.Add(new XElement("child",
                       new XElement("name", name),
                       new XElement("DoB", dob),
                       new XElement("description", description)));
            doc.Save(xmlPath);

        }
    }
}
