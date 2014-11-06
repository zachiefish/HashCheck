using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace HashCheck
{
    public class HashCheck
    {
        public struct file
        {
            public string fileName;
            public hash[] hashes;
        }
        public struct hash
        {
            public string hashString;
            public byte[] bytes;
        }
        public enum encryption { MD5, SHA256 }
        private static int ENC_COUNT = 2;
        public static file[] hashCollection;
        private static string[] files;

        public static bool run;

        [STAThreadAttribute]
        public static void Main(String[] args)
        {
            run = true;
            Interface i = new Interface();
            i.ShowDialog();

            if (args.Length > 0)
                files = args;

        }
        public static string byteToString(byte[] array)
        {
            string s = "";

            for (int i = 0; i < array.Length; i++)
            {
                s += String.Format("{0:X2}", array[i]);
            }

            return s;
        }
        public static void selectFiles()
        {
            files = getFiles();
        }
        public static void computeHash()
        {
            if (files.Length > 0)
            {
                hashCollection = new file[files.Length];

                int i = 0;
                foreach (String s in files)
                {
                    file newFile = new file();

                    FileInfo file = new FileInfo(s);
                    newFile.fileName = file.Name;

                    FileStream fileStream = file.Open(FileMode.Open);
                    fileStream.Position = 0;

                    // Compute the hash of the fileStream.
                    newFile.hashes = new hash[ENC_COUNT]; // only two modes of encryption

                    newFile.hashes[(int)encryption.SHA256] = new hash();
                    SHA256 sha256 = SHA256Managed.Create();
                    newFile.hashes[(int)encryption.SHA256].bytes = sha256.ComputeHash(fileStream);
                    newFile.hashes[(int)encryption.SHA256].hashString = byteToString(newFile.hashes[(int)encryption.SHA256].bytes);

                    newFile.hashes[(int)encryption.MD5] = new hash();
                    MD5 md5 = MD5.Create();
                    newFile.hashes[(int)encryption.MD5].bytes = md5.ComputeHash(fileStream);
                    newFile.hashes[(int)encryption.MD5].hashString = byteToString(newFile.hashes[(int)encryption.MD5].bytes);

                    hashCollection[i] = newFile;

                    fileStream.Close();
                    i++;
                }
            }
            return;
        }
        private static string[] getFiles()
        {
            FileDialog fd = new OpenFileDialog();
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
                return fd.FileNames;
            else
                return getFiles();            
        }
    }
}
