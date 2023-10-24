// Amos Rains, Methods Parameters, v0.2
using System;

namespace MethodsParameters
{
    class MethodsParameters
    {
        // METHOD -- named block of code, can be used over and over. 
        // All methods have a SIGNATURE  that defines their name, parameters, and output. 
        // Example signature
        static void myMethod()
        {
            Console.WriteLine("I like mine with peperoni, olives, and lots of cheese.\n");
        }
        // static -- This method belongs to the current class, it is not a object.
        // void -- This method has no return value. 

        static int DoubleUp()
        {
            int sum = 0; 
            Console.WriteLine("This method will double a number and return it.\n");
            Console.WriteLine("Please enther a number on the next line.\n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            //sum = sum * 2;
            //Console.WriteLine(sum);
            return sum;
        }

        // Methods with Parameters
        
        static void MakePancakes(int num)
        {
            for (int i = 0; i < num; i++) 
            {
                Console.WriteLine("One golden, fluffy pancake coming up!\n");
            }
        }


        static void Main(string[] args)
        {
            //myMethod();
            //DoubleUp();
            MakePancakes(10);
        }
    }   
}
