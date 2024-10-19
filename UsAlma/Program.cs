namespace UsAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ÜSSÜ ALINACAK SAYI? ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("KAÇA KADAR ÜS ALINSIN ");
            int alinacaküs = Convert.ToInt32(Console.ReadLine());
            int toplam = 1;

            for (int i = 1; i <= alinacaküs; i++)
            {

                toplam *= alinacaküs;
                Console.WriteLine("{0} ÜZERİ {1} :{2}", sayi, i, toplam);



            }
        }
    }
}
