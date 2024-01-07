namespace _1_Heap
{
    public class Heap
    {
        List<int> heap;

        public Heap()
        {
            heap = new List<int> { 0 };
        }

        public void Push(int val)
        {
            heap.Add(val);
            int i = heap.Count - 1;

            while (i > 1 && heap[i] < heap[i / 2])
            {
                int tmp = heap[i];
                heap[i] = heap[i / 2];
                heap[i / 2] = tmp;
                i /= 2;
            }
        }

        public int? Pop()
        {
            if (heap.Count == 1)
            {
                return null;
            }

            int res;
            if (heap.Count == 2)
            {
                res = heap[^1];
                heap.Remove(heap.Count - 1);
                return res;
            }

            res = heap[1];
            heap[1] = heap[^1];
            heap.RemoveAt(heap.Count - 1);
            int i = 1;
            
            while (2 * i < heap.Count)
            {
                if (2 * i + 1 < heap.Count &&
                    heap[2 * i + 1] < heap[2 * i] &&
                    heap[i] > heap[2 * i + 1])
                {
                    int tmp = heap[i];
                    heap[i] = heap[2 * i + 1];
                    heap[2 * i + 1] = tmp;
                    i = 2 * i + 1;
                }
                else if (heap[i] > heap[2 * i])
                {
                    int tmp = heap[i];
                    heap[i] = heap[2 * i];
                    heap[2 * i] = tmp;
                    i = 2 * i;
                }
                else
                {
                    break;
                }
            }

            return res;
        }

        public void Heapify(List<int> arr)
        {
            arr.Add(arr[0]);
            heap = arr;

            for (int cur = (heap.Count - 1) / 2; cur > 0; cur--)
            {
                int i = cur;
                while (2 * i < heap.Count)
                {
                    if (2 * i + 1 < heap.Count &&
                        heap[2 * i + 1] < heap[2 * i] &&
                        heap[i] > heap[2 * i + 1])
                    {
                        int tmp = heap[i];
                        heap[i] = heap[2 * i + 1];
                        heap[2 * i + 1] = tmp;
                        i = 2 * i + 1;
                    }
                    else if (heap[i] > heap[2 * i])
                    {
                        int tmp = heap[i];
                        heap[i] = heap[2 * i];
                        heap[2 * i] = tmp;
                        i = 2 * i;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}