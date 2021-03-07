using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.DizilerApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kaç adet sayı üretilmesini istersiniz?");
            int adet = int.Parse(Console.ReadLine());
            int[] Sayilar = new int[adet];
            Random rnd = new Random();

            for (int i = 0; i < Sayilar.Length; i++)
            {
                Sayilar[i] = rnd.Next(10, 100); 
                for (int kontrol = 0; kontrol < i; kontrol++)
                {

                    if (Sayilar[kontrol] == Sayilar[i])
                    {
                        i--;
                        break;
                    }
                }
            }
            Array.Sort(Sayilar);
            for (int i = 0; i < Sayilar.Length; i++)
            {
                Console.Write($"{Sayilar[i]}-");
            }
            Console.ReadKey();

        }

    }

}


        
    

    
 
                        
                
                    

                    
            
        
        

    



    

