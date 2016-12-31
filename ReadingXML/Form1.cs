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
        string rowDetails;

        // UI support
        Int32 selectedRowCount = 0;

        public Form1()
        {
            InitializeComponent();

            // Select whole row
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        // Enable the view details button
        //int curRow = -1;
        //private void dgv1_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dataGridView1.CurrentRow.Index != curRow)
        //    {
        //        //curRow = dataGridView2.CurrentRow.Index;
        //        viewDetailsButton.Enabled = true;

        //        // TEMP: Displays the current fileNameWithPath in status bar
        //        filePathTextBox.Text = "Selected: " + curRow;
        //    }
        //}

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

                // Displays the current fileNameWithPath in status bar
                filePathTextBox.Text = "Loaded: " + fileNameWithPath;

                // Create xml reader
                XmlReader xmlFile = XmlReader.Create(fileNameWithPath, new XmlReaderSettings());
                DataSet dataSet = new DataSet();

                // Read xml to dataset
                dataSet.ReadXml(xmlFile);

                // Pass empdetails table to datagridview datasource
                dataGridView1.DataSource = dataSet.Tables["clashresult"];

                // Close xml reader
                xmlFile.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowCount = 1;

            if (selectedRowCount > 0)
            {
                this.viewDetailsButton.Enabled = true;
            }
        }

        private void viewDetailsButton_Click(object sender, EventArgs e)
        {
            // Get selected rows: https://msdn.microsoft.com/en-us/library/x8x9zk5a(v=vs.110).aspx
            selectedRowCount =
            dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                // Enable button
                viewDetailsButton.Enabled = true;

                // Print details of selected row number to MessageBox
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append("Row: ");
                    sb.Append(dataGridView1.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Total: " + selectedRowCount.ToString());
                MessageBox.Show(sb.ToString(), "Selected Rows");

                //// Print selected row number to MessageBox
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();

                //for (int i = 0; i < selectedRowCount; i++)
                //{
                //    sb.Append("Row: ");
                //    sb.Append(dataGridView1.SelectedRows[i].Index.ToString());
                //    sb.Append(Environment.NewLine);
                //}

                //sb.Append("Total: " + selectedRowCount.ToString());
                //MessageBox.Show(sb.ToString(), "Selected Rows");
            }
        }
            
        static string GetAttributeText(XmlNode inXmlNode, string name)
        {
            XmlAttribute attr = (inXmlNode.Attributes == null ? null : inXmlNode.Attributes[name]);
            return attr == null ? null : attr.Value;
        }
    }
}

