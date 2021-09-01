using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Game
    {
        
        float result;
        bool notFinished = false;
        string input = " ";

        //setting up the first number
        float FirstSlection()
        {
            bool invaildInput = false;
            while (invaildInput == false)
            {
                Console.WriteLine("Please enter your first number");
                string num1 = Console.ReadLine();

                if (Single.TryParse(num1, out float result))
                {
                    invaildInput = true;
                    Console.Clear();
                    return result;
                }

                else; 
                {
                    Console.WriteLine("Invaild input recieved. Please type a number.");
                }
            }
            return 0;
        }
        //setting up the second number 
        float SecondSlection()
        {
            bool invaildInput = false;
            while (invaildInput == false)
            {
                Console.WriteLine("Please enter your Second number");
                string num2 = Console.ReadLine();

                if (Single.TryParse(num2, out float result))
                {
                    invaildInput = true;
                    Console.Clear();
                    return result;
                }

                else;
                {
                    Console.WriteLine("Invaild input recieved. Please type a number.");
                }
            }
            return 0;
        }
        /// <summary>
        /// the operation connect each soluction to the numbers and vice versa 
        /// </summary>
        void operations()
        {
            float num1 = FirstSlection();
            float num2 = SecondSlection();
            //the slection to choose whta you want to do to the numbers
           
            bool invaildInput = false;
            while (invaildInput == false)
            {
                Console.WriteLine(" 1. Addition" + "\n 2. Subtraction" + "\n 3. Muliplication" + "\n 4. Division");
                string input = Console.ReadLine();

                if (input == "1" || input.ToLower() == "addition")
                {
                    result = Add(num1, num2);
                    Console.Clear();
                    Console.WriteLine("Your answer is");
                    Console.WriteLine(result);
                    invaildInput = true;
                }

               else if (input == "2" || input.ToLower() == "subtraction")
                {
                    result = Substract(num1, num2);
                    Console.Clear();
                    Console.WriteLine("Your answer is");
                    Console.WriteLine(result);
                    invaildInput = true;
                }

                else if (input == "3" || input.ToLower() == "multiplication")
                {
                    result = Multiplty(num1, num2);
                    Console.Clear();
                    Console.WriteLine("Your answer is");
                    Console.WriteLine(result);
                    invaildInput = true;
                }

                else if (input == "4" || input.ToLower() == "division")
                {
                    result = Divide(num1, num2);
                    Console.Clear();
                    Console.WriteLine("Your answer is");
                    Console.WriteLine(result);
                    invaildInput = true;
                }

                else
                {
                    Console.WriteLine("Invaild input recieved. Please type a number.");
                    
                }

            }
            
        }
        //after you say yes yoyu restart at the begining 
        void ClearScreen()
        {
            Console.WriteLine("Press any key to continue.");
            string input = Console.ReadLine();
            Console.Clear();
        }

        //how to use tryparse but i threw the idea away
        void CalculateNumber()
        {
            float inputValue;
            string input = "";
            input = Console.ReadLine();
            if (!float.TryParse(input, out inputValue)) ;
            {

            }

        }
        ///connected each operator to first and second numbers
        float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        float Substract(float num1, float num2)
        {
            return num1 - num2;
        }

        float Multiplty(float num1, float num2)
        {
            return num1 * num2;
        }

        float Divide(float num1, float num2)
        {
            return num1 / num2;
        }

        
        public void Run()
        {
            bool notFinished = false;
            while(notFinished == false)
            {
                operations();
                //Making the game loop 
                bool invaildInput = false;
                while (invaildInput == false)
                {
                    //do you want to keep going or not
                    Console.WriteLine("Do you want to continue?" + "\n 1. Yes" + "\n 2. No");
                    string input = Console.ReadLine();
                    if (input == "1" || input.ToLower() == "yes")
                    {
                        invaildInput = true;
                        ClearScreen();
                    }
                    //the game ends here
                    else if (input == "2" || input.ToLower() == "no")
                    {
                        notFinished = true;

                    }
                    //to check for errors
                    else
                    {
                        Console.WriteLine("Invaild input recieved. Please type 1 or 2.");
                        invaildInput = false;
                    }
                }
               
            }

        }


        
    }
}
