using System;
using System.Collections.Generic;
using System.Text;

namespace NetCart.ConsoleUI
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return (a + b) + c;
        }

        public string Add(string a, string b)
        {
            return a + b;
        }

        public string Add(string name, int age)
        {
            return "Employee Name=" + name + " and age is " + age;
        }

        public string Add(int age, string name)
        {
            return "Employee Name=" + name + " and age is " + age;
        }
    }

    public class MethodOverloadingDemo
    {
        public void RunDemo()
        {
            Calculator calObj = new Calculator();

            Console.WriteLine($"Add a+b= {calObj.Add(20, 30)}"); //Method 1
            Console.WriteLine($"Add a+b+c ={calObj.Add(10, 20, 30)}"); // Method 3
            Console.WriteLine(calObj.Add("Welcome ", "to C# programming")); //Method 4
            Console.WriteLine(calObj.Add("Govind ", 20)); //Method 5
            Console.WriteLine(calObj.Add( 20, "Govind ")); //Method 6




        }

    }
}
