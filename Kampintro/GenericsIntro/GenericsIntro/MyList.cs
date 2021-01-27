using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        // BU class generic class örneğidir
        // Gelen T'nin ne olduğu önemli değildir
        T[]items;
        // aşağıdaki yapıya constructor denir
        // ctor ile yazılır
        // gelen array parametreyi new'le ve sıfır elemanlı yarat
        // constructor otomatik olarak MyList adını aldı
        public MyList()
        {
            items = new T[0];
        }
        // GELEN T Tipinde items arrayi oluşur
        // items değişkenine class içinde heryerden ulaşılabilir
        public void Add(T item)
        {
            // array'in eleman sayısını bir arttır
            // items.Length array'in eleman sayısını verir

            T[] tempArray = items;
            // aşağıda items'i new'layacağımız için önceki items
            // array'ini tempArray array'ine taşıyoruz
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length-1] = item;
        }

    }
}
