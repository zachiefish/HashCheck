namespace HashCheck
{
    partial class Interface
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hashTable = new System.Windows.Forms.TableLayoutPanel();
            this.chkMD5 = new System.Windows.Forms.CheckBox();
            this.chkSHA256 = new System.Windows.Forms.CheckBox();
            this.lblSHA256 = new System.Windows.Forms.Label();
            this.lblMD5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.hashTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.07583F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.92417F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 149);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(624, 58);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFileName);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(622, 52);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File";
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(99, 23);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(95, 13);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "SomeFileName.jpg";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hashTable);
            this.groupBox1.Location = new System.Drawing.Point(6, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(624, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hashes";
            // 
            // hashTable
            // 
            this.hashTable.ColumnCount = 2;
            this.hashTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.78317F));
            this.hashTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.21683F));
            this.hashTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.hashTable.Controls.Add(this.chkMD5, 0, 1);
            this.hashTable.Controls.Add(this.chkSHA256, 0, 0);
            this.hashTable.Controls.Add(this.lblSHA256, 1, 0);
            this.hashTable.Controls.Add(this.lblMD5, 1, 1);
            this.hashTable.Location = new System.Drawing.Point(2, 15);
            this.hashTable.Margin = new System.Windows.Forms.Padding(2);
            this.hashTable.Name = "hashTable";
            this.hashTable.RowCount = 2;
            this.hashTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hashTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hashTable.Size = new System.Drawing.Size(618, 49);
            this.hashTable.TabIndex = 0;
            // 
            // chkMD5
            // 
            this.chkMD5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMD5.AutoSize = true;
            this.chkMD5.Checked = true;
            this.chkMD5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMD5.Location = new System.Drawing.Point(3, 27);
            this.chkMD5.Name = "chkMD5";
            this.chkMD5.Size = new System.Drawing.Size(73, 19);
            this.chkMD5.TabIndex = 9;
            this.chkMD5.Text = "MD5";
            this.chkMD5.UseVisualStyleBackColor = true;
            this.chkMD5.CheckedChanged += new System.EventHandler(this.chkMD5_CheckedChanged);
            // 
            // chkSHA256
            // 
            this.chkSHA256.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSHA256.AutoSize = true;
            this.chkSHA256.Checked = true;
            this.chkSHA256.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSHA256.Location = new System.Drawing.Point(3, 3);
            this.chkSHA256.Name = "chkSHA256";
            this.chkSHA256.Size = new System.Drawing.Size(73, 18);
            this.chkSHA256.TabIndex = 8;
            this.chkSHA256.Text = "SHA256";
            this.chkSHA256.UseVisualStyleBackColor = true;
            this.chkSHA256.CheckedChanged += new System.EventHandler(this.chkSHA256_CheckedChanged);
            // 
            // lblSHA256
            // 
            this.lblSHA256.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSHA256.AutoSize = true;
            this.lblSHA256.Location = new System.Drawing.Point(81, 5);
            this.lblSHA256.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSHA256.Name = "lblSHA256";
            this.lblSHA256.Size = new System.Drawing.Size(49, 13);
            this.lblSHA256.TabIndex = 6;
            this.lblSHA256.Text = "<HASH>";
            // 
            // lblMD5
            // 
            this.lblMD5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMD5.AutoSize = true;
            this.lblMD5.Location = new System.Drawing.Point(81, 30);
            this.lblMD5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMD5.Name = "lblMD5";
            this.lblMD5.Size = new System.Drawing.Size(49, 13);
            this.lblMD5.TabIndex = 7;
            this.lblMD5.Text = "<HASH>";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 170);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Interface";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.hashTable.ResumeLayout(false);
            this.hashTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel hashTable;
        private System.Windows.Forms.Label lblSHA256;
        private System.Windows.Forms.Label lblMD5;
        private System.Windows.Forms.CheckBox chkMD5;
        private System.Windows.Forms.CheckBox chkSHA256;
    }
}