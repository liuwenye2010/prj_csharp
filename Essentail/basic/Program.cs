 
#define TEST_YES
//#define TEST_NO

#if (TEST_NO)
using System;//Show the delegate 
namespace ReturnValues { // Illustrated C# 7 Fifth Edition page 361 
    delegate int MyDel(); // Declare delegate with return value. 
    class MyClass { 
        private int IntValue = 5; 
        public int Add2() { IntValue += 2; return IntValue; } 
        public int Add3() { IntValue += 3; return IntValue; } } 
        class Program { 
            static void Main() { 
            MyClass mc = new MyClass(); 
            MyDel mDel = mc.Add2; // Create initialize delegate. 
            mDel += mc.Add3; // Add a method. mDel += mc.Add2; // Add a method. 
            Console.WriteLine($"Value: { mDel() }"); // output 12 
#if DEBUG
    Console.WriteLine("Here");
#endif
            } 
        } 
}
#endif 


#if (TEST_NO)
using System; 
using System.Collections.Generic; 
namespace Generics { 
    public class Customer 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }     
    class Program 
    { 
        static void Main(string[] args) 
        { 
            List<Customer> myCustomers = new List<Customer>(); //empty 
            myCustomers.Add(new Customer() { Id = 1, Name = "Jack" }); 
            myCustomers.Add(new Customer() { Id = 2, Name = "Jill" }); 
            foreach (Customer cust in myCustomers) 
                { 
                    Console.WriteLine(cust.Name); 
                } 
        } 
    } 
}

#endif

#if (TEST_YES)
using System;
namespace Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 50;
            int c = a + b;

            Type myType = typeof(Program); 
            Console.Title = myType.Namespace; 
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WindowWidth = 180; // max might be 213 (180 is very wide)
            Console.WriteLine(c);
            Console.WriteLine("Hello:Comandline CS to Exe with csc!");
            //array example
            int[] numArray = { 7, 2, 3 }; 
            int[] numArray2 = new int[3]; // default value is 0 // below is 3 rows and 2 columns 
            int[,] numArray3 = { { 1, 2 }, { 3, 4 }, { 5, 6 } }; 
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' }; 
            char[] vowels2 = { 'a', 'e', 'i', 'o', 'u' }; // simplified 
            Array.Sort(numArray); 
            foreach (int n in numArray) 
            { 
                Console.Write(n); 
            } // 237 
            Console.WriteLine("\nFirst element is: " + numArray[0]);

        }
    }
}
#endif 


