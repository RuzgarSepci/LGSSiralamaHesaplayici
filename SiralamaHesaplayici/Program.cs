using System;

namespace SiralamaHesaplayici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yüzdelik diliminiz (yüzde):");
            decimal dilim = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nSınava giren kişi sayısı:");
            ulong kisi = Convert.ToUInt64(Console.ReadLine());
            decimal siralama = dilim * kisi / 100;
            Console.WriteLine("\nSıralamanız: " + Convert.ToString(siralama));
            Console.ReadKey();
        }
    }
}
