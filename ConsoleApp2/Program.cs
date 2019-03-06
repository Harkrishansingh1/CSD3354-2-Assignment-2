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
    class program
    {
        static void Main(string[] args)
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
        }

    }

    public class DelegateExercises
    {
       
        public delegate int MyDelegate();
        void Method1()
        {
            System.Console.WriteLine("MyDelegate");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
        
            
        


    }

}







