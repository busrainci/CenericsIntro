using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenericsIntro
{
    class MyList<T>
    {
        //count eleman sayısı demek

        T[] items;
        //constructor : classı herhangi bir yerde new lersen mylist otomatik olarak çalışır. classla aynı isim olduğu için constructor olur.
        public MyList() // ctor yazıp tab tab yaptık
        {
            items = new T[0]; // array oluştu ve sıfır elemanlı oldu.
        }

 
        public void Add(T item) {

            T[] tempArray = items; //tempArray : geçici dizi demektir.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;


        }
    }
}
