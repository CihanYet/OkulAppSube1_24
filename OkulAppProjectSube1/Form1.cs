using EfApp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppProjectSube1
{
    public partial class Form1 : Form
    {
        Ogrenci? ogr;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            bool kontrol = false;
            foreach (Control item in grpOgrenci.Controls)
            {
                if (item is TextBox && item.Text == String.Empty)
                {
                    item.BackColor = Color.Red;
                    kontrol = true;
                }
            }
            if (kontrol)
            {
                MessageBox.Show("Tüm alanlar zorunludur");
                return;
            }

            var ogr = new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() };

            using (var ctx = new OkulDbContext())
            {
                ctx.Ogrenciler.Add(ogr);
                var sonuc = ctx.SaveChanges();
                MessageBox.Show(sonuc > 0 ? "Kayıt Başarılı" : "Kayıt Ekleme Başarısız!");
            }

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;
            if (txt.Text == String.Empty)
            {
                txt.BackColor = Color.Red;
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            using (var ctx = new OkulDbContext())
            {
                var ogr = ctx.Ogrenciler.Find(int.Parse(txtId.Text.Trim()));
                if (ogr != null)
                {
                    this.ogr = ogr;
                    txtAd.Text = ogr.Ad;
                    txtSoyad.Text = ogr.Soyad;
                    txtNumara.Text = ogr.Numara;
                }
                else
                {
                    MessageBox.Show("Öğrenci Bulunamadı!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var ctx = new OkulDbContext())
            {
                if (ogr != null)
                {
                    ogr.Numara = txtNumara.Text.Trim();
                    ogr.Ad = txtAd.Text.Trim();
                    ogr.Soyad = txtSoyad.Text.Trim();
                    ctx.Entry(ogr).State = EntityState.Modified;
                    MessageBox.Show(ctx.SaveChanges() > 0 ? "Güncelleme Başarılı" : "Başarısız");
                }
                else
                {
                    MessageBox.Show("Öğrenci öğrenci bulunmalıdır!");
                }
            }
        }
    }
}
