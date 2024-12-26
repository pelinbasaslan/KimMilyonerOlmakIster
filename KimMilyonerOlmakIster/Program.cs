using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kim Milyoner Olmak İster'e hoşgeldiniz. 3 sorudan 2 soruyu bildiğiniz taktirde 1Milyon TL'lik Büyük Ödülü kazanacaksınız. Eğer ki ilk iki soruyu bilirseniz, büyük ödülü kazanmış olacağınızdan dolayı 3.soruyu görmeyeceksiniz. Bol Şanslar!");

        //doğru cevap değişkeni
        int correctAnswers = 0;

        //ilk soru
        Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir ?");
        Console.WriteLine("a) Lama b) Deve ");
        Console.Write("Cevabınız nedir?");
        string firstAnswer = Console.ReadLine();
        if (firstAnswer == "a" || firstAnswer == "A")
        {
            Console.WriteLine("Doğru Cevap.");
            correctAnswers += 1;
        }
        else
        {
            Console.WriteLine("Yanlış Cevap.");
        }

        //iki türlü de ikinci soru sorulacak.
        //2.soru
        Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir ? ");
        Console.WriteLine("a) Venüs b) Mars ");
        Console.Write("Cevabınız nedir?");
        string secondAnswer = Console.ReadLine();
        if (secondAnswer == "a" || secondAnswer == "A")
        {
            Console.WriteLine("Doğru Cevap.");
            correctAnswers += 1;
            if (correctAnswers == 2)
            {
                Console.WriteLine("Ödülü Kazandınız.");
            }
            else
            {
                //3.soruya geçilecek.
                Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
                Console.WriteLine("a) 7 b) 12 ");
                Console.WriteLine("Cevabınız nedir?");
                string thirdAnswer = Console.ReadLine();
                if (thirdAnswer == "b" || thirdAnswer == "B")
                {
                    Console.WriteLine("Doğru Cevap.");
                    correctAnswers += 1;
                    if (correctAnswers == 2)
                    {
                        Console.WriteLine("Kazandınız.");
                    }
                    else
                    {
                        Console.WriteLine("Kaybettiniz.");
                    }
                }
                else
                {
                    Console.WriteLine("Kaybettiniz.");
                }
            }
        }
        else
        {
            Console.WriteLine("Yanlış Cevap");
            if (correctAnswers == 0)
            {
                Console.WriteLine("Kaybettiniz.");
            }
            else
            {
                //3.soruya geçecek.
                Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
                Console.WriteLine("a) 7 b) 12 ");
                Console.WriteLine("Cevabınız nedir?");
                string thirdAnswer = Console.ReadLine();
                if (thirdAnswer == "b" || thirdAnswer == "B")
                {
                    Console.WriteLine("Doğru Cevap.");
                    correctAnswers += 1;
                    if (correctAnswers == 2)
                    {
                        Console.WriteLine("kazandınız.");
                    }
                    else
                    {
                        Console.WriteLine("kaybettiniz.");
                    }
                }
            }


        }


    }
}