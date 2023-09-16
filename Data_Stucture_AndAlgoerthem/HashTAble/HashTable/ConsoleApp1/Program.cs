using System.ComponentModel;

namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
 
        public class Hashtable
        {
            public class KeyValue
            {
                public string Key { get; set; }
                public object Value { get; set; }
            }


            public const int Size = 70;
            public List<List<KeyValue>> table;

            public Hashtable()
            {
                table = new List<List<KeyValue>>(Size);
                for (int i = 0; i < Size; i++)
                {
                    table.Add(new List<KeyValue>());
                }
            }

            public int CalculateHash(string key)
            {
                int hash = 0;
                foreach (char x in key)
                {
                    hash =hash+ x;
                }
                return hash % Size;
            }
        public object Get(string key)
        {
            int index = CalculateHash(key);
            List<KeyValue> bucket = table[index];

            foreach (var x in bucket)
            {
                if (x.Key == key)
                {
                    return x.Value;
                }
            }

            return null;
        }
        public void Set(string key, object value)
            {
                int index = CalculateHash(key);
                List<KeyValue> bucket = table[index];

                foreach (var x in bucket)
                {
                    if (x.Key == key)
                    {
                        x.Value = value;
                        return;
                    }
                }

                bucket.Add(new KeyValue { Key = key, Value = value });
            }

           

        public List<string> Keys()
        {
            List<string> keys = new List<string>();

            foreach (var x in table)
            {
                foreach (var y in x)
                {
                    keys.Add(y.Key);
                }
            }

            return keys;
        }
        public bool Has(string key)
            {
                int index = CalculateHash(key);
                List<KeyValue> bucket = table[index];

                foreach (var x in bucket)
                {
                    if (x.Key == key)
                    {
                        return true;
                    }
                }

                return false;
            }

            
        }
    }

  