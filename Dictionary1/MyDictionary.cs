using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1
{
    internal class MyDictionary<TKey, TValue>
    {
        public TKey[] keys;
        public TValue[] values;

        TKey[] tempKeys;
        TValue[] tempValues;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey item1, TValue item2)
        {
            tempKeys = keys;
            tempValues = values;

            keys = new TKey[tempKeys.Length + 1];
            values = new TValue[tempValues.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];

            }
            keys[keys.Length - 1] = item1;
            values[values.Length - 1] = item2;

        }

        public int Count
        {
            get { return keys.Length; }
        }
    }
}
