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
            hashes = new Hash[Enum.GetNames(typeof(Hash.hashAlgorithm)).Length];
            for (int i = 0; i < Enum.GetNames(typeof(Hash.hashAlgorithm)).Length; i++ )
            {
                hashes[i] = new Hash("",new byte[1]);
            }
        }
        public string getFileName()
        {
            return fileName;
        }
        public void setFileName(string fileName)
        {
            this.fileName = fileName;
        }
        public void setHash(Hash hash,Hash.hashAlgorithm algorithm)
        {
            this.hashes[(int)algorithm].hashString = hash.hashString;
            this.hashes[(int)algorithm].bytes = hash.bytes;
        }
        public Hash[] getHashes()
        {
            return hashes;
        }
    }
    public class Hash
    {
        public enum hashAlgorithm { MD5, SHA256, SHA512 }

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
            filesToCheck = new HashFile[filePaths.Length];
            if (filePaths.Length > 0)
            {
                for (int i = 0; i < filePaths.Length; i++)
                {
                    HashFile newFile = new HashFile();
                    FileInfo file = new FileInfo(filePaths[i]);
                    newFile.setFileName(file.FullName);
                    filesToCheck[i] = newFile;
                }
            }
        }

        public static void computeHash(Hash.hashAlgorithm algorithmStyle, HashFile hashFile)
        {
                filesToCheck = new HashFile[filePaths.Length];

                FileInfo file = new FileInfo(hashFile.getFileName());
                FileStream fileStream = file.Open(FileMode.Open);
                fileStream.Position = 0;

                HashAlgorithm algorithm;
                if (algorithmStyle == Hash.hashAlgorithm.SHA512)
                {
                    algorithm = SHA512.Create();
                }
                else if (algorithmStyle == Hash.hashAlgorithm.SHA256)
                {
                    algorithm = SHA256.Create();
                }
                else if (algorithmStyle == Hash.hashAlgorithm.MD5)
                {
                    algorithm = MD5.Create();
                }
                else // MD5 is most common
                {
                    algorithm = MD5.Create();
                }

                Hash hash = new Hash(byteToString(algorithm.ComputeHash(fileStream)),algorithm.ComputeHash(fileStream));
                fileStream.Close();

                hashFile.setHash(hash, algorithmStyle);
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
