/* 
 * Author: Matthew Alvarez
 * Course: COMP-003A
 * Purpose: Final Project
 * 
 */
using System.Text.RegularExpressions;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Corvis: What is your given name? ");
                string firstName = Console.ReadLine();
                if(checkName(firstName))
                {
                    Console.WriteLine($"Corvis: Ah {firstName} is a fine name indeed.");
                        break;
                }
                else
                {
                    Console.WriteLine("What foreign tongue is that? I'm gonna need it my language this time.");
                }
            }

            while (true)
            {
                Console.Write("Corvis: What is your family name? ");
                string lastName = Console.ReadLine();
                if (checkName(lastName))
                {
                    Console.WriteLine($"Corvis: {lastName}? Can't say I've heard a name like that in my extensive lifetime.");
                        break;
                }
                else
                {
                    Console.WriteLine("What foreign tongue is that? I'm gonna need it my language this time.");
                }
            }

            int age;
            while(true)
            {
                Console.Write("Corvis: What year were you born? ");
                int birthYear = Convert.ToInt16(Console.ReadLine());
                if(checkBirthYear(birthYear))
                {
                    age = 2023 - birthYear;
                    Console.WriteLine($"Corvis: {age} this year huh...");
                        break;
                }
                else
                {
                    Console.WriteLine("Corvis: You think I look stupid or somethin? Let's try this again.");
                }
            }
            while(true)
            {
                Console.Write($"Corvis: ");
                char genderInput = Convert.ToChar(Console.ReadLine());
            }
            

        }
        /// <summary>
        /// Checks name input for incorrect inputs
        /// </summary>
        /// <param name="name">String Input</param>
        /// <returns></returns>
        static bool checkName(string name)
        {
            string pattern = "^[A-Za-z]+$";
            if (Regex.IsMatch(name, pattern))
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }
        /// <summary>
        /// Check if Birth Year possible
        /// </summary>
        /// <param name="birthYear">int input</param>
        /// <returns></returns>
        static bool checkBirthYear(int birthYear)
        {
            if (birthYear >= 1900 && birthYear <= 2023) 
            { 
                return true;
            }
            else
            {
                return false;
            }
        }






    }
}