using System;
using System.Collections;


namespace example3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sentence = new ArrayList();
            System.Console.WriteLine("Lütfen bir cümle giriniz: ");
            string metin = Console.ReadLine();
            string sesli = "aeıioöuüAEIİOÖUÜ";
            int sayac = 0;
            for (int i = 0; i<metin.Length; i++){
                if(sesli.Contains(metin[i])){
                    sayac++;
                    sentence.Add(metin[i]);
                }
            }

            System.Console.WriteLine("Kelime içerisinde toplam" + sayac + "tane sesli harf far");
            foreach (var item in sentence)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
