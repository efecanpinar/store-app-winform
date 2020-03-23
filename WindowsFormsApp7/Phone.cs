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
    class Phone : Product
    {
        public Phone(object[] phoneFeature, object[] Feature) : base(Feature)
        {
            this._memory = Convert.ToInt32(phoneFeature[0]);
            this._ram = Convert.ToInt32(phoneFeature[1]);
        }

        private int _memory;
        private int _ram;

        // Return phone memory
        public int memory
        {
            get { return _memory; }
        }

        // Return phone ram
        public int ram
        {
            get { return _ram; }
        }


        // Taxing products method
        public override double applyTax()
        {
            return this.firstPrice * 1.20 * this.selectedPieces;
        }
    }
}
