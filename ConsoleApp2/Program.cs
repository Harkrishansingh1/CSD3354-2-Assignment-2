using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
//student Name -Harkrishan Singh Student ID C0732442
//Studnt Name- Jatinder Singh student ID C0727454
//CSD3354 section 2
//Assignment 2
// March 6,2019
{
    using System;
    delegate void ExampleDelegate(String xyz);
    class program
    {
        public static void Method1(string xyz)
        {
            Console.WriteLine(xyz + "Method1");
        }
        public static void Method2(string xyz)
        {
            Console.WriteLine(xyz + "Method2");
        }
        public static void Main()
        {
            ex1Delegate = new ExampleDelegate(Method1);
            ex1Delegate = new ExampleDelegate(Method2);
            ex3Delegate = ex1Delegate + ex2Delegate;
            myDelegate = ex1Delegate + ex2Delegate;
            ex1Delegate("aaa");
            ex2Delegate("bbb");
            ex3Delegate("ccc");
            myDelegate = ex1Delegate - ex2Delegate;
            myDelegate("eee");
            myDelegate = ex1Delegate - ex2Delegate
            myDelegate("fff");
            Console.ReadLine();
        }
    }
   

}









