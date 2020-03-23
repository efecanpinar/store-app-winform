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
    public abstract class Product
    {
        public Product(object[] Feature )
        {
            this._stockQuantityPC = Random.CreateRandomStock();
            this.stockQuantityPhone = Random.CreateRandomStock();
            this.stockQuantityRefrigator = Random.CreateRandomStock();
            this.stockQuantityTV = Random.CreateRandomStock();
            this._name = Feature[0].ToString(); 
            this._brand = Feature[1].ToString();
            this._model = Feature[2].ToString();
            this._quality = Feature[3].ToString();
            this._firstPrice = (Convert.ToDouble(Feature[4]));
        }

        private string _name;
        private string _brand;
        private string _model;
        private string _quality;
        private int _stockQuantityTV;
        private int _stockQuantityRefrigator;
        private int _stockQuantityPhone;
        private int _stockQuantityPC;
        private double _firstPrice;
        private int _selectedPieces;

        // Return name
        public string name
        {
            get { return _name; }
        }

        // Return brand
        public string brand
        {
            get { return _brand; }
        }

        // Return model
        public string model
        {
            get { return _model; }
        }

        // Return quality
        public string quality
        {
            get { return _quality; }
        }

        // Return stock quantity of laptop
        public int stockQuantityPC
        {
            get { return _stockQuantityPC; }
            set { _stockQuantityPC = value; }
        }

        // Return stock quantity of LedTv
        public int stockQuantityTV
        {
            get { return _stockQuantityTV; }
            set { _stockQuantityTV = value; }
        }

        // Return stock quantity of Phone
        public int stockQuantityPhone
        {
            get { return _stockQuantityPhone; }
            set { _stockQuantityPhone = value; }
        }

        // Return stock quantity of Refrigator
        public int stockQuantityRefrigator
        {
            get { return _stockQuantityRefrigator; }
            set { _stockQuantityRefrigator = value; }
        }

        // Return first price before the taxing
        public double firstPrice
        {
            get { return _firstPrice; }
        }

        // Return the piece of selected products
        public int selectedPieces
        {
            get { return _selectedPieces; }
            set { _selectedPieces = value; }
        }

        // Definition apply tax method
        public abstract double applyTax();

    } 
}
