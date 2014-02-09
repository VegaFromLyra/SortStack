using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program to sort a stack in ascending order (with biggest items on top)
// You may use additional stacks to hold items but you may not copy the elements 
// into any other data structures (such as an array). Stack supports - push, pop,
// peek and IsEmpty

//Approach 1: Use 3 stacks. 
//In the first pass, pop elements from s1 and track the minimum element in s3 using s2 to keep the remaining
//Once s1 is empty, transfer back s2 to s1
//Then repeat till s1 and s2 are empty
//s3 should have elements in sorted order

//Approach 2 : Use only 2 stacks
//Pop from s1, store it in temp
//While top of s2 is greater than temp, pop from s2 and push to s1. When done, push tmp to s2
//Repeat till s1 is empty
//s2 will be sorted
namespace SortStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(4);
            s1.Push(1);
            s1.Push(3);
            s1.Push(2);

            Stack<int> result = SortStack(s1);

            Console.WriteLine("Sorted stack is");

            while (result.Count > 0)
            {
                Console.WriteLine(result.Pop());
            }
        }

        static Stack<int> SortStack(Stack<int> input)
        { 
            Stack<int> result = new Stack<int>();

            while (input.Count > 0)
            {
                int temp = input.Pop();

                while (result.Count > 0 && result.Peek() > temp)
                {
                    input.Push(result.Pop());
                }

                result.Push(temp);
            }

            return result;
        }
    }
}
