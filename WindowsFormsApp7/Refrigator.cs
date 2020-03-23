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
    class Refrigator : Product
    {
        public Refrigator(object[] refrigatorFeature, object[] Feature) : base(Feature)
        {
            this._capacity = Convert.ToInt32(refrigatorFeature[0]);
            this._energyRating = refrigatorFeature[1].ToString();

        }

        private int _capacity;
        private string _energyRating;

        // Return capacity of refrigator
        public int capacity
        {
            get { return _capacity; }
        }

        // Return energy rating of refrigator
        public string energyRating
        {
            get { return _energyRating; }
        }


        // Taxing products method
        public override double applyTax()
        {
            return this.firstPrice * 1.05 * this.selectedPieces;
        }


    }
}
