using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatcherHashGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileReader_Click(object sender, EventArgs e)
        {
            System.IO.Stream M2PatcherDialogStream;
            OpenFileDialog thisDialog = new OpenFileDialog();

            var md5 = MD5.Create();
            string getFilename, getMD5Hash, path = thisDialog.InitialDirectory, getPathOfFiles = filePath.Text;

            thisDialog.InitialDirectory = "c:\\";
            thisDialog.Filter = "All files (*.*)|*.*";
            thisDialog.FilterIndex = 2;
            thisDialog.RestoreDirectory = true;
            thisDialog.Multiselect = true;
            thisDialog.Title = "Válaszd ki a fájlokat!";


            if (thisDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in thisDialog.FileNames)
                {
                    try
                    {
                        using (M2PatcherDialogStream = File.OpenRead(file))
                        {
                            string fileName = file;
                            getFilename = Path.GetFileName(fileName);
                            FileInfo getFileSizeInByte = new FileInfo(fileName);
                            getMD5Hash = (BitConverter.ToString(md5.ComputeHash(M2PatcherDialogStream)).Replace("-", string.Empty)).ToString();
                            fileNamesHashSize.Items.Add(getPathOfFiles + "" + getFilename + " " + getMD5Hash + " " + getFileSizeInByte.Length);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba történt a fájlok beolvasása során: " + ex.Message);
                    }
                }
                Clipboard.SetText(string.Join(Environment.NewLine, fileNamesHashSize.Items.OfType<string>()));
            }
        }

        private void clearItems_Click(object sender, EventArgs e)
        {
            fileNamesHashSize.Items.Clear();
            Clipboard.Clear();
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            fileNamesHashSize.Items.Clear();
            Clipboard.Clear();
            System.Windows.Forms.Application.Exit();
        }
    }
}
