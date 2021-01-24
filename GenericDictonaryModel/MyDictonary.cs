using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDictonaryModel
{
    class MyDictonary<TKey,TValue>
    {
        TKey[] tkey;
        TValue[] tvalue;

        public MyDictonary()
        {
            tkey = new TKey[0];
            tvalue = new TValue[0];
        }

        public void Add(TKey itemKey,TValue itemValue)
        {
            TKey[] tempArrKey = tkey;
            TValue[] tempArrValue = tvalue;
            tkey = new TKey[tkey.Length + 1];
            tvalue = new TValue[tvalue.Length + 1];
            for (int i = 0; i < tempArrKey.Length; i++)
            {
                tkey[i] = tempArrKey[i];
                tvalue[i] = tempArrValue[i];
            }

            tkey[tkey.Length - 1] = itemKey;
            tvalue[tkey.Length - 1] = itemValue;

        }

        public void printAll()
        {
            for (int i = 0; i < tkey.Length; i++)
            {
                Console.WriteLine(tkey[i] + " Key , Value : " +tvalue[i]);    
            }
        }




    }
}
