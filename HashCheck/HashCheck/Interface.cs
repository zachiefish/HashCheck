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
        private Boolean sha256Checked = true;
        private Boolean md5Checked = true;

        public Interface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HashCheck.selectFiles();

            if(md5Checked)
                HashCheck.computeHash(HashCheck.hashAlgorithm.MD5);

            if (sha256Checked)
                HashCheck.computeHash(HashCheck.hashAlgorithm.SHA256);

            if (HashCheck.filesToCheck != null)
            {
                foreach (HashFile f in HashCheck.filesToCheck)
                {
                    lblFileName.Text = f.getFileName();

                    if (sha256Checked)
                        lblSHA256.Text = f.getHashes()[(int)HashCheck.hashAlgorithm.SHA256].hashString;

                    if (md5Checked)
                        lblMD5.Text = f.getHashes()[(int)HashCheck.hashAlgorithm.MD5].hashString;
                }
            }
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void chkSHA256_CheckedChanged(object sender, EventArgs e)
        {
            sha256Checked = chkSHA256.Checked;
        }

        private void chkMD5_CheckedChanged(object sender, EventArgs e)
        {
            md5Checked = chkMD5.Checked;
        }
        public bool getSHA256Checked()
        {
            return sha256Checked;
        }
        public bool getMD5Checked()
        {
            return md5Checked;
        }
    }
}
