using DRxamarin.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace DRxamarin.clouddata
{
	public class uyeolusturma
	{
		public List<uyemodeli> uyeler = new List<uyemodeli>();
		uyemodeli yeniuye;

		public uyeolusturma(string isim,string soyisim,string email,string sifre)
		{
			yeniuye = new uyemodeli();
			yeniuye.Ad = isim;
			yeniuye.Soyad = soyisim;
			yeniuye.Eposta = email;
			yeniuye.Sifre = sifre;
			uyeler.Add(yeniuye);
		}
	}
}
