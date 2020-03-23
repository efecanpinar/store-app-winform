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
    class Laptop : Product
    {
        public Laptop(object[] LaptopFeature, object[] Feature) : base(Feature)
        {
            this._laptopSizes = Convert.ToDouble(LaptopFeature[0]);
            this._laptopResolution = LaptopFeature[1].ToString();
            this._laptopMemory = Convert.ToInt32(LaptopFeature[2]);
            this._laptopRam = Convert.ToInt32(LaptopFeature[3]);
            this._laptopBattery = Convert.ToInt32(LaptopFeature[4]);
        }

        // Return laptop screen sizes
        public double laptopSizes
        {
            get { return _laptopSizes; }
        }
        
        // Return laptop screen resolution
        public string laptopResolution
        {
            get { return _laptopResolution; }
        }

        // Return laptop memory
        public int laptopMemory
        {
            get { return _laptopMemory; }
        }

        // Return laptop ram
        public int laptopRam
        {
            get { return _laptopRam; }
        }
        // Return laptop battery
        public int laptopBattery
        {
            get { return _laptopBattery; }
        }


        private double _laptopSizes;
        private string _laptopResolution;
        private int _laptopMemory;
        private int _laptopRam;
        private int _laptopBattery;
       

        // Taxing products method
        public override double applyTax()
        {
            return this.firstPrice * 1.15 * this.selectedPieces;   
        }
    }
}
