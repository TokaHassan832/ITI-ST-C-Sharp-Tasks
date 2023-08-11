namespace Generic_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            Console.WriteLine(intStack.Pop());


            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("Toka");
            stringStack.Push("Hassan");
            Console.WriteLine(stringStack.Peek());
        }
    }

    public class Stack<T>
    {
        private List<T> items = new List<T>();

        public bool IsEmpty
        {
            get { return items.Count == 0; }
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                int lastIndex = items.Count - 1;
                T item = items[lastIndex];
                items.RemoveAt(lastIndex);
                return item;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public T Peek()
        {
            if (!IsEmpty)
            {
                return items[items.Count - 1];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public int Size()
        {
            return items.Count;
        }
    }
}