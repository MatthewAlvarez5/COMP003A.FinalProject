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
            string firstName; string lastName; string birthYearWord; string gender;
            string species; string hairColor; string eyeColor; string heightWord; string weightWord;
            string hometown; string fightYears; string weapon; string fighterType;
            char genderLetter; char allegiance;
            int age; int birthYear; int height; int weight; int timeYears;
            /*
            firstName = wordAnswerLoop("Dagoth: What is your given name?: ", "Dagoth: What foreign tongue is that? I'm gonna need it my language this time.");
            lastName = wordAnswerLoop("Dagoth: What is your family name?: ", "Dagoth: What foreign tongue is that? I'm gonna need it my language this time.");
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
            
            Console.WriteLine("Dagoth: “And I hope I don’t have to remind ya about your gender”");
            Console.ReadLine();
            do
            {
                gender = wordAnswerLoop("Dagoth: “What is your gender?” (M, F, or O) \nYou: ", "Dagoth: What foreign tongue is that? I'm gonna need it my language this time.");
                if (checkCharacter(gender))
                {
                    gender = gender.ToLower();
                    if (gender == "m" || gender == "f" || gender == "o")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Dagoth: “You dont have to lie about it. Just tell me what you are.”");
                }
            } while (true);
            genderLetter = Convert.ToChar(gender);
            */
            species = wordAnswerLoop("Dagoth: “Who are your peoples?” (Species: Ex. Human, Elf, Orc, Giant, etc.). ", "Dagoth: Never heard o' them before, I think your lyin'.");
            hairColor = wordAnswerLoop("Dagoth: “Your hair color… you don’t see many people around here with… that color. What was it called again?”", "No, no that's not it it was somethin' else.");
            eyeColor = wordAnswerLoop("Dagoth: “Well, the color of your eyes are… it’s hard to see with this little light. What color are those?” ", "No, no that's not it it was somethin' else.");
            Console.WriteLine($"Dagoth: “{eyeColor}… I see it now. Now that we are standing eye to eye it seems that you’re a wee bit taller than me. ");
            heightWord = numberAnswerLoop("Dagoth: “What is your height? In inches of course.”");
            height = Convert.ToInt16(heightWord);



        }
        /// <summary>
        /// Continues a loop until answer is acceptable
        /// </summary>
        /// <param name="question">string input</param>
        /// <returns></returns>
        static string wordAnswerLoop(string question, string error)
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
                    Console.WriteLine(error);
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
                    Console.WriteLine("Oi! I asked for a number! Do you need me to ask louder?");
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
        /// Checks if the input is a single character
        /// </summary>
        /// <param name="question">string input</param>
        /// <returns></returns>
        static bool checkCharacter(string answer)
        {
            
            string pattern = "^[A-Za-z]+$";
            if (Regex.IsMatch(answer, pattern))
            {
                try
                {
                    char letter = Convert.ToChar(answer);
                }
                catch
                {
                    return false;
                }
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