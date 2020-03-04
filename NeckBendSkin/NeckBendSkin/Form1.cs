using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NeckBendSkin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectPath1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "png files (*.png)|*.png";
            openFileDialog1.Title = "スキンの画像を選択してください";
            openFileDialog1.FileName = "skin.ping";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                String text = openFileDialog1.FileName;
                basePath.Text = text;
                if (text.Contains(".png") && createPath.Text == "")
                {
                    createPath.Text = text.Replace(".png", "_neck_bend.png");
                }
            }
        }

        private void SelectPath2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "png files (*.png)|*.png";
            openFileDialog1.Title = "スキンの保存先の画像を選択してください";
            openFileDialog1.FileName = "skin.ping";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                createPath.Text = openFileDialog1.FileName;
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            if (basePath.Text == "")
            {
                MessageBox.Show("元のスキンを選択してください");
                return;
            }

            if (!File.Exists(basePath.Text))
            {
                MessageBox.Show("元のスキンが見つかりませんでした");
                return;
            }

            if (createPath.Text == "")
            {
                MessageBox.Show("保存先を選択してください");
                return;
            }

            Bitmap read = new Bitmap(basePath.Text);
            Bitmap write = new Bitmap(basePath.Text);

            PutTop(read, write, true);
            PutTop(read, write, false);
            PutDown(read, write, true);
            PutDown(read, write, false);
            PutFront(read, write, true);
            PutFront(read, write, false);
            PutBack(read, write, true);
            PutBack(read, write, false);
            PutRight(read, write, true);
            PutRight(read, write, false);
            PutLeft(read, write, true);
            PutLeft(read, write, false);

            write.Save(createPath.Text);
            MessageBox.Show("処理が完了しました");

        }

        private void PutTop(Bitmap read, Bitmap write, Boolean outSide = false)
        {
            Bitmap cut = new Bitmap(8, 8);
            for (int y = 0; y < 8; ++y)
            {
                for (int x = 0; x < 8; ++x)
                {
                    cut.SetPixel(x, y, read.GetPixel(x + 16 + (outSide ? 32 : 0), y + 8));
                }
            }

            cut.RotateFlip(RotateFlipType.Rotate270FlipNone);

            for (int y = 0; y < 8; ++y)
            {
                for (int x = 0; x < 8; ++x)
                {
                    write.SetPixel(x + 8 + (outSide ? 32 : 0), y, cut.GetPixel(x, y));
                }
            }
        }

        private void PutDown(Bitmap read, Bitmap write, Boolean outSide = false)
        {
            Bitmap cut = new Bitmap(8, 8);
            for (int y = 0; y < 8; ++y)
            {
                for (int x = 0; x < 8; ++x)
                {
                    cut.SetPixel(x, y, read.GetPixel(x + (outSide ? 32 : 0), y + 8));
                }
            }

            cut.RotateFlip(RotateFlipType.Rotate90FlipNone);

            for (int y = 0; y < 8; ++y)
            {
                for (int x = 0; x < 8; ++x)
                {
                    write.SetPixel(x + 16 + (outSide ? 32 : 0), y, cut.GetPixel(7 - x, y));
                }
            }
        }

        private void PutFront(Bitmap read, Bitmap write, Boolean outSide = false)
        {
            Bitmap cut = new Bitmap(8, 8);
            for (int y = 0; y < 8; ++y)
            {
                for (int x = 0; x < 8; ++x)
                {
                    cut.SetPixel(x, y, read.GetPixel(x + 8 + (outSide ? 32 : 0), y + 8));
                }
            }

            cut.RotateFlip(RotateFlipType.Rotate270FlipNone);

            for (int y = 0; y < 8; ++y)
            {
                for (int x = 0; x < 8; ++x)
                {
                    write.SetPixel(x + 8 + (outSide ? 32 : 0), y + 8, cut.GetPixel(x, y));
                }
            }
        }

        private void PutBack(Bitmap read, Bitmap write, Boolean outSide = false)
        {
            Bitmap cut = new Bitmap(8, 8);
            for (int y = 0; y < 8; ++y)
            {
                for (int x = 0; x < 8; ++x)
                {
                    cut.SetPixel(x, y, read.GetPixel(x + 24 + (outSide ? 32 : 0), y + 8));
                }
            }

            cut.RotateFlip(RotateFlipType.Rotate90FlipNone);

            for (int y = 0; y < 8; ++y)
            {
                for (int x = 0; x < 8; ++x)
                {
                    write.SetPixel(x + 24 + (outSide ? 32 : 0), y + 8, cut.GetPixel(x, y));
                }
            }
        }

        private void PutRight(Bitmap read, Bitmap write, Boolean outSide = false)
        {
            Bitmap cut = new Bitmap(8, 8);
            for (int y = 0; y < 8; ++y)
            {
                for (int x = 0; x < 8; ++x)
                {
                    cut.SetPixel(x, y, read.GetPixel(x + 16 + (outSide ? 32 : 0), y));
                }
            }

            cut.RotateFlip(RotateFlipType.Rotate90FlipNone);

            for (int y = 0; y < 8; ++y)
            {
                for (int x = 0; x < 8; ++x)
                {
                    write.SetPixel(x + 16 + (outSide ? 32 : 0), y + 8, cut.GetPixel(x, 7 - y));
                }
            }
        }

        private void PutLeft(Bitmap read, Bitmap write, Boolean outSide = false)
        {
            Bitmap cut = new Bitmap(8, 8);
            for (int y = 0; y < 8; ++y)
            {
                for (int x = 0; x < 8; ++x)
                {
                    cut.SetPixel(x, y, read.GetPixel(x + 8 + (outSide ? 32 : 0), y));
                }
            }

            cut.RotateFlip(RotateFlipType.Rotate270FlipNone);

            for (int y = 0; y < 8; ++y)
            {
                for (int x = 0; x < 8; ++x)
                {
                    write.SetPixel(x + (outSide ? 32 : 0), y + 8, cut.GetPixel(x, y));
                }
            }
        }
    }
}
