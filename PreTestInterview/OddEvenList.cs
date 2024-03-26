namespace PreTestInterview
{
    internal class OddEvenList<T>
    {
        private List<T> list;
        private Random random;

        public OddEvenList()
        {
            list = new List<T>();
            random = new Random();
        }

        public int Add(T input)
        {
            list.Add(input);
            return list.Count - 1;
        }

        public bool Remove(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
                return true;
            }
            return false;
        }

        public T[] GetOdd()
        {
            List<T> oddList = new List<T>();
            for (int i = 0; i < list.Count; i += 2)
            {
                oddList.Add(list[i]);
            }
            return oddList.ToArray();
        }

        public T[] GetEven()
        {
            List<T> evenList = new List<T>();
            for (int i = 1; i < list.Count; i += 2)
            {
                evenList.Add(list[i]);
            }
            return evenList.ToArray();
        }

        public T[] GetRandom()
        {
            List<T> randomList = new List<T>(list);
            for (int i = 0; i < randomList.Count; i++)
            {
                int swapIndex = random.Next(randomList.Count);
                T temp = randomList[i];
                randomList[i] = randomList[swapIndex];
                randomList[swapIndex] = temp;
            }
            return randomList.ToArray();
        }
    }
}
