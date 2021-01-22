using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //constructor=yapıcı , classı newlediğin anda constructor çalışır.

        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item) // vereceğimiz tipe karşılık geliyor.
        {
            T[] tempArray = items; // tempArray:geçici dizi
            items = new T[items.Length+1];//dizi elemanını 1 artırıyoruz dinamik olarak
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
       
    }
}
