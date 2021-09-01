using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    


    class Game
    {
        


        public void Run()
        {

            int num1 = 1;
            int num2 = 20;
            // calculations for add,sub,multi,div
            void AdditonCalc( float num1, float num2)
            {
                Console.WriteLine(num1 + num2);
            }
            void SubtractionCalc(float num1, float num2)
            {
                Console.WriteLine(num1 - num2);
            }
            void MultiplyCalc(float num1, float num2)
            {
                Console.WriteLine(num1 * num2);
            }
            void DivideCalc(float num1, float num2)
            {
                Console.WriteLine(num1 / num2);
            }






            string input = Console.ReadLine();

            float inputValue;


            if (float.TryParse(input, out inputValue))
            {
              
            }
            AdditonCalc(1, 18);

            SubtractionCalc(10, 6);

            MultiplyCalc(10, 9);

            DivideCalc(35, 5);


            int inputrecieved = 0;
            
            string playerinput = "";

            Console.WriteLine("Calculator");
            Console.WriteLine();
            Console.WriteLine("What you would like to calculate");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.WriteLine("> ");
            while (!(inputrecieved == 1 || inputrecieved == 2 || inputrecieved == 3 || inputrecieved == 4))
            {
                
                playerinput = Console.ReadLine();
                if (playerinput == "1")
                {
                    Console.WriteLine("you chose addition");
                    Console.ReadLine();
                    Console.Clear();
                    
                    
                    if (float.TryParse(input, out inputValue))
                    {
                        
                    }
                }
                else if (playerinput == "2")
                {
                    Console.WriteLine("you chose subtract");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (playerinput == "3")
                {
                    Console.WriteLine("you chose multiplication");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (playerinput == "4")
                {
                    Console.WriteLine("you chose division");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
                
                
                  
                
                

            }
            

            
            

            

            
            



        }
    }
}
