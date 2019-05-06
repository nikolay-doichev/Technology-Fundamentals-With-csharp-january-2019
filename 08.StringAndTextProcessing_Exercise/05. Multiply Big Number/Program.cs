using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart('0');
            if (firstNumber==string.Empty || firstNumber==null)
            {
                firstNumber="0";
            }
            int secondNumber = int.Parse(Console.ReadLine());
            int multyplaid = 0;
            StringBuilder multyplieldNumber = new StringBuilder();

            for (int index = firstNumber.Length-1; index >= 0; index--)
            {
                //119   //9   //1071                
                int firstDigit = (int)char.GetNumericValue(firstNumber[index]);               
                if (secondNumber == 0)
                {
                    Console.WriteLine("0");
                    return;
                }
                multyplaid += firstDigit * secondNumber;
                if (multyplaid>9)
                {                    
                    int rest = multyplaid % 10;
                    if (index == 0)
                    {
                        multyplieldNumber.Insert(0, multyplaid);
                        break;
                    }
                    multyplieldNumber.Insert(0,rest);
                    multyplaid/=10;                    
                }
                //23    //2
                else
                {
                    multyplieldNumber.Insert(0, multyplaid);
                    multyplaid = 0;
                }
            }
            Console.WriteLine(multyplieldNumber);
        }
    }
}
