using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define variables:
            int numbers, divisor, flag;

            //to find the numbers wanted has 3 digits and starting with 5.
            //indicates an interval between 500-600.
            //we use for loop to get the numbers in this interval
            for (numbers = 500; numbers < 600; numbers++)
            {
                //flag is the check point. If it is 1 then the number is prime!
                flag = 1;
                //in order to skip the 0 and 1 values, start the initial div. value from 2.
                //it will be enough to control half value of the number
                //
                for (divisor = 2; divisor <= (numbers / 2); divisor++)
                {
                    //If the numbers divisible by divisor without remainder except itself,
                    //it means they are not prime!
                    if (numbers % divisor == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    //if the statement is true, print the numbers to console!
                    Console.WriteLine(numbers);
                }

            }

        }
    }
}
