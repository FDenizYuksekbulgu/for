using System;

class Program
{
    static void Main()
    {
        // 1.Görev: For döngüsü ile 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" mesajı yazdırıldı.

        for (int i = 0; i < 10; i++)

        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
        }

        // 2.Görev: 1 ile 20 arasındaki sayılar konsol ekranına yazdırıldı.

        for (int i = 1; i < 10; i++)

        {
            Console.WriteLine(i);
        }

        // 3.Görev: 1 ile 20 arasındaki çift sayılar konsol ekranına yazdırıldı.

        for (int i = 2; i < 20; i += 2)

        {
            Console.WriteLine(i);
        }

        //4.Görev: 50 ile 150 arasındaki sayıların toplamın ekrana yazdırıldı.

        int toplam = 0;


        for (int i = 50; i < 150; i++)

        {
            toplam += i;
        }


        Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam}");

        //5.Görev:  1 ile 120 arasındaki tek sayıların toplamları ekrana yazdırıldı.



        int tek = 0;

        for (int i = 1; i < 120; i += 2)
        {
            tek += i;
        }


        Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {tek}");


        //5.Görev:  1 ile 120 arasındaki çift sayıların toplamları ekrana yazdırıldı.



        int cift = 0;

        for (int i = 0; i < 120; i += 2)
        {
            cift += i;
        }


        Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {cift}");


    }
}
