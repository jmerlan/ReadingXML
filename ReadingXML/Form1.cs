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

        private void ReadXmlButton_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\jrmer\Amazon Drive\Dev Lab\ReadingXML\ReadingXML\authors.xml";

            AuthorsDataSet.ReadXml(filePath);

            dataGridView1.DataSource = AuthorsDataSet;
            dataGridView1.DataMember = "authors";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.StringWriter swXML = new System.IO.StringWriter();
            AuthorsDataSet.WriteXmlSchema(swXML);
            textBox1.Text = swXML.ToString();
        }


    }
}
