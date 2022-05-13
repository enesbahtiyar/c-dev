using System;
using System.Collections.Generic;

namespace patikaCsharpOdevBir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kaç sayı girmek istiyorsanız sayısını yazın ");
            int numbersToEnter1 = 0;
            
            do
            {
                Console.Write("Pozitif bir tamsayı giriniz -> ");
                if (int.TryParse(Console.ReadLine(), out numbersToEnter1) && numbersToEnter1 > 0)
                    break;
                Console.WriteLine("Geçersiz girdi, pozitif sayı giriniz!");

            } while (numbersToEnter1 <= 0);

            Console.WriteLine(numbersToEnter1 + " tane pozitif sayı giriniz");

            List<int> numberList1 = new List<int>();

            for (int i = 0; i<numbersToEnter1; i++)
            {
                int girdi = 0;
                do 
                {
                    Console.Write("Pozitif bir tamsayı giriniz -> ");
                    if (int.TryParse(Console.ReadLine(), out girdi) && girdi > 0)
                        break;
                    Console.WriteLine("Geçersiz girdi, pozitif sayı giriniz!");

                } while (girdi <= 0);

                if (girdi % 2 == 0)
                    numberList1.Add(girdi);
            }

           numberList1.ForEach(Console.WriteLine);

            
            Console.Write("2 adet sayı girmeniz beklenmetedir ");
            int sayiN = 0;
            int sayiM = 0;

            do
            {
                Console.Write("Bir adet N değeri giriniz -> ");
                if (int.TryParse(Console.ReadLine(), out sayiN) && sayiN > 0)
                    break;
                Console.WriteLine("Geçersiz girdi, pozitif sayı giriniz!");

            } while (sayiN <= 0);

            do
            {
                Console.Write("Bir adet M değeri giriniz -> ");
                if (int.TryParse(Console.ReadLine(), out sayiM) && sayiM > 0)
                    break;
                Console.WriteLine("Geçersiz girdi, pozitif sayı giriniz!");

            } while (sayiN <= 0);

            List<int> numberList2 = new List<int>();

            for (int i = 0; i < sayiN; i++)
            {
                int girdi = 0;
                do 
                {
                    Console.Write("Pozitif bir tamsayı giriniz -> ");
                    if (int.TryParse(Console.ReadLine(), out girdi) && girdi > 0)
                        break;
                    Console.WriteLine("Geçersiz girdi, pozitif sayı giriniz!");

                } while (girdi <= 0);

                if (girdi == sayiM || girdi%sayiM == 0)
                    numberList2.Add(girdi);
            }
            numberList2.ForEach(Console.WriteLine);

            
            Console.WriteLine("Pozitif bir N sayısı girin, sonra N adet kelime girmeniz istenecek, sonra yazdığınız kelimeler baştan sonra sıralanacak -> ");
            int kelimeSayisiN = 0;

            do
            {
                Console.Write("Bir adet N değeri giriniz -> ");
                if (int.TryParse(Console.ReadLine(), out kelimeSayisiN) && kelimeSayisiN > 0)
                    break;
                Console.WriteLine("Geçersiz girdi, pozitif sayı giriniz!");

            } while (kelimeSayisiN <= 0);

            List<string> kelimeList1 = new List<string>();

            for (int i = 0; i < kelimeSayisiN; i++)
            {
                string girdi = Console.ReadLine();
                kelimeList1.Add(girdi);
            }
            kelimeList1.Reverse();
            kelimeList1.ForEach(Console.WriteLine);

           Console.WriteLine("Noktayla biten bir cümle yazın. Daha sonrasında Cümledeki toplam harf ve kelime sayıları ekrana yazılacak -> ");
            int harfSayisi = 0;
            int kelimeSayisi = 1;
            string cumle = Console.ReadLine();

            for(int i = 0; i <= cumle.Length - 1; i++)
            {
                /* check whether the current character is white space or new line or tab character*/
                if (cumle[i] == ' ' || cumle[i] == '\n' || cumle[i] == '\t')
                {
                    kelimeSayisi++;
                }
                if(cumle[i] != ' ' && cumle[i] != '.')
                harfSayisi++;
            }

            Console.WriteLine("Kelime sayisi: " + kelimeSayisi + " Harf Sayısı: " + harfSayisi);

        }
    }
}
