using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4gün_odev5
{
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;
        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }
        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] tempKeyArray = keys;
            Tvalue[] tempValueArray = values;
            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keys[i] = tempKeyArray[i];

            }
            keys[keys.Length - 1] = key;

            for (int i = 0; i < tempValueArray.Length; i++)
            {
                values[i] = tempValueArray[i];

            }

            values[values.Length - 1] = value;
        }
        public int Count
        {
            get { return keys.Length; }
        }
        public Tvalue[] GetValue
        {
            get { return values; }
        }
        public Tkey[] GetKey
        {
            get { return keys; }
        }
    }
}
