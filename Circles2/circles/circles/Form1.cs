using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace circles
{
    public partial class Circles : Form
    {
        public Bitmap Bmp;
        public double CanvasWidth;
        public double CanvasHeight;
        public double CanvasScale;



        public Circles()
        {
            InitializeComponent();

            numericUpDownWidth.Value = 600;
            numericUpDownHeight.Value = 400;
            numericUpDownIncrement.Value = 1;
            numericUpDownInterval.Value = 20;
            numericUpDownRadius.Value = 2;
            numericUpDownScale.Value = 100;
            Recalcuate();

        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            Recalcuate();
            panelDrawBox.Invalidate();
        }

        private void Recalcuate()
        {
            CanvasWidth = (double) numericUpDownWidth.Value;
            CanvasHeight = (double) numericUpDownHeight.Value;
            CanvasScale = (double) numericUpDownScale.Value;
            panelDrawBox.Width = (int) (CanvasWidth * CanvasScale / 100);
            panelDrawBox.Height = (int) (CanvasHeight * CanvasScale / 100);
        }

        private void panelDrawBox_Paint(object sender, PaintEventArgs e)
        {
            Bmp = new Bitmap((int)CanvasWidth, (int)CanvasHeight);
            double up = 0;
            double left = 0;
            var down = CanvasHeight;
            var right = CanvasWidth;
            var radius = (double)numericUpDownRadius.Value;
            var interval = (double) numericUpDownInterval.Value;
            var increment = (double) numericUpDownIncrement.Value;
            var width = CanvasWidth;
            var height = CanvasHeight;

            using (var g = Graphics.FromImage(Bmp))
            {
                
                g.Clear(Color.Transparent);
                if (interval == 0)
                    return;

                var circlesX = Math.Floor(width / interval);
                var circlesY = Math.Floor(height / interval);

                if (circlesX == 0 || circlesY == 0)
                    return;

                var trueIntervalX = width / circlesX;
                var trueIntervalY = height / circlesY;

                for(;;)
                {
                    up += trueIntervalY;
                    down -= trueIntervalY;
                    left += trueIntervalX;
                    right -= trueIntervalX;

                    width = right - left;
                    height = down - up;

                    // если центральные кружочки не помещаются, рисуем их ровно по центру с перекрытием
                    if (width < 0)
                    {
                        if(-width > radius)
                            break;

                        left = (left + right) / 2;
                        right = (left + right) / 2;
                        

                    }

                    if (height < 0)
                    {
                        if (-height > radius)
                            break;
                        
                        

                        up = (up + down) / 2 - 1;
                        down = (up + down) / 2 + 1;

                    }

                    var diameter = radius*2;


                    for (var i = left; i <= right+1; i += trueIntervalX)
                    {
                        g.FillEllipse(Brushes.White, (int) (i - radius), (int) (up - radius), (int) diameter,
                            (int) diameter);
                        g.FillEllipse(Brushes.White, (int) (i - radius), (int) (down - radius), (int) diameter,
                            (int) diameter);
                    }

                    for (var j = up; j <= down+1 ; j += trueIntervalY)
                    {
                        g.FillEllipse(Brushes.White, (int) (left - radius), (int) (j - radius), (int) diameter,
                            (int) diameter);
                        g.FillEllipse(Brushes.White, (int) (right - radius), (int) (j - radius), (int) diameter,
                            (int) diameter);
                    }

                    if (radius + increment < right && radius + increment > 0)
                        // круг не должен быть на весь экран или минусового размера
                        radius += increment;
                } 

            }
            var s = (int) numericUpDownScale.Value;
            var destRect = new Rectangle(0, 0, (int)(CanvasWidth * s / 100), (int)(CanvasHeight * s/100));
            var imgRect = new Rectangle(0, 0, (int)CanvasWidth, (int)CanvasHeight);
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.DrawImage(Bmp, destRect,imgRect, GraphicsUnit.Pixel);
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            panelDrawBox.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog {Filter = "Файл PNG|*.png"};
            var format = ImageFormat.Png;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bmp.Save(sfd.FileName, format);
            }
            
        }
    }
}
