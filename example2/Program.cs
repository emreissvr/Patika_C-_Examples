using System;
using System.Collections;

namespace example2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList();
            // int[] sayilar= new int[20];
            ArrayList enKucukUc = new ArrayList();
            ArrayList enBuyukUc = new ArrayList();
            int toplam1 = 0;
            int toplam2 = 0;

            for(int i = 1; i <= 20; i++){
                System.Console.Write(i + ". sayıyı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(sayi);
                System.Console.WriteLine(sayilar[i-1]);
            }
            


            sayilar.Sort();
            
            
            int sayac = 1;
            foreach (var item in sayilar)
            {
                if( sayac == 1 || sayac == 2 || sayac == 3){
                    enKucukUc.Add(item);
                    
                }
                else if(sayac == 18 || sayac == 19 || sayac == 20){
                    enBuyukUc.Add(item);
                }
                sayac++;

            } 
                
               
            

            foreach (int item in enKucukUc)
            {
                toplam1 += Convert.ToInt32(item);
                System.Console.WriteLine(item);
            }
            foreach (int item in enBuyukUc)
            {
                toplam2 += Convert.ToInt32(item);
                System.Console.WriteLine(item);

            }
            
            System.Console.WriteLine("ilk üç sayının ortalaması : " + (toplam1/3));
            System.Console.WriteLine("son üç sayının ortalaması : " + (toplam2/3));
            System.Console.WriteLine("ortalamalar toplamı : " + ((toplam1/3) + (toplam2/3)));

        }
    }
}
