using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericOrnek3
{
    class GenericKoleksiyon<T>
    {
        T[] dizi;

        public GenericKoleksiyon()
        {
            dizi = new T[4];
        }

        public void ElemanEkle(T eleman)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                if(dizi[i] == null)
                {
                    dizi[i] = eleman;
                    break;
                }
            }
        }
    }
}
