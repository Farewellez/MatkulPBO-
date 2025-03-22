using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Menggambar
{
    public partial class Form1: Form
    {
        private Graphics g;
        private Pen pen = new Pen(Color.Black, 2); // warna dan ketebalan
        private Dictionary<Button, Point> tombolAwal = new Dictionary<Button, Point>();
        private int shapeSize;
        private int shapeX, shapeY;
        private enum ShapeType { None, Persegi, Lingkaran, Segitiga, PersegiPanjang, JajarGenjang }
        private ShapeType currentShape = ShapeType.None;
        private int panel2_WidthAwal, panel2_HeightAwal;

        public Form1()
        {
            InitializeComponent();
            panel2_WidthAwal = panel2.Width;
            panel2_HeightAwal = panel2.Height;

            // Simpan posisi awal tombol
            tombolAwal[btnLingkaran] = btnLingkaran.Location;
            tombolAwal[btnSegitiga] = btnSegitiga.Location;
            tombolAwal[btnPersegi] = btnPersegi.Location;
            tombolAwal[btnPersegiPanjang] = btnPersegiPanjang.Location;
            tombolAwal[btnJajarGenjang] = btnJajarGenjang.Location;
            tombolAwal[btnClear] = btnClear.Location;

            this.Resize += new EventHandler(Form1_Resize);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int panelWidth = panel2.Width;
            int panelHeight = panel2.Height;

            // Hitung ukuran dan posisi bentuk agar selalu berada di tengah
            int shapeSize = Math.Min(panelWidth, panelHeight) / 3;
            int shapeX = (panelWidth - shapeSize) / 2;
            int shapeY = (panelHeight - shapeSize) / 2;

            switch (currentShape)
            {
                case ShapeType.Persegi:
                    g.DrawRectangle(Pens.Black, shapeX, shapeY, shapeSize, shapeSize);
                    break;

                case ShapeType.Lingkaran:
                    g.DrawEllipse(Pens.Black, shapeX, shapeY, shapeSize, shapeSize);
                    break;

                case ShapeType.PersegiPanjang:
                    g.DrawRectangle(Pens.Black, shapeX, shapeY, shapeSize * 2, shapeSize);
                    break;

                case ShapeType.Segitiga:
                    Point[] points = {
                new Point(shapeX + shapeSize / 2, shapeY),  // Titik atas segitiga
                new Point(shapeX, shapeY + shapeSize),      // Kiri bawah
                new Point(shapeX + shapeSize, shapeY + shapeSize) // Kanan bawah
            };
                    g.DrawPolygon(Pens.Black, points);
                    break;

                case ShapeType.JajarGenjang:
                    Point[] jajarGenjang = {
                new Point(shapeX + shapeSize / 4, shapeY),
                new Point(shapeX + shapeSize, shapeY),
                new Point(shapeX + (3 * shapeSize) / 4, shapeY + shapeSize),
                new Point(shapeX, shapeY + shapeSize)
            };
                    g.DrawPolygon(Pens.Black, jajarGenjang);
                    break;
            }
        }
        private void btnSegitiga_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.Segitiga;
            panel2.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.None;
            panel2.Invalidate();
        }

        private void btnPersegi_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.Persegi;
            panel2.Invalidate();
        }

        private void btnPersegiPanjang_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.PersegiPanjang;
            panel2.Invalidate();
        }

        private void btnJajarGenjang_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.JajarGenjang;
            panel2.Invalidate();
        }

        private void btnLingkaran_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.Lingkaran;
            panel2.Invalidate();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            panel2.Invalidate(); // Perbarui gambar
            float scaleX = (float)this.ClientSize.Width / 900;  // 900 = lebar awal form
            float scaleY = (float)this.ClientSize.Height / 400; // 400 = tinggi awal form

            foreach (var tombol in tombolAwal)
            {
                tombol.Key.Left = (int)(tombol.Value.X * scaleX);
                tombol.Key.Top = (int)(tombol.Value.Y * scaleY);
            }
        }
    }
}
