using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericKoleksiyon<string> koleksiyon = new GenericKoleksiyon<string>();

            koleksiyon.ElemanEkle("Ankara");
            koleksiyon.ElemanEkle("İstanbul");
            koleksiyon.ElemanEkle("İzmir");
            koleksiyon.ElemanEkle("Eskişehir");

            Console.ReadLine();
        }
    }
}
