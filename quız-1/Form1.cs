using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quız_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        { 

            Class1 oyuncu1 = new Class1();
            oyuncu1.Id = "6516658668510752";
            oyuncu1.Ad = "Davinson";
            oyuncu1.Soyad = "Sanchez";
            oyuncu1.Posta = "dvsn.sanchez@gmail.com";
            oyuncu1.Puan = 100;
            oyuncu1.KayitTarih = DateTime.Now;
            oyuncu1.Aktif = false;
        }
    }
}
