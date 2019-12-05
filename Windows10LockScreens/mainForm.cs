using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10LockScreens
{
    public partial class mainForm : Form
    {
        //Wallpapers are stored in: 
        //"C:\Users\User\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets"
        string wallpapersPath;
        string selectedImagePath;


        public mainForm()
        {
            InitializeComponent();
            wallpapersPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).ToString();
            wallpapersPath += "\\AppData\\Local\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\Assets";
            if (Directory.Exists(wallpapersPath))
                Console.WriteLine("Forlder loaded");
            else
            {
                Console.WriteLine("Forlder can't be loaded");
                this.Close();
            }
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            ReloadImages();
        }


        private void filesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = filesList.SelectedItems[0].Text;
                selectedImagePath = wallpapersPath + "\\" + selectedItem;
                previewPictureBox.ImageLocation = selectedImagePath;
                saveBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(selectedImagePath))
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(selectedImagePath, saveFileDialog1.FileName);
                }
            }
        }

        private void filterBox_CheckedChanged(object sender, EventArgs e)
        {
            if(filterBox.Checked)
            {
                widthMinResolutionBox.Enabled = true;
                heightMinResolutionBox.Enabled = true;
                ReloadImages(Convert.ToInt32(widthMinResolutionBox.Value),Convert.ToInt32(heightMinResolutionBox.Value));
            }
            else
            {
                widthMinResolutionBox.Enabled = false;
                heightMinResolutionBox.Enabled = false;
                ReloadImages();
            }
        }


        private void heightMinResolutionBox_ValueChanged(object sender, EventArgs e)
        {
            ReloadImages(Convert.ToInt32(widthMinResolutionBox.Value), Convert.ToInt32(heightMinResolutionBox.Value));
        }

        private void widthMinResolutionBox_ValueChanged(object sender, EventArgs e)
        {
            ReloadImages(Convert.ToInt32(widthMinResolutionBox.Value), Convert.ToInt32(heightMinResolutionBox.Value));
        }


        void ReloadImages(int minW = -1, int minH = -1)
        {
            string fileName;
            string[] files;
            ListViewItem item;
            //Now i load files to the listView
            filesList.Items.Clear();
            files = Directory.GetFiles(wallpapersPath);
            foreach (string file in files)
            {
                if (minW > 0 && minH > 0) //Then i filter files with resolution
                {
                    var img = Image.FromFile(file);
                    if (img.Width >= minW && img.Height >= minH)
                    {
                        fileName = Path.GetFileNameWithoutExtension(file);
                        item = new ListViewItem(fileName);
                        item.Tag = file;
                        filesList.Items.Add(item);
                    }
                }
                else
                {
                    fileName = Path.GetFileNameWithoutExtension(file);
                    item = new ListViewItem(fileName);
                    item.Tag = file;
                    filesList.Items.Add(item);
                }
            }
        }
    }
}
