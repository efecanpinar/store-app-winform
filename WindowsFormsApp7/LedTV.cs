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
    class LedTV : Product
    {
        public LedTV(object[] tvFuture, object[] Feature) : base(Feature)
        {
            this._screenSizes = Convert.ToInt32(tvFuture[0]);
            this._resolution = tvFuture[1].ToString();
        }

        private int _screenSizes;
        private string _resolution;


        // Return TV screen sizes
        public int screenSizes
        {
            get { return _screenSizes; }
        }

        // Return TV screen resolution
        public string resolution
        {
            get { return _resolution; }
        }
           


        // Taxing products method
        public override double applyTax()
        {
            return this.firstPrice * 1.18 * this.selectedPieces;
        }
    }
}
