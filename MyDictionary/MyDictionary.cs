using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TKey[] tempKeys;

        TValue[] values;
        TValue[] tempValues;

        public MyDictionary()
        {
            TKey[] keys = new TKey[0];
            TValue[] values = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {
            tempKeys = keys;
            tempValues = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < keys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
    }
}
