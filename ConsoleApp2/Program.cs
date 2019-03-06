using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class program
    {
        static void Main(string[] args)
        {
            DelegateExercises a = new DelegateExercises();
            a.Method3();
            Console.ReadLine();
        }

    }

    public class DelegateExercises
    {
        //student Name -Harkrishan Singh Student ID C0732442
        //Studnt Name- Jatinder Singh student ID C0727454
        //CSD3354 Section 2
        //Assignment 2
        // March 6,2019
        public delegate int MyDelegate(int intValue);
        public int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }     
        public int Method2(int intMethod2)
        {
            return intMethod2 * 10;
        }
        public void Method3()
        {
            MyDelegate mydelegate = new MyDelegate(Method1);
            int result1 = mydelegate(10);
            System.Console.WriteLine(result1);
            mydelegate = new MyDelegate(Method2);
            int result2 = mydelegate(10);
            System.Console.WriteLine(result2);
            
        }


    }

}







