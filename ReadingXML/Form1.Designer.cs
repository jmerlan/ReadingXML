namespace ReadingXML
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.XMLDataSet = new System.Data.DataSet();
            this.statusBarPanel = new System.Windows.Forms.Panel();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.xmlFileBrowser = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ribbonPanel = new System.Windows.Forms.Panel();
            this.viewDetailsButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.containerPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XMLDataSet)).BeginInit();
            this.statusBarPanel.SuspendLayout();
            this.ribbonPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(155, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 487);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // XMLDataSet
            // 
            this.XMLDataSet.DataSetName = "AuthorsDataSet";
            // 
            // statusBarPanel
            // 
            this.statusBarPanel.Controls.Add(this.statusTextBox);
            this.statusBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarPanel.Location = new System.Drawing.Point(0, 531);
            this.statusBarPanel.Name = "statusBarPanel";
            this.statusBarPanel.Size = new System.Drawing.Size(1207, 23);
            this.statusBarPanel.TabIndex = 4;
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.statusTextBox.Location = new System.Drawing.Point(0, 0);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(1207, 20);
            this.statusTextBox.TabIndex = 3;
            this.statusTextBox.TabStop = false;
            this.statusTextBox.Text = "No clash report loaded.";
            // 
            // xmlFileBrowser
            // 
            this.xmlFileBrowser.AllowDrop = true;
            this.xmlFileBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xmlFileBrowser.AutoSize = true;
            this.xmlFileBrowser.Location = new System.Drawing.Point(1074, 5);
            this.xmlFileBrowser.Name = "xmlFileBrowser";
            this.xmlFileBrowser.Padding = new System.Windows.Forms.Padding(5);
            this.xmlFileBrowser.Size = new System.Drawing.Size(115, 33);
            this.xmlFileBrowser.TabIndex = 0;
            this.xmlFileBrowser.Text = "Load Clash Report";
            this.xmlFileBrowser.UseVisualStyleBackColor = true;
            this.xmlFileBrowser.Click += new System.EventHandler(this.xmlFileBrowser_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML Files|*.xml";
            // 
            // ribbonPanel
            // 
            this.ribbonPanel.Controls.Add(this.viewDetailsButton);
            this.ribbonPanel.Controls.Add(this.xmlFileBrowser);
            this.ribbonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonPanel.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel.Name = "ribbonPanel";
            this.ribbonPanel.Size = new System.Drawing.Size(1207, 44);
            this.ribbonPanel.TabIndex = 6;
            // 
            // viewDetailsButton
            // 
            this.viewDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewDetailsButton.AutoSize = true;
            this.viewDetailsButton.Location = new System.Drawing.Point(968, 5);
            this.viewDetailsButton.Name = "viewDetailsButton";
            this.viewDetailsButton.Padding = new System.Windows.Forms.Padding(5);
            this.viewDetailsButton.Size = new System.Drawing.Size(100, 33);
            this.viewDetailsButton.TabIndex = 0;
            this.viewDetailsButton.TabStop = false;
            this.viewDetailsButton.Text = "View Details";
            this.viewDetailsButton.UseVisualStyleBackColor = true;
            this.viewDetailsButton.Click += new System.EventHandler(this.viewDetailsButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.detailsTextBox);
            this.contentPanel.Controls.Add(this.dataGridView1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 44);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1207, 487);
            this.contentPanel.TabIndex = 7;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailsTextBox.Location = new System.Drawing.Point(0, 0);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(149, 487);
            this.detailsTextBox.TabIndex = 2;
            // 
            // containerPanel
            // 
            this.containerPanel.AutoSize = true;
            this.containerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.containerPanel.Controls.Add(this.contentPanel);
            this.containerPanel.Controls.Add(this.ribbonPanel);
            this.containerPanel.Controls.Add(this.statusBarPanel);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1207, 554);
            this.containerPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 554);
            this.Controls.Add(this.containerPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XMLDataSet)).EndInit();
            this.statusBarPanel.ResumeLayout(false);
            this.statusBarPanel.PerformLayout();
            this.ribbonPanel.ResumeLayout(false);
            this.ribbonPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet XMLDataSet;
        private System.Windows.Forms.Panel statusBarPanel;
        private System.Windows.Forms.Button xmlFileBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Panel ribbonPanel;
        private System.Windows.Forms.Button viewDetailsButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.TextBox detailsTextBox;
    }
}

