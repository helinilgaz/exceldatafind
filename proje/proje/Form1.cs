using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;


namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void excel_btnAc_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Belge seçiniz...";
            openFileDialog1.Filter = "excel 2003 dosyaları (*.xls)|*.xls|excel 2010-2016 dosyaları (*.xlsx) |*.xlsx";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                MessageBox.Show("Dosya Seçilmedi....");
            else
            {
                Excel.Application ExcelApp = new Excel.Application();
                ExcelApp.Workbooks.Open(openFileDialog1.FileName);
                ExcelApp.Visible = true;

                Excel.Range bulunan = null;
                int adet, fıyat;
                string ürünkodu, dosya;
                Boolean aranan_dosya;
                ürünkodu = Interaction.InputBox("Lütfen kodu giriniz :");
                ExcelApp.Worksheets[1].Activate();                
                bulunan = ExcelApp.Cells.Find(What: ürünkodu);
                if (bulunan == null)
                    MessageBox.Show("Bulunamadı :");
                else
                {
                    bulunan.Activate();
                   
                  MessageBox.Show("No =" + ürünkodu + ".Ürünadı =" + ExcelApp.Worksheets[1].Cells[bulunan.Column+1, bulunan.Row].value);                                                  
                }
                ExcelApp.Application.Quit();

            }        
        }

        private void kıyafetSecınız_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (kıyafetSecınız.Text == "t-shırt") pictureBox1.ImageLocation = "t-shırt.jpg";
            if (kıyafetSecınız.Text == "triko") pictureBox1.ImageLocation = "triko.jpg";
            if (kıyafetSecınız.Text == "uzun elbise") pictureBox1.ImageLocation = "uzun elbise.jpg";
            if (kıyafetSecınız.Text == "etek") pictureBox1.ImageLocation = "etek.jpg";
            if (kıyafetSecınız.Text == "şort") pictureBox1.ImageLocation = "şort.jpg";
            if (kıyafetSecınız.Text == "çeket") pictureBox1.ImageLocation = "çeket.jpg";
            if (kıyafetSecınız.Text == "mont") pictureBox1.ImageLocation = "mont.jpg";
            if (kıyafetSecınız.Text == "elbise") pictureBox1.ImageLocation = "elbise.jpg";
            if (kıyafetSecınız.Text == "kazak") pictureBox1.ImageLocation = "kazak.jpg";
            if (kıyafetSecınız.Text == "boyfriend jean") pictureBox1.ImageLocation = "boyfriend jean.jpg";
            if (kıyafetSecınız.Text == "şapka") pictureBox1.ImageLocation = "şapka.jpg";
            if (kıyafetSecınız.Text == "eldiven") pictureBox1.ImageLocation = "eldiven.jpg";
            if (kıyafetSecınız.Text == "spor ayakkabı") pictureBox1.ImageLocation = "spor ayakkabı.jpg";
            if (kıyafetSecınız.Text == "topuklu ayakkabı") pictureBox1.ImageLocation = "topuklu ayakkabı.jpg";
        }
    }
}

