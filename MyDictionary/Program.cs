namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(5265484, "Resul Aydın");
            Console.WriteLine(dictionary.Count);
            Console.WriteLine(dictionary[5265484]);

            string? result;
            Console.WriteLine(dictionary.TryGetValue(5265484, out result));


            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(11165484, "Tenacious Aydın");
            myDictionary.Add(11452484, "Humanity Aydın");
            myDictionary.Add(11452486, "İnsan Aydın");
            Console.WriteLine(myDictionary.Count());
            Console.WriteLine(" ---------- GetValueByKey ------------");
            Console.WriteLine(myDictionary.GetValueByKey(11452486));

        }
    }

    class MyDictionary<TKey, TValue>
    {
        TKey[] _keys, _tempTKey;
        TValue[] _values, _tempTValue;
        object[,] objects;
        int i = 0, j = 0;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {

            if (!ContainsKey(key))
            {
                _tempTKey = _keys;
                _tempTValue = _values;

                _keys = new TKey[_keys.Length + 1];
                _values = new TValue[_values.Length + 1];

                foreach (var itemKey in _tempTKey)
                {
                    _keys[i] = itemKey;
                    i++;
                }
                _keys[_keys.Length - 1] = key;
                foreach (var itemValue in _tempTValue)
                {
                    _values[j] = itemValue;
                    j++;
                }
                _values[_values.Length - 1] = value;
            }

        }

        public bool ContainsKey(TKey key)
        {
            foreach (var item in _keys)
            {
                if (item.Equals(key))
                {
                    Console.WriteLine("An item with the same key has already been added");
                    return true;
                }
            }

            return false;
        }

        public int Count()
        {
            return _keys.Length;
        }

        public TValue GetValueByKey(TKey key)
        {
            KeyValuePair();
            for (int i = 0; i < _keys.Length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (key.Equals((TKey)objects[i, j]))
                    {
                        return (TValue)objects[i, j + 1];
                    }
                }
            }
            throw new Exception(key + " verisi bulunamadı.");
        }

        public void KeyValuePair()
        {
            objects = new object[_keys.Length, _values.Length];
            for (int i = 0; i < _keys.Length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    objects[i, j] = _keys[i];
                    objects[i, j + 1] = _values[i];
                }

            }
        }

    }
}