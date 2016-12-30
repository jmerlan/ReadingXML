// Read XML data into a dataset: https://msdn.microsoft.com/en-us/library/ekw4dh3f.aspx
// Opening Files Using the OpenFileDialog Component: https://msdn.microsoft.com/en-us/library/aa984392(v=vs.71).aspx

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingXML
{
    public partial class Form1 : Form
    {

        // File support
        string fileNameWithPath;
        string fileDirectory;
        string fileName;

        public Form1()
        {
            InitializeComponent();
        }

        // Browse for a file
        private void xmlFileBrowser_Click(object sender, EventArgs e)
        {
            // Clear data
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Store filename and path in variables
                fileNameWithPath = openFileDialog1.FileName;
                fileDirectory = Path.GetDirectoryName(openFileDialog1.FileName);
                fileName = Path.GetFileName(openFileDialog1.FileName);

                // Displays the current fileNameWithPath in textbox
                filePathTextBox.Text = fileNameWithPath;

                // Create new DataSet object
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(fileNameWithPath);

                // Print dataset to data grid
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "clashresult";

            }
        }
    }
}

