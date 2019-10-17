using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HappyNewYears
{
    public partial class MainForm : Form
    {
        public int counter = 1;
        public List<Bitmap> collection;
        public MainForm()
        {
            InitializeComponent();
            collection = GetNextImage();
            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
                      

            if (counter > collection.Count-1)
            counter = 0;
            pictureBox1.Image = collection[counter];
            counter++;
        }

     

        public List<Bitmap> GetNextImage()
        {
           
            Bitmap image1 = Properties.Resources.christmas_card_valdcon_grup4;
            Bitmap image2 = Properties.Resources.christmas_card_valdcon_grup8;
            Bitmap image3 = Properties.Resources.christmas_card_valdcon_grup12;
            List<Bitmap> ImageList = new List<Bitmap>() { image1, image2, image3 };
            return ImageList;
        }

        private void cLOSE(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadMainForm(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.new_york_new_york_v2__online_audio_converter_com_;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.PlayLooping();

        }
    }
}
