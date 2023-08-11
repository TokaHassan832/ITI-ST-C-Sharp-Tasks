namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operation equation (e.g., 5 + 3):");
            string equation = Console.ReadLine();

            try
            {
                int result = CalculateEquation(equation);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();


            static int CalculateEquation(string equation)
            {
                // Remove any whitespace from the equation
                equation = equation.Replace(" ", "");

                // Find the operator using Contains method
                char[] operators = { '+', '-', '*', '/' };
                int operatorIndex = -1;
                foreach (char op in operators)
                {
                    if (equation.Contains(op))
                    {
                        operatorIndex = equation.IndexOf(op);
                        break;
                    }
                }

                if (operatorIndex == -1)
                {
                    throw new ArgumentException("Invalid equation format. Please use one of the operators +, -, *, or /");
                }

                // Split the equation into operand1, operator, and operand2 using Split method
                string[] operands = equation.Split(operators, StringSplitOptions.RemoveEmptyEntries);
                if (operands.Length != 2)
                {
                    throw new ArgumentException("Invalid equation format. Please provide exactly two operands.");
                }

                int operand1 = int.Parse(operands[0]);
                int operand2 = int.Parse(operands[1]);
                char @operator = equation[operatorIndex];

                // Perform the operation
                switch (@operator)
                {
                    case '+':
                        return operand1 + operand2;
                    case '-':
                        return operand1 - operand2;
                    case '*':
                        return operand1 * operand2;
                    case '/':
                        if (operand2 == 0)
                        {
                            throw new DivideByZeroException("Cannot divide by zero.");
                        }
                        return operand1 / operand2;
                    default:
                        throw new ArgumentException("Invalid operator. Please use one of the operators +, -, *, or /");
                }
            }
        }
    }
}