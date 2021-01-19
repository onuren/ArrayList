using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//arraylist için eklenmelidir

namespace koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(12);
            list.Add("selam");
            list.Add(48.5);
            list.AddRange(new int[] { 45, 50, 84, 45 });
            list.Insert(1, "Hi");

            //Console.WriteLine(list[2]);
            //Console.WriteLine(list.Count);

            kitap k = new kitap() { isim = "cin ali", yazar = "anonim", yayimevi = "yayınevleri", fiyat = 12 };
            list.Add(k);

            Console.WriteLine(list.Count);//9
            Console.WriteLine(list.Capacity);//16
            list.TrimToSize();//listede açılan boş yerleri siler, eklenen eleman sayısına göre 2,4,8,16,32 şeklinde artar.
            Console.WriteLine(list.Count);//9
            Console.WriteLine(list.Capacity);//9


        }
    }
    class kitap
    {
        public string isim { get; set; }
        public string yazar { get; set; }
        public string yayimevi { get; set; }
        public double fiyat { get; set; }
    }
}
