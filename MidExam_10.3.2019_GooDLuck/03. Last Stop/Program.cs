using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ').ToList();
            string[] givenCommand = Console.ReadLine().Split(' ').ToArray();

            while (givenCommand[0]!="END")
            {
                //Change 73 70  ->  Change {paintingNumber} {changedNumber}                 
                
                if (givenCommand[0]== "Change")
                {
                    if (numbers.Contains(givenCommand[1]))
                    {
                        int index = numbers.IndexOf(givenCommand[1]);
                        numbers[index] = givenCommand[2];
                    }
                }
                //Hide 75   ->	Hide {paintingNumber} 
                else if (givenCommand[0]=="Hide")
                {
                    if (numbers.Contains(givenCommand[1]))
                    {
                        numbers.Remove(givenCommand[1]);
                    }
                }
                //Switch 116 73  ->	Switch {paintingNumber} {paintingNumber2}  
                //find the given paintings in the collections if they exist and switch their places.
                else if (givenCommand[0]=="Switch")
                {
                    if (numbers.Contains(givenCommand[1]) && numbers.Contains(givenCommand[2]))
                    {
                        // 0   1   2   3    4   5    6   7
                        //115 115 101 114 <73> 111 <116> 75
                        //115 115 101 114 <116> 111 <73> 75

                        int index1 = numbers.IndexOf(givenCommand[1]);
                        string numberForSwap1 = numbers[index1];
                        int index2 = numbers.IndexOf(givenCommand[2]);
                        string numberForSwap2 = numbers[index2];
                        numbers[index1] = numberForSwap2;
                        numbers[index2] = numberForSwap1;
                    }
                }
                //Insert 5 114
                //-	Insert {place} {paintingNumber} – 
                //insert the painting (paintingNumber) on the next place after the given one, if it exists.
                else if (givenCommand[0]=="Insert")
                {
                    int index = int.Parse(givenCommand[1]);
                    if (index <= numbers.Count )
                    {
                        int newIndex = index + 1;
                        string numberForInput = givenCommand[2];
                        numbers.Insert(newIndex, numberForInput);
                    }
                }
                else if (givenCommand[0]== "Reverse")
                {
                    numbers.Reverse();
                }
                givenCommand = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(' ',numbers));
        }
    }
}
