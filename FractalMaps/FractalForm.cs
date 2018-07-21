using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fractal;
namespace FractalMaps
{
    public partial class FractalForm : Form
    {
        public FractalForm()
        {
            InitializeComponent();
            minScaleBox.Text = (3).ToString();
            smallScaleBox.Text = (30).ToString();
            largeScaleBox.Text = (150).ToString();
            button1_Click(null, null);
        }
        public void setImage(Image im){
            ImageBox.Image = im;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 256;
            int w = 11;
            int h = 4;
            if (smallScaleBox.Text.Length == 0 || largeScaleBox.Text.Length == 0) return;
            FractalOptions options = new FractalOptions(parseInt(smallScaleBox), parseInt(largeScaleBox), parseInt(minScaleBox));
            Bitmap image = new Bitmap(w * n + 1, h * n + 1);
            WrappingFractal.Initialize(parseInt(seedBox));
            float[,] map = WrappingFractal.fractal(n, h, w, options, FractalWrapMode.Horizontal);
            if(shaveBox.Checked)WrappingFractal.shaveEdges(ref map);
            float ocean = oceanBar.Value;
            var levels = FractalUtility.getCutOffLevels(map, new float[] { ocean, oceanBar.Maximum-ocean });
            BitmapData data=image.LockBits(new Rectangle(0, 0, map.GetLength(0), map.GetLength(1)), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            
            int[] bitmapColors=new int[map.GetLength(0)*map.GetLength(1)];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {

                    //Random r = new Random(seed);
                    Color c;
                    if (map[i, j] < levels[0])
                    {
                        c = Color.Blue;
                    }
                    else
                    {
                        c = Color.Green;
                    }
                    
                    int x = i;
                    if (i < map.GetLength(0) / 2) x += map.GetLength(0) / 2;
                    else x -= map.GetLength(0) / 2;
                    int y = j;
                    //if (j < map.GetLength(1) / 2) y += map.GetLength(1) / 2;
                    //else y -= map.GetLength(1) / 2;

                    bitmapColors[i + j * map.GetLength(0)] = c.ToArgb();
                    //image.SetPixel(i, j, c);
                }
            }
            System.Runtime.InteropServices.Marshal.Copy(bitmapColors, 0, data.Scan0, map.GetLength(0) * map.GetLength(1));
            image.UnlockBits(data);
            image.Save("fractal.bmp");
            setImage(image);
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            var r = new Random();
            seedBox.Text = (r.Next(10000000) + 1000000).ToString();
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private int parseInt(TextBox box)
        {
            return int.Parse(box.Text);
        }

        private void minScaleBox_TextChanged(object sender, EventArgs e)
        {
            ensureNumeric(minScaleBox);
        }
        private void largeScaleBox_TextChanged(object sender, EventArgs e)
        {
            ensureNumeric(largeScaleBox);
        }

        private void smallScaleBox_TextChanged(object sender, EventArgs e)
        {
            ensureNumeric(smallScaleBox);
        }
        private void seedBox_TextChanged(object sender, EventArgs e)
        {
            ensureNumeric(seedBox);
        }
        private void ensureNumeric(TextBox box)
        {
            long a;
            if (!long.TryParse(box.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                box.Clear();
            }
        }
    }
}
