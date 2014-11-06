using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashCheck
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HashCheck.selectFiles();
            HashCheck.computeHash();

            foreach(HashCheck.file f in HashCheck.hashCollection)
            {
                lblFileName.Text = f.fileName;
                lblSHA256.Text = f.hashes[(int)HashCheck.encryption.SHA256].hashString;
                lblMD5.Text = f.hashes[(int)HashCheck.encryption.MD5].hashString;
            }
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }
    }
}
