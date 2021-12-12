using System;
using System.Collections;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();
            ArrayList list2 = new ArrayList();
            int toplam1 = 0;
            int toplam2 = 0;

            for (int i = 0; i < 20; i++)
            {
            
                System.Console.WriteLine(i+1 + ". sayıyı giriniz: ");
                int sayilar = Convert.ToInt32(Console.ReadLine());
                if (negatifMi(sayilar))
                {
                    int sayac = 0;
                    for (int k = 2; k < sayilar; k++)
                    {
                        if (sayilar % k == 0)
                        {
                            sayac++;
                        }

                    }
                    if (sayac == 0)
                    {
                        if(sayac==1){
                            list2.Add(sayilar);
                        }
                        else
                            list1.Add(sayilar);
                    }
                    else
                    {
                        list2.Add(sayilar);
                    }


                }
                else
                {
                    System.Console.WriteLine("Lütfen Pozitif ve Numeric Bir sayı Giriniz");
                }

            }

            list1.Sort();
            list1.Reverse();
            list2.Sort();
            list2.Reverse();


            System.Console.WriteLine("----------Asal Sayılar----------");
            foreach (int item in list1)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("----------Asal Olmayan Sayılar----------");
            
            foreach (var item in list2)
            {
                System.Console.WriteLine(item);
            }


            foreach (int item in list1)
            {
                toplam1=toplam1+item;
                    
            }
            System.Console.WriteLine("Asal Sayıların Ortalaması=  " + toplam1/list1.Count+ "  Dizideki Eleman Sayısı= "+list1.Count );
            
            foreach (int item in list2)
            {
                toplam2=toplam2+item;
                    
            }
             System.Console.WriteLine("Asal Olmayan Sayıların Ortalaması=  " + toplam2/list2.Count+ "  Dizideki Eleman Sayısı= " + list2.Count );

        }


         private static bool negatifMi(int s)
        {
            bool sonuc = true;
            if (s < 0)
            {
                sonuc = false;
            }

            return sonuc;

        }
    }
}
