using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //declares variables to work with 
            int param1;
            int param2;
            string operation;
            string[] restart = new string[] { "" };
            //welcome
            Console.WriteLine("welcome to my calculator!");
            //request user input and store int value into param1
            Console.WriteLine("Please select your first number: ");
            param1 = Convert.ToInt32(Console.ReadLine());
            //request second number and store to param 2
            Console.WriteLine("Please select your second number");
            param2 = Convert.ToInt32(Console.ReadLine());
            //request and store operation type
            Console.Write("now, select your operation (+ , - , x , /)");
            operation = Console.ReadLine();
            //if statement selecting which method to use based on operation string value
            if (operation == "x")
            {
                Console.WriteLine($"your anwser is : {Mult(param1, param2)}");
            }
            if (operation == "/")
            {
                Console.WriteLine($"your answer is: {Divide(param1, param2)}");
            }
            if (operation == "+")
            {
                Console.WriteLine($"your answer is: {Add(param1, param2)}");
            }
            if (operation == "-")
            {
                Console.WriteLine($"your answer is: {Subtract(param1, param2)}");
            }
            Console.ReadLine();
            Console.WriteLine("to do another calculation please type : \"Restart\" ");
            restart[0] = Console.ReadLine();
            if (restart[0] == "Restart")
            {
                Main(restart);
            }
        }
        public static int Mult(int param1, int param2)
        {
            int ans;
            ans = param1 * param2;
            return ans;
        }
        public static int Divide(int param1, int param2)
        {
            int ans;
            ans = param1 / param2;
            return ans;
        }
        public static int Add(int param1, int param2)
        {
            int ans;
            ans = param1 + param2;
            return ans;
        }
        public static int Subtract(int param1, int param2)
        {
            int ans;
            ans = param1 - param2;
            return ans;
        }
    }
}
