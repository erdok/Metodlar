using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // alttaki her new lendiğinde kaybolacağı için referans numarası kaybolmasın diye buraya tutturduk
            items = new T[items.Length + 1]; // tek başına kalırsa referans numarası her new olduğunda yeni bir değer alacağından listemiz sıfırlanacak            
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

    }
}
