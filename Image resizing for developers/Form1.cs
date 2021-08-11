using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_resizing_for_developers
{
    public partial class Form1 : Form
    {

        int nufindimg = 0;
        int unfindflodersave = 0;
        String pathimage = null;
        String pathfoldersave = null;
        String nameimg = null;
        String TypeImg = null;
        int imageHeight;
        int imageWidth;

        ArrayList typeSizeAndroid = new ArrayList();
        List<int> sizeImgAndroidW = new List<int>();
        List<int> sizeImgAndroidH = new List<int>();

        public Form1()
        {
            InitializeComponent();
            
            typeSizeAndroid.Add("drawable-ldpi");
            typeSizeAndroid.Add("drawable-mdpi");
            typeSizeAndroid.Add("drawable-hdpi");
            typeSizeAndroid.Add("drawable-xhdpi");
            typeSizeAndroid.Add("drawable-xxhdpi");
            typeSizeAndroid.Add("drawable-xxxhdpi");
            // Add in sizeImgAndroidW
            sizeImgAndroidW.Add(198);
            sizeImgAndroidW.Add(320);
            sizeImgAndroidW.Add(298);
            sizeImgAndroidW.Add(398);
            sizeImgAndroidW.Add(597);
            sizeImgAndroidW.Add(796);

            //Add in sizeImgAndroidW 
            sizeImgAndroidH.Add(200);
            sizeImgAndroidH.Add(480);
            sizeImgAndroidH.Add(301);
            sizeImgAndroidH.Add(401);
            sizeImgAndroidH.Add(602);
            sizeImgAndroidH.Add(803);

            TextReader textReader = File.OpenText("date.txt");
            pathfoldersave = textReader.ReadLine();
            if(string.IsNullOrEmpty(pathfoldersave))
            {
               
            }
            else
            {
                Showfoldersave.Text = pathfoldersave;              
                unfindflodersave = 1;
            }
            textReader.Close();

            comboBoxType.SelectedIndex = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                nufindimg = 1;
                pathimage = open.FileName;
                nameimg = open.SafeFileName;
                TypeImg = Path.GetExtension(open.FileName);

                Bitmap img = new Bitmap(open.FileName);

                imageHeight = img.Height;
                imageWidth = img.Width;
                // display image in picture box  
                pictureBox1.Image = img;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nufindimg != 1)
            {

                string title = "Choose a picture";
                MessageBox.Show(title);
            }
            else if(unfindflodersave != 1)
            {

                string title = "Choose a folder to save the image to";
                MessageBox.Show(title);
            }
            else
            {
                int selectedIndex = comboBoxType.SelectedIndex;
                if (selectedIndex == 0)
                {
                    Convertphotos();
                }
                else if (selectedIndex == 1)
                {
                    int sizew = imageWidth / 6;
                    int sizeh = imageHeight / 6;

                    sizeImgAndroidH.Clear();
                    sizeImgAndroidW.Clear();

                    // Add in sizeImgAndroidW
                    sizeImgAndroidW.Add(sizew); 
                    sizeImgAndroidW.Add(sizew+sizew);
                    sizeImgAndroidW.Add(sizew+sizew+sizew);
                    sizeImgAndroidW.Add(sizew+sizew+sizew+sizew);
                    sizeImgAndroidW.Add(sizew+sizew+sizew+sizew+sizew);
                    sizeImgAndroidW.Add(sizew + sizew + sizew + sizew + sizew);
                    

                    //Add in sizeImgAndroidH
                    sizeImgAndroidH.Add(sizeh);
                    sizeImgAndroidH.Add(sizeh+sizeh);
                    sizeImgAndroidH.Add(sizeh+sizeh+sizeh);
                    sizeImgAndroidH.Add(sizeh+sizeh+sizeh+sizeh);
                    sizeImgAndroidH.Add(sizeh+sizeh+sizeh+sizeh+sizeh);
                    sizeImgAndroidH.Add(sizeh+sizeh+sizeh+sizeh+sizeh+sizeh);
                    Convertphotos();
                }
                else if (selectedIndex == 2)
                {
                    sizeImgAndroidH.Clear();
                    sizeImgAndroidW.Clear();
                    // Add in sizeImgAndroidW
                    sizeImgAndroidW.Add(100);
                    sizeImgAndroidW.Add(200);
                    sizeImgAndroidW.Add(400);
                    sizeImgAndroidW.Add(600);
                    sizeImgAndroidW.Add(800);
                    sizeImgAndroidW.Add(1000);

                    //Add in sizeImgAndroidW 
                    sizeImgAndroidH.Add(110);
                    sizeImgAndroidH.Add(210);
                    sizeImgAndroidH.Add(410);
                    sizeImgAndroidH.Add(610);
                    sizeImgAndroidH.Add(810);
                    sizeImgAndroidH.Add(1000);
                    Convertphotos();
                }
                else if (selectedIndex == 3)
                {
                    sizeImgAndroidH.Clear();
                    sizeImgAndroidW.Clear();
                    // Add in sizeImgAndroidW
                    sizeImgAndroidW.Add(200);
                    sizeImgAndroidW.Add(400);
                    sizeImgAndroidW.Add(600);
                    sizeImgAndroidW.Add(800);
                    sizeImgAndroidW.Add(1000);
                    sizeImgAndroidW.Add(1200);

                    //Add in sizeImgAndroidW 
                    sizeImgAndroidH.Add(100);
                    sizeImgAndroidH.Add(200);
                    sizeImgAndroidH.Add(300);
                    sizeImgAndroidH.Add(400);
                    sizeImgAndroidH.Add(500);
                    sizeImgAndroidH.Add(600);
                    Convertphotos();
                }
                else if (selectedIndex == 4)
                {
                    sizeImgAndroidH.Clear();
                    sizeImgAndroidW.Clear();

                    // Add in sizeImgAndroidW
                    sizeImgAndroidW.Add(100);
                    sizeImgAndroidW.Add(200);
                    sizeImgAndroidW.Add(300);
                    sizeImgAndroidW.Add(400);
                    sizeImgAndroidW.Add(500);
                    sizeImgAndroidW.Add(600);

                    //Add in sizeImgAndroidW 
                    sizeImgAndroidH.Add(200);
                    sizeImgAndroidH.Add(400);
                    sizeImgAndroidH.Add(600);
                    sizeImgAndroidH.Add(800);
                    sizeImgAndroidH.Add(1000);
                    sizeImgAndroidH.Add(1200);
                    Convertphotos();
                }
                else
                {
                    sizeImgAndroidH.Clear();
                    sizeImgAndroidW.Clear();

                    // Add in sizeImgAndroidW
                    sizeImgAndroidW.Add(198);
                    sizeImgAndroidW.Add(320);
                    sizeImgAndroidW.Add(298);
                    sizeImgAndroidW.Add(398);
                    sizeImgAndroidW.Add(597);
                    sizeImgAndroidW.Add(796);

                    //Add in sizeImgAndroidW 
                    sizeImgAndroidH.Add(200);
                    sizeImgAndroidH.Add(480);
                    sizeImgAndroidH.Add(301);
                    sizeImgAndroidH.Add(401);
                    sizeImgAndroidH.Add(602);
                    sizeImgAndroidH.Add(803);
                    Convertphotos();
                }

                
            }    
        }

        private void Convertphotos()
        {
            System.Drawing.Image picBottle = System.Drawing.Image.FromFile(pathimage);
            String pathdrawable = pathfoldersave+ "/drawable/";
            if (Directory.Exists(pathdrawable))
            {
                picBottle.Save(pathdrawable+"ic_"+nameimg);
            }
            else
            {
                Directory.CreateDirectory(pathdrawable);
                picBottle.Save(pathdrawable + "ic_" + nameimg);
            }

            for (int i = 0; i < typeSizeAndroid.Count; i++)
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(pathimage);
                String path = pathfoldersave + "/" + typeSizeAndroid[i] + "/";
                if (Directory.Exists(path))
                {
                    img = Resize(img, sizeImgAndroidW[i], sizeImgAndroidH[i]);
                    img.Save(path + "ic_" + nameimg);
                }
                else
                {
                    Directory.CreateDirectory(path);
                    img = Resize(img, sizeImgAndroidW[i], sizeImgAndroidH[i]);
                    img.Save(path + "ic_" + nameimg);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                unfindflodersave = 1;
                Showfoldersave.Text = folderBrowserDialog.SelectedPath;
                pathfoldersave = folderBrowserDialog.SelectedPath;


               TextWriter txt = new StreamWriter("date.txt");
               txt.Write(folderBrowserDialog.SelectedPath);
               txt.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxType.SelectedIndex;
            Object selectedItem = comboBoxType.SelectedItem;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //resize image 
        private Image Resize(Image img, int iWidth, int iHeight)
        {
            Bitmap bmp = new Bitmap(iWidth, iHeight);
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.DrawImage(img, 0, 0, iWidth, iHeight);

            return (Image)bmp;
        }
    }
}
