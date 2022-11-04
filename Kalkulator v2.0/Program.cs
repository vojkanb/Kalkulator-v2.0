using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{








    internal class Program
    {


        static int Addition(int first, int second)

        {

            return first + second;

        }


        static int Subtraction(int first, int second)

        {

            return first - second;

        }




        static int Multiplication(int first, int second)

        {

            return first * second;

        }


     
        static int Devision(int first, int second)

        {
              
                return first / second;
                

        }



        static void Main(string[] args)
        {




            Console.WriteLine("Enter two numbers");

            string firststr = Console.ReadLine();


            Console.WriteLine("Enter the second number");

            string secondstr = Console.ReadLine();


            try
            {
                

                int first = int.Parse(firststr);  
                int second = int.Parse(secondstr);


                Console.WriteLine("");
                Console.WriteLine("");




                Console.WriteLine("Addition: ");
                Console.WriteLine(Addition(first, second));
                Console.WriteLine("");


                Console.WriteLine("Subtraction: ");
                Console.WriteLine(Subtraction(first, second));
                Console.WriteLine("");



                Console.WriteLine("");
                Console.WriteLine("Multiplication: ");
                Console.WriteLine(Multiplication(first, second));


                Console.WriteLine("");
                Console.WriteLine("Devision: ");
                Console.WriteLine(Devision(first, second));
            }




            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);

            }


        
     



            catch (FormatException )
            {
                if (firststr.Length == 0 || secondstr.Length == 0)
                {

                    Console.WriteLine("You must type a value in");


                }

                else {

                    Console.WriteLine("You must input a number");
                
                }
         
                
            }



            Console.ReadKey();
            
            
        }
    }
}


