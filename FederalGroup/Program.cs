using System;

namespace FederalGroup
{
    class Program
    {
        static void Main(string[] args)
        {

            bool _leave = false;
            Console.WriteLine("Please choose from below: \n" + "1 for New String \n" + "2 for Digit Reiteration");

            string _choice = Console.ReadLine();

            switch (_choice) {
                case "1":
                    while (!_leave)
                    {
                        Console.WriteLine("Please enter your test string: ");
                        string userInput = Console.ReadLine();

                        if (userInput == "exit")
                        {
                            _leave = true;
                        }
                        else
                        {
                            Console.WriteLine("Below is the new string:");
                            Console.WriteLine(NewString(userInput));
                        }
                    }
                    break;
                case "2":
                    while (!_leave)
                    {
                        Console.WriteLine("Please enter your test string: ");
                        string userInput = Console.ReadLine();

                        if (userInput == "exit")
                        {
                            _leave = true;
                        }
                        else
                        {
                            Console.WriteLine("Below is the new string:");
                            try
                            {
                                Console.WriteLine(DigitLoop(Convert.ToInt32(userInput)));
                            }
                            catch (Exception e) {
                                Console.WriteLine(e.Message);
                            }
                            
                        }
                    }
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        /*
         Write a C# Sharp program to create a new string taking the first 3 characters of a given string
         return the string with the 3 characters added at both the front and back. If the given string length is less than 3, 
         use whatever characters are there.          
         */
        public static string NewString(string inputString) {
            if (!String.IsNullOrEmpty(inputString))
            {
                string _outputString;
                int _lenghtOfString = inputString.Length;
                try
                {
                    return _outputString = inputString.Substring(0, 3) + inputString + inputString.Substring(0,3);
                }
                catch {
                    return _outputString = inputString.Substring(0, _lenghtOfString) + inputString + inputString.Substring(0,_lenghtOfString);
                }
            }
            else {
                return "Input String Not Valid";
            }
        }

        /*
         Write a C# Console Application that displays the individual digits of a given number in order using recursion.
         */

        public static string DigitLoop(int inputDigit) {

            string _inputDigit = inputDigit.ToString();
            int _inputDigitLength = _inputDigit.Length;
            string _outputString = "";
            for (int i = 0; i < _inputDigitLength; i++) {
                _outputString += _inputDigit.Substring(i, 1) + " ";
            }
            return _outputString;
        }
    }
}
