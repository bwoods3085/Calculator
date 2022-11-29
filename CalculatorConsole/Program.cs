namespace CalculatorConsole
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            int input1 = 0, input2 = 0;
            string operator1 = " ";
            Console.WriteLine("Enter first number");
            //char inputChar = Console.ReadKey(true).KeyChar;
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operator:\n-, +, *, /");
            operator1 = Console.ReadKey(true).KeyChar.ToString();
            Console.WriteLine("Enter second Number");
            input2 = Convert.ToInt32(Console.ReadLine());

            //Expected operators are: -, +, *, /
            double storedResult = 0;


            switch (operator1)
            {
                case "-":
                    storedResult = Subtract(input1, input2);
                    break;
                case "+":
                    storedResult = Addition(input1, input2);
                    break;
                case "*":
                    storedResult = Multiply(input1, input2);
                    break;
                case "/":
                    storedResult = Division(input1, input2);
                    break;                
            }
                        
            Console.WriteLine($"{input1} {operator1} {input2} = {storedResult}");

        }

        /// <summary>
        /// This subtracts two numbers
        /// </summary>
        /// <param name="input1">Operand1</param>
        /// <param name="input2">Operand2</param>
        /// <returns>A double type result of operand1 - operand2</returns>
        static double Subtract(int input1, int input2)
        {
            return input1 - input2;
        }

        static double Addition(int input1, int input2)
        {
            return input1 + input2;
        }

        static double Multiply(int input1, int input2)
        {
            return input1 * input2;
        }

        static double Division(int input1, int input2)
        {
            return input1 / input2;
        }
    }
}