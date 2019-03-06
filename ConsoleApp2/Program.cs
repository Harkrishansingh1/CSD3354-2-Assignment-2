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
  
    public class program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }

    }
    public delegate void MyDelegate();

    public class DelegateExercises
    {
       
        
        void Method1()
        {
            System.Console.WriteLine("Method1");
        }
       public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }

        
         
        


    }

}







