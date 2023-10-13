using static hashmap_lef_join.Program;

namespace hashmap_lef_join
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public class HashNode<TKey, TValue>
        {
            public TKey Key { get; set; }
            public IList<TValue> Value { get; set; }

            public HashNode(TKey key, TValue value)
            {
                Key = key;
                Value = new List<TValue> { value };
            }
        }
    }
    public class HashMap<TKey, TValue>
    {

       
        public LinkedList<HashNode<TKey, TValue>>[] map { get; set; }

       

        public HashMap(int size)
        {
            map = new LinkedList<HashNode<TKey, TValue>>[size];
        }

        private int Hash(TKey key)
        {
            int hashValue = 0;

            char[] letters = key.ToString().ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                hashValue += letters[i];
            }

            return hashValue % map.Length;
        }

        public void Set(TKey key, TValue value)
        {
            int hashKey = Hash(key);

            if (map[hashKey] == null)
            {
                map[hashKey] = new LinkedList<HashNode<TKey, TValue>>();
            }

            foreach (var entry in map[hashKey])
            {
                if (entry.Key.Equals(key))
                {
                    entry.Value.Add(value);
                    return;
                }
            }

            map[hashKey].AddLast(new HashNode<TKey, TValue>(key, value));
        }

        public bool Has(TKey key)
        {
            int hashKey = Hash(key);

            if (map[hashKey] != null)
            {
                foreach (var entry in map[hashKey])
                {
                    if (entry.Key.Equals(key))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public IEnumerable<TKey> Keys()
        {
            List<TKey> keys = new List<TKey>();

            foreach (var bucket in map)
            {
                if (bucket != null)
                {
                    foreach (var entry in bucket)
                    {
                        keys.Add(entry.Key);
                    }
                }
            }

            return keys;
        }

        public IEnumerable<TValue> Get(TKey key)
        {
            int hashKey = Hash(key);
            List<TValue> values = new List<TValue>();

            if (map[hashKey] != null)
            {
                foreach (var entry in map[hashKey])
                {
                    if (entry.Key.Equals(key))
                    {
                        values.AddRange(entry.Value);
                    }
                }
            }

            if (values.Count == 0)
            {
                throw new KeyNotFoundException($"Key '{key}' not found in the hashtable.");
            }

            return values;
        }

        public int HashIndex(TKey key)
        {
            return Hash(key);
        }

        public void Print()
        {
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] != null)
                {
                    foreach (var node in map[i])
                    {
                        Console.WriteLine( node.Key +"  "+node.Value);
                    }
                }
            }
        }
        public List<List<string>> LeftJoin(HashMap<string, string> map1, HashMap<string, string> map2)
        {
            List<List<string>> list = new List<List<string>>();
            for (int i = 0; i < map1.map.Length; i++)
            {
                List<string> list2 = new List<string>();
                if (map1.map[i] != null)
                {
                    foreach (var node in map1.map[i])
                    {
                        list2.Add(node.Key);
                        list2.Add(node.Value.FirstOrDefault());
                        if (map2.Has(node.Key))
                        {
                            var x = map2.Get(node.Key);
                            if (x != null)
                                list2.Add(x.FirstOrDefault().ToString());
                        }
                        else
                        {
                            list2.Add(null);
                        }

                    }
                }
                if (list2.Count > 0)
                    list.Add(list2);
            }
            return list;
        }
    }
}