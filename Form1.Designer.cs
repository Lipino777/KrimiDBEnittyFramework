namespace KrimiDBEnittyFramework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            crimeID = new DataGridViewTextBoxColumn();
            crimeAlias = new DataGridViewTextBoxColumn();
            crimeVictimID = new DataGridViewTextBoxColumn();
            crimeDescript = new DataGridViewTextBoxColumn();
            crimeInvestigID = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            investigationID = new DataGridViewTextBoxColumn();
            investigationSuspectID = new DataGridViewTextBoxColumn();
            investigationLeadID = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            tabPage4 = new TabPage();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            leadID = new DataGridViewTextBoxColumn();
            leadAddress = new DataGridViewTextBoxColumn();
            leadDescription = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { crimeID, crimeAlias, crimeVictimID, crimeDescript, crimeInvestigID });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(1965, 1104);
            dataGridView1.TabIndex = 0;
            // 
            // crimeID
            // 
            crimeID.HeaderText = "crimeID";
            crimeID.MinimumWidth = 9;
            crimeID.Name = "crimeID";
            crimeID.Width = 175;
            // 
            // crimeAlias
            // 
            crimeAlias.HeaderText = "crimeAlias";
            crimeAlias.MinimumWidth = 9;
            crimeAlias.Name = "crimeAlias";
            crimeAlias.Width = 175;
            // 
            // crimeVictimID
            // 
            crimeVictimID.HeaderText = "crimeVIctimID";
            crimeVictimID.MinimumWidth = 9;
            crimeVictimID.Name = "crimeVictimID";
            crimeVictimID.Width = 175;
            // 
            // crimeDescript
            // 
            crimeDescript.HeaderText = "crimeDescript";
            crimeDescript.MinimumWidth = 9;
            crimeDescript.Name = "crimeDescript";
            crimeDescript.Width = 175;
            // 
            // crimeInvestigID
            // 
            crimeInvestigID.HeaderText = "crimeInvestigID";
            crimeInvestigID.MinimumWidth = 9;
            crimeInvestigID.Name = "crimeInvestigID";
            crimeInvestigID.Width = 175;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1979, 1153);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1971, 1110);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Crime";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1971, 1110);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Investigation";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { investigationID, investigationSuspectID, investigationLeadID });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.Size = new Size(1965, 1104);
            dataGridView2.TabIndex = 1;
            // 
            // investigationID
            // 
            investigationID.HeaderText = "investigationID";
            investigationID.MinimumWidth = 9;
            investigationID.Name = "investigationID";
            investigationID.Width = 175;
            // 
            // investigationSuspectID
            // 
            investigationSuspectID.HeaderText = "investigationSuspectID";
            investigationSuspectID.MinimumWidth = 9;
            investigationSuspectID.Name = "investigationSuspectID";
            investigationSuspectID.Width = 175;
            // 
            // investigationLeadID
            // 
            investigationLeadID.HeaderText = "investigationLeadID";
            investigationLeadID.MinimumWidth = 9;
            investigationLeadID.Name = "investigationLeadID";
            investigationLeadID.Width = 175;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1971, 1110);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Lead";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { leadID, leadAddress, leadDescription });
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(3, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 72;
            dataGridView3.Size = new Size(1965, 1104);
            dataGridView3.TabIndex = 1;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.ImeMode = ImeMode.NoControl;
            tabPage4.Location = new Point(4, 39);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1971, 1110);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "People";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += tabPage4_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15 });
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(3, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 72;
            dataGridView4.Size = new Size(1965, 1104);
            dataGridView4.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "crimeID";
            dataGridViewTextBoxColumn11.MinimumWidth = 9;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Width = 175;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "crimeAlias";
            dataGridViewTextBoxColumn12.MinimumWidth = 9;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Width = 175;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "crimeVIctimID";
            dataGridViewTextBoxColumn13.MinimumWidth = 9;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.Width = 175;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "crimeDescript";
            dataGridViewTextBoxColumn14.MinimumWidth = 9;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.Width = 175;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "crimeInvestigID";
            dataGridViewTextBoxColumn15.MinimumWidth = 9;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.Width = 175;
            // 
            // leadID
            // 
            leadID.HeaderText = "leadID";
            leadID.MinimumWidth = 9;
            leadID.Name = "leadID";
            leadID.Width = 175;
            // 
            // leadAddress
            // 
            leadAddress.HeaderText = "leadAddress";
            leadAddress.MinimumWidth = 9;
            leadAddress.Name = "leadAddress";
            leadAddress.Width = 175;
            // 
            // leadDescription
            // 
            leadDescription.HeaderText = "leadDescription";
            leadDescription.MinimumWidth = 9;
            leadDescription.Name = "leadDescription";
            leadDescription.Width = 175;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1979, 1153);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridViewTextBoxColumn crimeID;
        private DataGridViewTextBoxColumn crimeAlias;
        private DataGridViewTextBoxColumn crimeVictimID;
        private DataGridViewTextBoxColumn crimeDescript;
        private DataGridViewTextBoxColumn crimeInvestigID;
        private DataGridView dataGridView2;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private TabPage tabPage4;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn investigationID;
        private DataGridViewTextBoxColumn investigationSuspectID;
        private DataGridViewTextBoxColumn investigationLeadID;
        private DataGridViewTextBoxColumn leadID;
        private DataGridViewTextBoxColumn leadAddress;
        private DataGridViewTextBoxColumn leadDescription;
    }
}
