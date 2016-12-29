// Read XML data into a dataset: https://msdn.microsoft.com/en-us/library/ekw4dh3f.aspx

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Read XML file on button click
        private void ReadXmlButton_Click(object sender, EventArgs e)
        {
            // Path to XML file
            string filePath = @"C:\Users\jrmer\Amazon Drive\Dev Lab\ReadingXML\ReadingXMLTestContent\Mech x Elec.xml";

            AuthorsDataSet.ReadXml(filePath);

            dataGridView1.DataSource = AuthorsDataSet;
            dataGridView1.DataMember = "clashresult";
        }
    }
}
