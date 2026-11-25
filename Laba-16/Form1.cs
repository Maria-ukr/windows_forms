using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Laba_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
        }

        Bitmap bmp_for_draw;
        string title_img;
        bool _isEditMode = false;
        bool _isDrawing = false;
        Point _startPoint;
        Pen pen1;
        int count = 1;

        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    title_img = openFile.FileName;
                    bmp_for_draw?.Dispose();
                    using (var temp = new Bitmap(title_img))
                    {
                        bmp_for_draw = new Bitmap(temp);
                    }
                    _isEditMode = false;
                    _isDrawing = false;
                    this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = bmp_for_draw;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult result = MessageBox.Show("It's impossible to open selected file");
                }
            }
        }

        private Point ToBmpPoint(Point p)
        {
            float scale = Math.Min(
                (float)pictureBox1.ClientSize.Width / bmp_for_draw.Width,
                (float)pictureBox1.ClientSize.Height / bmp_for_draw.Height);

            float offsetX = (pictureBox1.ClientSize.Width - bmp_for_draw.Width * scale) / 2f;
            float offsetY = (pictureBox1.ClientSize.Height - bmp_for_draw.Height * scale) / 2f;

            int x = (int)((p.X - offsetX) / scale);
            int y = (int)((p.Y - offsetY) / scale);
            return new Point(x, y);
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _isEditMode && bmp_for_draw != null && pen1 != null)
            {
                Point pt = ToBmpPoint(e.Location);
                if (pt.X >= 0 && pt.X < bmp_for_draw.Width && pt.Y >= 0 && pt.Y < bmp_for_draw.Height)
                {
                    _isDrawing = true;
                    _startPoint = pt;
                }
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDrawing = false;
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing && e.Button == MouseButtons.Left && _isEditMode && bmp_for_draw != null && pen1 != null)
            {
                Point pt = ToBmpPoint(e.Location);
                if (pt.X >= 0 && pt.X < bmp_for_draw.Width && pt.Y >= 0 && pt.Y < bmp_for_draw.Height)
                {
                    using (Graphics g = Graphics.FromImage(bmp_for_draw))
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.DrawLine(pen1, _startPoint, pt);
                    }

                    _startPoint = pt;
                    pictureBox1.Invalidate();
                }
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && bmp_for_draw != null)
            {
                pen1?.Dispose();
                pen1 = new Pen(Color.DarkGreen, 3);
                _isEditMode = true;
                _isDrawing = true;
                pictureBox1.Invalidate();
            }
            else
            {
                MessageBox.Show("Open image first!");
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || bmp_for_draw == null)
            {
                MessageBox.Show("No image to remove.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult result = MessageBox.Show("Are you sure you want remove the image ?", "Confirm deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                _isDrawing = false;
                _isEditMode = false;
                pen1?.Dispose();
                pen1 = null;

                if (ReferenceEquals(pictureBox1.Image, bmp_for_draw))
                {
                    bmp_for_draw.Dispose();
                    pictureBox1.Image = null;
                    bmp_for_draw = null;
                }
                else
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                    bmp_for_draw?.Dispose();
                    bmp_for_draw = null;
                }

                title_img = null;
                pictureBox1.Invalidate();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && bmp_for_draw != null)
            {
                string name = Path.GetFileNameWithoutExtension(title_img);
                string ext = Path.GetExtension(title_img);
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Title = "Save as ..";
                saveDialog.FileName = name + count + ext;
                saveDialog.OverwritePrompt = true;
                saveDialog.ShowHelp = true;
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bmp_for_draw.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        count++;
                    }
                    catch
                    {
                        MessageBox.Show("It's impossible to save image", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
