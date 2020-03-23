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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Cart
    {
        // Create list for listboxes
        public static List<double> TaxPrice = new List<double>();
        public static List<int> Pieces = new List<int>();
        public static List<string> Products = new List<string>();

        // Adding selected products to the cart
        public static void addToCart(Product product, int count)
        {
            if(count != 0)
            {
                TaxPrice.Add(product.applyTax());
                Pieces.Add(count);
                Products.Add(product.name);
            }
        }

        // Deleting selected products from the cart
        public static void ClearCart()
        {
            Products.Clear();
            Pieces.Clear();
            TaxPrice.Clear();
        }
    }
}
