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
        DataSet dataSet = new DataSet();
        DataSet detailsDataSet = new DataSet();
        DataTable xdocDataTable = new DataTable();
        XDocument doc = new XDocument();
        XmlDocument xDoc = new XmlDocument();

        // UI support
        Int32 selectedRowCount = 0;
        XmlNode selectedNode;
        string selectedGuid;

        public Form1()
        {
            InitializeComponent();

            // Select whole row
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

                // Load xmlFile into xDoc
                xDoc.Load(fileNameWithPath);

                // Displays the current fileNameWithPath in status bar
                statusTextBox.Text = "Loaded: " + fileNameWithPath;
              
                // Create xml reader
                XmlReader xmlFile = XmlReader.Create(fileNameWithPath, new XmlReaderSettings());

                // Read xml to dataset
                dataSet.ReadXml(xmlFile);

                // Pass table to datagridview datasource
                dataGridView1.DataSource = dataSet.Tables["clashresult"];

                // Close xml reader
                xmlFile.Close();

            }
        }

        private void viewDetailsButton_Click(object sender, EventArgs e)
        {
            // Get selected rows: https://msdn.microsoft.com/en-us/library/x8x9zk5a(v=vs.110).aspx
            selectedRowCount =
            dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                //Create an XmlNamespaceManager for resolving namespaces.
                XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
                nsmgr.AddNamespace("bk", "urn:samples");

                //Select the clash node with the matching GUID.
                XmlNode clashResult;
                XmlElement root = xDoc.DocumentElement;
                clashResult = root.SelectSingleNode("descendant::clashresult[@guid='" + "73bb82ea-c041-4408-a006-8f2bce9ab9a2" + "']", nsmgr);

                // Temp: Show InnerXml in messagebox for testing
                detailsTextBox.Text = clashResult.InnerXml;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get row index on CellClick
            int currentRow = dataGridView1.SelectedCells[0].RowIndex;

            // Get currentRow value
            selectedGuid = dataGridView1.Rows[currentRow].Cells["guid"].Value.ToString();

            // Print stuff
            statusTextBox.Text = "Current row selected: " + currentRow.ToString() + 
                "   |   " + 
                "GUID: " + selectedGuid;
        }

    }
}

