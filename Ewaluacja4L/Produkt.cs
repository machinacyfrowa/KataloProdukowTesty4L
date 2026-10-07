using System;
using System.Collections.Generic;
using System.Text;

namespace Ewaluacja4L
{
    public class Produkt
    {
        public string Nazwa;
        public double Cena;
        public string Kategoria;
        public int Ilosc;
        public double WartoscMagazynu
        {
            get { return Cena * Ilosc ; }
        }
        //funkcja sprawdza czy poprawnie obliczamy wartośc magazynu
        public static void SprawdzWartosc(Produkt p)
        {

            if(p.WartoscMagazynu == p.Cena * p.Ilosc)
            {
                Console.WriteLine("Wartość magazynu jest poprawna.");
            }
            else
            {
                Console.WriteLine("Wartość magazynu jest niepoprawna.");
            }
        }
        //funkcja sprawdza czy cena produktu jest poprawna (nieujemna)
        public static void SprawdzCeny(List<Produkt> produkty)
        {
            foreach (var produkt in produkty)
            {
                if (produkt.Cena < 0)
                {
                    Console.WriteLine($"Produkt {produkt.Nazwa} ma niepoprawną cenę: {produkt.Cena}");
                }
            }
        }
    }
}