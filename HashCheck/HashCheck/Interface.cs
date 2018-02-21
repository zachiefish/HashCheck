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
        private Boolean sha512Checked = true;
        private Boolean md5Checked = true;

        public Interface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HashCheck.selectFiles();

            foreach (HashFile h in HashCheck.filesToCheck)
            {
                lblFileName.Text = h.getFileName();
                if (sha512Checked)
                    HashCheck.computeHash(Hash.hashAlgorithm.SHA512, h);
                    lblSHA512.Text = h.getHashes()[(int)Hash.hashAlgorithm.SHA512].hashString;

                if (sha256Checked)
                    HashCheck.computeHash(Hash.hashAlgorithm.SHA256, h);
                    lblSHA256.Text = h.getHashes()[(int)Hash.hashAlgorithm.SHA256].hashString;

                if (md5Checked)
                    HashCheck.computeHash(Hash.hashAlgorithm.MD5, h);
                    lblMD5.Text = h.getHashes()[(int)Hash.hashAlgorithm.MD5].hashString;
            }
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void chkSHA256_CheckedChanged(object sender, EventArgs e)
        {
            sha256Checked = chkSHA256.Checked;
        }
        private void chkSHA512_CheckedChanged(object sender, EventArgs e)
        {
            sha512Checked = chkSHA512.Checked;
        }
        private void chkMD5_CheckedChanged(object sender, EventArgs e)
        {
            md5Checked = chkMD5.Checked;
        }
        public bool getSHA512Checked()
        {
            return sha512Checked;
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
