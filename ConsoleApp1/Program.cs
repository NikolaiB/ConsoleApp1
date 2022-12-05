using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          bool a0, a1 = true, b1 = false; 

          //Binary Operators

          //System.Console.WriteLine(a1+b1); // Error. Also for other operators "-", "/", "*" 
          //System.Console.WriteLine(a1 % b1); // Error. 
          //System.Console.WriteLine(a1++); // Error. Also for other "--"

          // Logical operators

          System.Console.WriteLine( "bool", a1 == b1);
          System.Console.WriteLine( "bool1", a1 & b1); 
          System.Console.WriteLine(a1 | b1); 
          System.Console.WriteLine(a1 ^ b1); 
          System.Console.WriteLine(a1 != b1 ); 
          
          

         byte a2 = 5, b2 = 10; 
         
         System.Console.WriteLine(a2+b2);
         System.Console.WriteLine(++a2); 
         System.Console.WriteLine( a2 == b2 ); 
         System.Console.WriteLine(a2!=b2);

         sbyte a3 = 5, b3 = 10; 
         
         System.Console.WriteLine(a3+b3); 
         System.Console.WriteLine(a3++);
         System.Console.WriteLine( a3==b3);

         short a4 = 5, b4 = 10;  

         System.Console.WriteLine(a4+b4); 
         System.Console.WriteLine(a4++);

         ushort a5 = 5, b5 = 10;  
         
         System.Console.WriteLine(a5+b5); 
         System.Console.WriteLine(a5++);

         int a7 = 5, b7 = 10;  
         
         System.Console.WriteLine(a7+b7); 
         System.Console.WriteLine(a7++);

         uint a8 = 5, b8 = 10;  
         
         System.Console.WriteLine(a8+b8);
         System.Console.WriteLine(a8++);

         long a9 = 5, b9 = 10;  
         
         System.Console.WriteLine(a9+b9); 
         System.Console.WriteLine(a9++);

         ulong a10 = 10 , b10 = 5;  
         
         System.Console.WriteLine(a10+b10); 
         System.Console.WriteLine(a10++);

         double a11 = 5, b11 = 10;  

         System.Console.WriteLine(a11+b11); 
         System.Console.WriteLine(a11++);
         
         float a12 = 5, b12 = 10;  
         
         System.Console.WriteLine(a12+b12); 
         System.Console.WriteLine(a12++);

        //char = A, b13 = 10;  System.Console.WriteLine(a3+b3); System.Console.WriteLine(a3++);


        }
    }
}
