namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack myStack1 = new Stack(2);
            myStack1.Push(1);
            myStack1.Push(2);

            Stack myStack2 = new Stack(3);
            myStack2.Push(5);
            myStack2.Push(4);
            myStack2.Push(3);



            Stack Stack3 = myStack1 + myStack2;

            Console.WriteLine("Peeked : " + Stack3[4]);
            Console.ReadLine();
        }
    }

    public class Stack
    {
        private int[] stk;
        private int top_of_stack;

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < top_of_stack)
                    return stk[index];
                else
                    throw new IndexOutOfRangeException("Index is out of range.");
            }
        }

        public Stack()
        {
            stk = new int[3];
            top_of_stack = 0;
        }

        public Stack(int size)
        {
            stk = new int[size];
            top_of_stack = 0;
        }

        public void Push(int value)
        {
            if (top_of_stack < stk.Length)
            {
                stk[top_of_stack] = value;
                top_of_stack++;
            }
            else
            {
                Console.WriteLine("Stack is Full");
            }
        }

        public int Pop()
        {
            if (top_of_stack > 0)
            {
                top_of_stack--;
                return stk[top_of_stack];
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }

        public static Stack operator +(Stack stack1, Stack stack2)
        {
            int newSize = stack1.top_of_stack + stack2.top_of_stack;
            Stack newStack = new Stack(newSize);

            for (int i = 0; i < stack1.top_of_stack; i++)
            {
                newStack.Push(stack1[i]);
            }

            for (int i = 0; i < stack2.top_of_stack; i++)
            {
                newStack.Push(stack2[i]);
            }

            return newStack;
        }


    }
}