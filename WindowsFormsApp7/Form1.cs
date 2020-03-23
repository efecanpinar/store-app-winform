/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Ödev 3
**				ÖĞRENCİ ADI............: Muhammed Efecan PINAR
**				ÖĞRENCİ NUMARASI.......: G181210092
**              DERSİN ALINDIĞI GRUP...: 2D
****************************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        Product laptop;
        Product phone;
        Product ledTv;
        Product refrigator;
        public Form1()
        {

            InitializeComponent();
        }

        // Products features
        private void Form1_Load(object sender, EventArgs e)
        {
            object[] laptopFeature = {17, "1368x1080", 480, 8, 4000};
            object[] laptopProductFeature =
            {
                "Laptop",
                "Lenovo",
                "Lenovo Ideapad 330",
                "The Best Laptop",
                "4000"
            };

            object[] ledTvFeature = { 17, "4K UHD, 1080p" };
            object[] ledTvProductFeature =
            {
                "LED TV",
                "Samsung",
                "QE75Q",
                "The Best Tv",
                26000
            };

            object[] phoneFeature = { 64, 8 };
            object[] phoneProductFeature =
            {
                "Mobile Phone",
                "Iphone",
                "Iphone 11 Pro Max",
                "The Best Phone",
                10000
            };

            object[] refrigatorFeature = { 682, "A++" };
            object[] refrigatorProductFeature =
            {
                "Refrigator",
                "Siemens",
                "KG86NH",
                "The Best Refrigator",
                8000
            };

            laptop = new Laptop(laptopFeature, laptopProductFeature);
            this.lblPcPrice.Text = laptop.firstPrice.ToString();
            this.lblPcStock.Text = laptop.stockQuantityPC.ToString();

            ledTv = new LedTV(ledTvFeature, ledTvProductFeature);
            this.lblTvPrice.Text = ledTv.firstPrice.ToString();
            this.lblTvStock.Text = ledTv.stockQuantityTV.ToString();

            phone = new Phone(phoneFeature, phoneProductFeature);
            this.lblPhonePrice.Text = phone.firstPrice.ToString();
            this.lblPhoneStock.Text = phone.stockQuantityPhone.ToString();

            refrigator = new Refrigator(refrigatorFeature, refrigatorProductFeature);
            this.lblRefPrice.Text = refrigator.firstPrice.ToString();
            this.lblRefStock.Text = refrigator.stockQuantityRefrigator.ToString();
        }

        // If the cart is full, it clears the cart
        private new void Refresh()
        {
            this.listTotalPieces.DataSource = null;
            this.listTotalPrice.DataSource = null;
            this.listTotalProduct.DataSource = null;
            Cart.ClearCart();
        }

        // Clear cart method
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            Refresh();
            this.lblTotalPrice.Text = " ";
            numPcPieces.Value = 0;
            numTvPieces.Value = 0;
            numPhonePieces.Value = 0;
            numRefPieces.Value = 0;
        }
        // Add to cart button method
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Refresh();
            Cart.addToCart(laptop, Convert.ToInt32(numPcPieces.Value));
            Cart.addToCart(ledTv, Convert.ToInt32(numTvPieces.Value));
            Cart.addToCart(phone, Convert.ToInt32(numPhonePieces.Value));
            Cart.addToCart(refrigator, Convert.ToInt32(numRefPieces.Value));

            listTotalPieces.DataSource = Cart.Pieces;
            listTotalPrice.DataSource = Cart.TaxPrice;
            listTotalProduct.DataSource = Cart.Products;

            lblTotalPrice.Text = Cart.TaxPrice.Sum() + " TL";


            if (Convert.ToInt32(lblPcStock.Text) >= 0)
            {
               if(Convert.ToInt32(lblPcStock.Text) >= Convert.ToInt32(numPcPieces.Value))
                {
                    int stockPC;
                    int.TryParse(lblPcStock.Text, out stockPC);
                    stockPC = stockPC - Convert.ToInt32(numPcPieces.Value);
                    lblPcStock.Text = stockPC.ToString();
                }
            }

            if (Convert.ToInt32(lblTvStock.Text) >= 0)
            {
                if (Convert.ToInt32(lblTvStock.Text) >= Convert.ToInt32(numTvPieces.Value))
                {
                    int stockTV;
                    int.TryParse(lblTvStock.Text, out stockTV);
                    stockTV = stockTV - Convert.ToInt32(numTvPieces.Value);
                    lblTvStock.Text = stockTV.ToString();
                }
            }

            if (Convert.ToInt32(lblRefStock.Text) >= 0)
            {
                if (Convert.ToInt32(lblRefStock.Text) >= Convert.ToInt32(numRefPieces.Value))
                {
                    int stockRef;
                    int.TryParse(lblRefStock.Text, out stockRef);
                    stockRef = stockRef - Convert.ToInt32(numRefPieces.Value);
                    lblRefStock.Text = stockRef.ToString();
                }
            }

            if (Convert.ToInt32(lblPhoneStock.Text) >= 0)
            {
                if (Convert.ToInt32(lblPhoneStock.Text) >= Convert.ToInt32(numPhonePieces.Value))
                {
                    int stockPhone;
                    int.TryParse(lblPhoneStock.Text, out stockPhone);
                    stockPhone = stockPhone - Convert.ToInt32(numPhonePieces.Value);
                    lblPhoneStock.Text = stockPhone.ToString();
                }
            }
        }

        // NumericUpDown button of laptop
        private void numPcPieces_ValueChanged(object sender, EventArgs e)
        {
            this.laptop.selectedPieces = Convert.ToInt32(numPcPieces.Value);
            numPcPieces.Maximum = laptop.stockQuantityPC;
        }

        // NumericUpDown button of LedTV
        private void numTvPieces_ValueChanged(object sender, EventArgs e)
        {
            this.ledTv.selectedPieces = Convert.ToInt32(numTvPieces.Value);
            numTvPieces.Maximum = ledTv.stockQuantityTV;
        }

        // NumericUpDown button of Mobile Phone
        private void numPhonePieces_ValueChanged(object sender, EventArgs e)
        {
            this.phone.selectedPieces = Convert.ToInt32(numPhonePieces.Value);
            numPhonePieces.Maximum = phone.stockQuantityPhone;
        }

        // NumericUpDown button of Refrigator
        private void numRefPieces_ValueChanged(object sender, EventArgs e)
        {
            this.refrigator.selectedPieces = Convert.ToInt32(numRefPieces.Value);
            numRefPieces.Maximum = refrigator.stockQuantityRefrigator;
        }

        // Finish the shopping button
        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
