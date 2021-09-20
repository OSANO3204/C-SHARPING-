using System;

namespace AddTwoNumbers
{

    class AddTwoNumbersClass
    {
        static void Main()
        {
            AddTwoNumbersClass GetTheResult = new AddTwoNumbersClass();
        
                var UpdatedValue = GetTheResult.AddTwoNumbersFunction();
     
            Console.WriteLine();
        }

        public int AddTwoNumbersFunction()
        {
            Console.WriteLine("Enter two numbers :");
            int num1 = int.Parse(Console.ReadLine());
            int numb2 =int.Parse( Console.ReadLine());
            int sum = num1 + numb2;
            Console.WriteLine("The sum of the two numbers is: " + sum);

            return sum;

        }
    }

}