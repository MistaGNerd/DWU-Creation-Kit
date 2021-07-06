using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using DWCreationKit.DWTheme;
using System.IO;
using System.Threading;

namespace DWCreationKit
{
    public partial class DWCreationKit : Form
    {
        ThemeObjectBrowser tob = new ThemeObjectBrowser();
        public static Point WindowLocation;
        public static Size WindowSize;
        internal Theme theme = new Theme();
        string tempDirectoryPath = @"C:\dwck\temp";
        public DWCreationKit()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            while(toolStripProgressBar1.Value != 100)
            {
                Thread.Sleep(1000);
                toolStripProgressBar1.Value++;
            }
        }

        private void updateGUI()
        {           
            
        }

        private void DWCreationKit_Move(object sender, EventArgs e)
        {
            updateGUI();
        }

        private void DWCreationKit_Load(object sender, EventArgs e)
        {
            tob.Show(this);
            updateGUI();
        }

        private void DWCreationKit_Resize(object sender, EventArgs e)
        {
            updateGUI();
        }

        private async void importZipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string extractPath = tempDirectoryPath + @"\import\" + Path.GetFileNameWithoutExtension(ofd.FileName) + @"\";
                toolStripStatusLabel2.Text = "Extracting Zip!";
                await ExtractZipAsync(ofd.FileName, extractPath);
                toolStripProgressBar1.Value = 25;
                toolStripStatusLabel2.Text = "Loading Data";
                LoadModData(tempDirectoryPath + @"\import\");
            }
        }

        private void LoadModData(string p)
        {
            DirectoryInfo di = new DirectoryInfo(p);
            
            List<string> df = Directory.GetEverything();
            
        }

        private static List<string> GetEverything(this Directory)
        {
            List<string> v = new List<string>();
            return v;
        }

        private async Task ExtractZipAsync(string zipPath, string extractPath)
        {
            await Task.Run(() => ZipFile.ExtractToDirectory(zipPath, extractPath));

            /*
            // TODO: Add MGNLib functions for zipping iterating through files in ZipArchive with Progress info.

            // Normalizes the path.
            extractPath = Path.GetFullPath(extractPath);

            // Ensures that the last character on the extraction path
            // is the directory separator char.
            // Without this, a malicious zip file could try to traverse outside of the expected
            // extraction path.
            if (!extractPath.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal))
                extractPath += Path.DirectorySeparatorChar;
            using (ZipArchive archive = ZipFile.OpenRead(zipPath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        // Gets the full path to ensure that relative segments are removed.
                        string destinationPath = Path.GetFullPath(Path.Combine(extractPath, entry.FullName));

                        // Ordinal match is safest, case-sensitive volumes can be mounted within volumes that
                        // are case-insensitive.
                        if (destinationPath.StartsWith(extractPath, StringComparison.Ordinal))
                            entry.ExtractToFile(destinationPath);
                    }
                }
            }
            */



            MessageBox.Show("ZIP file extracted successfully!");
        }
    }
}
