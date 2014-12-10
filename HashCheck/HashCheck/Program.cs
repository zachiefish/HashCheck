using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace HashCheck
{
    public class HashFile
    {
        private string fileName;
        private Hash[] hashes;

        public HashFile()
        {
            fileName = "";
            hashes = new Hash[Enum.GetNames(typeof(HashCheck.hashAlgorithm)).Length];
        }
        public string getFileName()
        {
            return fileName;
        }
        public void setFileName(string fileName)
        {
            this.fileName = fileName;
        }
        public void setHashes(Hash[] hashes)
        {
            for (int i = 0; i < hashes.Length; i++)
            {
                this.hashes[i].hashString = hashes[i].hashString;
                this.hashes[i].bytes = hashes[i].bytes;
            }
        }
        public Hash[] getHashes()
        {
            return hashes;
        }
    }
    public class Hash
    {
        public Hash(string hashString, byte[] bytes)
        {
            this.bytes = bytes;
            this.hashString = hashString;
        }
        public string hashString;
        public byte[] bytes;
    }
    public class HashCheck
    {
        public enum hashAlgorithm { MD5, SHA256 }
        public static HashFile[] filesToCheck;
        private static string[] filePaths;

        public static bool run;

        [STAThreadAttribute]
        public static void Main(String[] args)
        {
            run = true;
            Interface i = new Interface();
            i.ShowDialog();

            if (args.Length > 0)
                filePaths = args;

        }
        public static string byteToString(byte[] array)
        {
            string s = "";

            for (int i = 0; i < array.Length; i++)
            {
                s = s + String.Format("{0:X2}", array[i]);
            }

            return s;
        }
        public static void selectFiles()
        {
            filePaths = getFiles();
        }

        public static void computeHash(hashAlgorithm algorithmStyle)
        {
            if (filePaths.Length > 0)
            {
                filesToCheck = new HashFile[filePaths.Length];

                int i = 0;
                foreach (String s in filePaths)
                {
                    HashFile newFile = new HashFile();

                    FileInfo file = new FileInfo(s);
                    newFile.setFileName(file.Name);

                    FileStream fileStream = file.Open(FileMode.Open);
                    fileStream.Position = 0;

                    HashAlgorithm algorithm;

                    if (algorithmStyle == hashAlgorithm.SHA256)
                    {
                        algorithm = SHA256Managed.Create();
                    }
                    else if (algorithmStyle == hashAlgorithm.MD5)
                    {
                        algorithm = MD5.Create();
                    }
                    else // MD5 is most common
                    {
                        algorithm = MD5.Create();
                    }

                    Hash hash = new Hash(byteToString(algorithm.ComputeHash(fileStream)),algorithm.ComputeHash(fileStream));
                    fileStream.Close();

                    filesToCheck[i] = newFile;
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
