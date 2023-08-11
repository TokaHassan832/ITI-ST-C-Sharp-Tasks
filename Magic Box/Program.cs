namespace Magic_Box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 1;
            int size = 3;
            int col = (size / 2) + 1;
            int colDistance = Console.WindowWidth / (size + 1);
            int rowDistance = Console.WindowHeight / (size + 1);

            for (int i = 1; i <= size * size; i++)
            {
                Console.SetCursorPosition(col * colDistance, row * rowDistance);
                Console.Write(i);

                if (i % size == 0)
                {
                    row++;
                    if (row > size)
                        row = 1;
                }
                else
                {
                    row--;
                    col--;
                    if (row < 1)
                        row = size;
                    if (col < 1)
                        col = size;
                }

            }
            Console.ReadLine();
        }
    }
}