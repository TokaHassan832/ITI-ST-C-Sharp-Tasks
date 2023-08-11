namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");
            int numStudents = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of subjects: ");
            int numSubjects = int.Parse(Console.ReadLine());

            int[,] marks = new int[numStudents, numSubjects];

            // Get the marks for each student and subject
            for (int i = 0; i < numStudents; i++)
            {
                for (int j = 0; j < numSubjects; j++)
                {
                    Console.Write($"Enter marks for Student {i + 1}, Subject {j + 1}: ");
                    marks[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Calculate the sum of marks for each student
            int[] sumOfMarks = new int[numStudents];
            for (int i = 0; i < numStudents; i++)
            {
                for (int j = 0; j < numSubjects; j++)
                {
                    sumOfMarks[i] += marks[i, j];
                }
            }

            // Calculate the average for each subject
            double[] averageOfSubjects = new double[numSubjects];
            for (int j = 0; j < numSubjects; j++)
            {
                double sum = 0;
                for (int i = 0; i < numStudents; i++)
                {
                    sum += marks[i, j];
                }
                averageOfSubjects[j] = sum / numStudents;
            }

            // Display the results
            Console.WriteLine("Sum of marks for each student:");
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Student {i + 1}: {sumOfMarks[i]}");
            }

            Console.WriteLine("Average marks for each subject:");
            for (int j = 0; j < numSubjects; j++)
            {
                Console.WriteLine($"Subject {j + 1}: {averageOfSubjects[j]:0.00}");
            }
            Console.ReadLine();
        }
    }
}