/* 
 * Author: Matthew Alvarez
 * Course: COMP-003A
 * Purpose: Final Project
 * 
 */
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string birthYearWord;
            string gender;
            int age;
            int birthYear;
            

            firstName = wordAnswerLoop("Dagoth: What is your given name?: ");
            lastName = wordAnswerLoop("Dagoth: What is your family name?: ");
            if(firstName == lastName)
            {
                Console.WriteLine($"Dagoth: {firstName} {lastName}? What kinda name is that? Your parents are bloody loons!  ");
            }

            do
            {
                birthYearWord = numberAnswerLoop("Dagoth: What year were you born?: ");
                birthYear = Convert.ToInt16(birthYearWord);
            } while (!checkBirthYear(birthYear));
            age = 2023 - birthYear;
            
            
            

        }
        /// <summary>
        /// Continues a loop until answer is acceptable
        /// </summary>
        /// <param name="question">string input</param>
        /// <returns></returns>
        static string wordAnswerLoop(string question)
        {
            string answer;
            while (true)
            {
                Console.Write(question);
                answer = Console.ReadLine();
                if (checkWord(answer))
                {
                    return answer;
                }
                else
                {
                    Console.WriteLine("What foreign tongue is that? I'm gonna need it my language this time.");
                }
            }
        }
        /// <summary>
        /// Loops until number is given
        /// </summary>
        /// <param name="question">string Input</param>
        /// <returns></returns>
        static string numberAnswerLoop(string question)
        {
            string number;
            while (true)
            {
                Console.Write(question);
                number = Console.ReadLine();
                if (checkNumber(number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Oi! I asked for a number not whatever hell it is you gave me!");
                }
            }
        }
        /// <summary>
        /// Checks name input for incorrect inputs
        /// </summary>
        /// <param name="name">String Input</param>
        /// <returns></returns>
        static bool checkWord(string name)
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
        /// Checks if the input is a number
        /// </summary>
        /// <param name="number">string input</param>
        /// <returns></returns>
        static bool checkNumber(string number)
        {
            string pattern = "^[0-9]+$";
            if (Regex.IsMatch(number, pattern))
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
                Console.WriteLine("Dagoth: Do you take me for a fool? That's impossible! Let's try this again.");
                return false;
            }
        }

    }
}