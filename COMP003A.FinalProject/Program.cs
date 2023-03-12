/* 
 * Author: Matthew Alvarez
 * Course: COMP-003A
 * Purpose: Final Project - An interactive experience building a fictional character
 * 
 */
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string interpolLevel;
            string firstName; string lastName; string birthYearWord; string gender;
            string species; string hairColor; string eyeColor; string heightWord; string weightWord;
            string hometown; string fightYears; string allegianceWord; string weapon; string fighterType;
            char genderLetter; char allegiance; 
            int age; int birthYear; int height; int weight; int timeYears; int interpolSpeed = 26;


            /*Console.WriteLine(""); wait();*/
            Console.ForegroundColor = ConsoleColor.Yellow;
            interpolNext("Choose a text speed, [S], [N], [F], or [J]  (Slow, Normal, Fast, or Jump): ", interpolSpeed);
            while (interpolSpeed == 26)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.S:
                        interpolSpeed = 50;
                        break;
                    case ConsoleKey.N:
                        interpolSpeed = 25;
                        break;
                    case ConsoleKey.F:
                        interpolSpeed = 10;
                        break;
                    case ConsoleKey.J:
                        interpolSpeed = 0;
                        break;
                }
            }
            Console.WriteLine();

            interpolNext("Welcome to Araevell Kingdom! (Press [Spacebar] to skip to the end of text, [Enter] Key to continue)", interpolSpeed); wait();
            interpolNext("Here, you will create a fictional character based on your preferred characteristics, whether they be fictional or not.", interpolSpeed); wait();
            interpolNext("The story begins when you wake up with amnesia.", interpolSpeed); wait();
            interpolNext("The beckoning sunlight awakens you. Its color tainted red by stained-glass windows. (Press S to sit up)", interpolSpeed);
            while(true) { if (Console.ReadKey(true).Key == ConsoleKey.S) { break; }  } Console.WriteLine(); //Wait for S key
            interpolNext("You sit up on the wooden bench that you’ve made your bed. The lumber groans an awful creak as you pull yourself up.", interpolSpeed); wait();
            interpolNext("How did you get here? ", interpolSpeed); wait();
            interpolNext("The stained-glass and the arrangement of the benches give the impression of some religious temple.", interpolSpeed); wait();
            interpolNext("But, Why are you here?", interpolSpeed); wait();
            interpolNext("The presence of the stone men, standing before each stained-glass portrait, sends a chill down your spine", interpolSpeed); wait();
            interpolNext("Did the gods of this temple guide you here? ", interpolSpeed); wait();
            interpolNext("You don’t have time, you must hurry.", interpolSpeed); wait();
            interpolNext("", interpolSpeed); wait();
            interpolNext("", interpolSpeed); wait();
            interpolNext("", interpolSpeed); wait();
            interpolNext("", interpolSpeed); wait();
            interpolNext("", interpolSpeed); wait();

            firstName = wordAnswerLoop("Dagoth: \"What is your given name?\"", "Dagoth: \"What foreign tongue is that? I'm gonna need it my language this time.\"", interpolSpeed);
            lastName = wordAnswerLoop("Dagoth: \"What is your family name?\"", "Dagoth: \"What foreign tongue is that? I'm gonna need it my language this time.\"", interpolSpeed);
            if(firstName == lastName) { interpolNext($"Dagoth: \"{firstName} {lastName}? What kinda name is that? Your parents are bloody loons!\" ", interpolSpeed); }
            
            
            do
            {
                birthYearWord = numberAnswerLoop("Dagoth: \"What year were you born?\"", interpolSpeed);
                birthYear = Convert.ToInt16(birthYearWord);
            } while (!checkBirthYear(birthYear, interpolSpeed));
            age = DateTime.Now.Year - birthYear;
            
            interpolNext("Dagoth: \"And I hope I don’t have to remind ya about your gender\"", interpolSpeed);

            genderLetter = checkGender(interpolSpeed);
            gender = Convert.ToString(genderLetter);
            
            species = wordAnswerLoop("Dagoth: \"Who are your peoples?\" (Species: Ex. Human, Elf, Orc, Giant, etc.)", "Dagoth: \"Never heard o' them before, I think your lyin'.\"", interpolSpeed);
            hairColor = wordAnswerLoop("Dagoth: \"Your hair color… you don’t see many people around here with… that color. What was it called again?\"", "Dagoth: \"No, no that's not it, it was somethin' else.\"", interpolSpeed);
            eyeColor = wordAnswerLoop("Dagoth: \"Well, the color of your eyes are… it’s hard to see with this little light. What color are those?\" ", "Dagoth: \"No, no that's not it, it was somethin' else.\"", interpolSpeed);
            interpolNext($"Dagoth: \"{eyeColor}… I see it now. Hey now that we are standing eye to eye, it seems that you’re a wee bit taller than me.\"", interpolSpeed);
            heightWord = numberAnswerLoop("Dagoth: \"What is your height? In inches of course.\"", interpolSpeed);
            height = Convert.ToInt16(heightWord);
            weightWord = numberAnswerLoop("Dagoth: \"How much do you weigh in pounds?\"", interpolSpeed);
            weight = Convert.ToInt16(weightWord);
            hometown = wordAnswerLoop("Dagoth: \"What is the name of your hometown?\"", "Dagoth: \"Never heard of that place before, maybe you mispoke.\"", interpolSpeed);
            fightYears = numberAnswerLoop("Dagoth: \"How many years have you been fighting this damned war?\"", interpolSpeed);
            timeYears = Convert.ToInt16(fightYears);
            // Switch statement
            allegiance = checkAllegiance(interpolSpeed);
            allegianceWord = Convert.ToString(allegiance);
            if (allegiance == 'k' || allegiance == 'K')
            {
                interpolNext($"Dagoth: \"I knew you were a Kreotian through and through! The blood of the Shukiar still lay on your bare hands! Those ravenous dogs deserved what they wrought! You killed so many that nobody would dare question your allegiance. We shall stamp out this bloody rebellion together, {firstName}.\"", interpolSpeed);
            }
            else if (allegiance == 's' || allegiance == 'S')
            {
                interpolNext($"Dagoth: \"Aye... could tell by your passion on the battlefield that you were a true ally to our cause. The Shukiar welcome you back into our midst. The Kreotian people shall not hold power while we still draw breath! {firstName}, we shall crush this cruel empire under our boot.\"", interpolSpeed);
            }
            
            weapon = wordAnswerLoop("Dagoth: \"What is your weapon?\"", "Dagoth: \"No, no that wasn't it. It was something more elegant than that.\"", interpolSpeed);
            fighterType = wordAnswerLoop($"Dagoth: \"Judging by your weapon, the {weapon}, you must be a... uh... a...\"", "Dagoth: \"Did you come up with that fighting style yourself? Compare it to something I would know.\"", interpolSpeed);
            

        }
        /*----------------------------------------------------------------- Method Section --------------------------------------------------------------------------------------------------------------------*/
        /// <summary>
        /// Continues a loop until answer is acceptable
        /// </summary>
        /// <param name="question">string input</param>
        /// <returns>string output</returns>
        static string wordAnswerLoop(string question, string error, int interpolSpeed)
        {
            string answer;
            while (true)
            {
                interpol(question + "\nYou: ", interpolSpeed);
                answer = Console.ReadLine();
                if (checkWord(answer))
                {
                    return answer;
                }
                else
                {
                    interpolNext(error, interpolSpeed);
                }
            }
        }
        /// <summary>
        /// Loops until number is given
        /// </summary>
        /// <param name="question">string Input</param>
        /// <returns>string output</returns>
        static string numberAnswerLoop(string question, int interpolSpeed)
        {
            string number;
            while (true)
            {
                interpol(question + "\nYou: ", interpolSpeed);
                number = Console.ReadLine();
                if (checkNumber(number))
                {
                    return number;
                }
                else
                {
                    interpolNext("Dagoth: \"Bloody hell! I asked for a number! Do you need me to ask louder?\"", interpolSpeed);
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
        /// <returns>bool output</returns>
        static bool checkNumber(string numberWord)
        {
            int number;
            try
            {
                number = Convert.ToInt16((string)numberWord);
            }
            catch
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Checks if the input is a single character
        /// </summary>
        /// <param name="question">string input</param>
        /// <returns>bool output</returns>
        static bool checkCharacter(string answer)
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
        /// <summary>
        /// Check if Birth Year possible
        /// </summary>
        /// <param name="birthYear">int input</param>
        /// <returns>bool output</returns>
        static bool checkBirthYear(int birthYear, int interpolSpeed)
        {
            if (birthYear >= 1900 && birthYear <= 2023) 
            { 
                return true;
            }
            else
            {
                interpolNext("Dagoth: \"Do you take me for a fool? That's impossible! Let's try this again.\"", interpolSpeed);
                return false;
            }
        }
        /// <summary>
        /// checks if gender is a character, 
        /// </summary>
        /// <returns>char output</returns>
        static char checkGender(int interpolSpeed)
        {
            string gender;
            char genderLetter;
            while (true)
            {
                gender = wordAnswerLoop("Dagoth: \"What is your gender?\" (M, F, or O)", "Dagoth: \"What foreign tongue is that? I'm gonna need it my language this time.\"", interpolSpeed);
                if (checkCharacter(gender))
                {
                    gender = gender.ToLower();
                    if (gender == "m" || gender == "f" || gender == "o")
                    {
                        genderLetter = Convert.ToChar(gender);
                        return genderLetter;
                    }
                    else
                    {
                        interpolNext("Dagoth: \"You dont have to lie about it. Just tell me what you are.\"", interpolSpeed);
                    }
                }
                else
                {
                    interpolNext("Dagoth: \"You dont have to lie about it. Just tell me what you are.\"", interpolSpeed);
                }
            }
        }    
        
        /// <summary>
        /// Checks if the input is k or s
        /// </summary>
        /// <returns>char output</returns>
        static char checkAllegiance(int interpolSpeed)
        {
            string allegianceWord;
            char allegiance;
            while (true)
            {
                allegianceWord = wordAnswerLoop("Dagoth: \"Which side are you on ?\" (K or S)", "Dagoth: \"I'm not jokin' around. Tell me, seriously\"", interpolSpeed);
                if (checkCharacter(allegianceWord))
                {
                    allegianceWord = allegianceWord.ToLower();
                    if (allegianceWord == "k" || allegianceWord == "s")
                    {
                         allegiance = Convert.ToChar(allegianceWord);
                         return allegiance;
                    }
                    else
                    {
                        interpolNext("Dagoth: \"I'm not jokin' around. Tell me, seriously\"", interpolSpeed);
                    }
                }
                else
                {
                    interpolNext("Dagoth: \"I'm not jokin' around. Tell me, seriously\"", interpolSpeed);
                }
            }

        }
        /// <summary>
        /// Waits for input of any key
        /// </summary>
        static void wait()
        {
            do
            { //wait
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            Console.WriteLine();
        }
        /// <summary>
        /// prints each letter in the string, then enters next line
        /// </summary>
        /// <param name="sentence">string input</param>
        static void interpolNext(string sentence, int speed)
        {
            do
            {
                do
                {
                    foreach (char letter in sentence)
                    {
                        Console.Write(letter);
                        if (Console.KeyAvailable)
                        {
                            //Skip rest of animation
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(speed);
                        }
                    }
                    break;
                } while (!Console.KeyAvailable);
                break;
            } while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);
            Console.WriteLine();
        }
        /// <summary>
        /// prints each letter in the string
        /// </summary>
        /// <param name="sentence">string input</param>
        static void interpol(string sentence, int speed)
        {
            do
            {
                while (!Console.KeyAvailable)
                {
                    foreach (char letter in sentence)
                    {
                        Console.Write(letter);
                        if (Console.KeyAvailable)
                        {
                            //Skip rest of animation
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(speed);
                        }
                    }
                    break;
                }
                break;
            } while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);
        }

        /*
                static void waitKey(string key)
                {
                    Console.WriteLine($"Press {key} to stop");
                    do
                    {
                        while (!Console.KeyAvailable)
                        {
                            // Do something
                        }
                    } while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);
                }
        */
    }
    }