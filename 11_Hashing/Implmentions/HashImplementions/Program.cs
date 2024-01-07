using static HashImplementions.Program;

namespace HashImplementions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hashmap = new HashMap();

            hashmap.Put("Alice", "NYC");
            hashmap.Put("Brad", "Chicago");
            hashmap.Put("Collin", "Seattle");

            hashmap.Print();
        }

        public class HashMap
        {
            int Size { get; set; }
            int Capacity { get; set; }
            Pair[] Map { get; set; }

            public HashMap()
            {
                Size = 0;
                Capacity = 2;
                Map = new Pair[2];
            }

            public void Put(string key, string val)
            {
                int index = Hash(key);

                while (true)
                {
                    if (Map[index] == null)
                    {
                        Map[index] = new Pair(key, val);
                        Size += 1;
                        if (Size >= Capacity / 2)
                        {
                            ReHash();
                        }

                        return;
                    }

                    if (Map[index].Key == key)
                    {
                        Map[index].Val = val;

                        return;
                    }

                    index += 1;
                    index %= Capacity;
                }
            }

            public string Get(string key)
            {
                int index = Hash(key);
                while (Map[index] != null)
                {
                    if (Map[index].Key == key)
                    {
                        return Map[index].Val;
                    }
                    index += 1;
                    index %= Capacity;
                }

                return string.Empty;
            }

            public void Remove(string key)
            {
                if (Get(key) == null)
                {
                    return;
                }

                int index = Hash(key);
                while (true)
                {
                    if (Map[index].Key == key)
                    {
                        // Removing an element using open-addressing actually causes a bug,
                        // because we may create a hole in the list, and our get() may
                        // stop searching early when it reaches this hole.
                        Map[index] = null;
                        Size -= 1;
                        return;
                    }
                    index += 1;
                    index %= Capacity;
                }
            }

            public void Print()
            {
                foreach (Pair p in Map)
                {
                    if (p is not null)
                    {
                        Console.WriteLine(p.Key + " " + p.Val);
                    }
                }
            }

            private int Hash(string key)
            {
                int index = 0;
                for (int i = 0; i < key.Length; i++)
                {
                    index += key[i];
                }

                return index % Capacity;
            }

            public void ReHash()
            {
                Capacity = 2 * Capacity;
                Pair[] newMap = new Pair[Capacity];

                Pair[] oldMap = Map;
                Map = newMap;
                Size = 0;
                foreach (Pair p in oldMap)
                {
                    if (p != null)
                    {
                        Put(p.Key, p.Val);
                    }
                }
            }
        }

        public class Pair
        {
            public string Key { get; set; }
            public string Val { get; set; }

            public Pair(string key, string val)
            {
                Key = key;
                Val = val;
            }
        }
    }
}
