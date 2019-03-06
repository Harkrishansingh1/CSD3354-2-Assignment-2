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
            a.Method2();
        }

    }

    public class DelegateExercises
    {
        //student Name -Harkrishan Singh Student ID C0732442
        //Studnt Name- Jatinder Singh student ID C0727454
        //CSD3354 Section 2
        //Assignment 2
        // March 6,2019
        public delegate void MyDelegate();
        void Method1(int i)
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate mydelegate = new MyDelegate(Method1);
            mydelegate();
        }


    }

}







