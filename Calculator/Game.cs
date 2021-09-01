using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Game
    {


        string input = " ";

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

        float SecondSlection()
        {
            bool invaildInput = false;
            while (invaildInput == false)
            {
                Console.WriteLine("Please enter your first number");
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


        void CalculateNumber()
        {
            float inputValue;
            string input = "";
            input = Console.ReadLine();
            if (!float.TryParse(input, out inputValue)) ;
            {

            }

        }

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
            Console.WriteLine("0");

        }


        
    }
}
