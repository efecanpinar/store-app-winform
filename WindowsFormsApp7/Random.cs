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
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{       
    // Creating random numbers
    public static class Random
    {
        public static int CreateRandomStock()
        {
            System.Random rndStock = new System.Random();
            Thread.Sleep(100);
            return rndStock.Next(1, 101);
        }
        
    }
}
