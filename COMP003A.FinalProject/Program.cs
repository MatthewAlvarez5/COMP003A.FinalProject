/* 
 * Author: Matthew Alvarez
 * Course: COMP-003A
 * Purpose: Final Project - An interactive experience building a fictional character
 * 
 */
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
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
            string hometown; string fightYears; string allegianceWord; string weapon; string fighterType;
            char genderLetter; char allegiance;
            int age; int birthYear; int height; int weight; int timeYears; int interpolSpeed = 26; int count; int timer;
            

            Console.ForegroundColor = ConsoleColor.Yellow;
            interpol("Choose a text speed, [S], [N], [F], or [J]  (Slow, Normal, Fast, or Jump): ", interpolSpeed);
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
            /*
            interpol("Welcome to Araevell Kingdom! (When "->" appears click [Enter] Key to continue)", interpolSpeed); wait();
            interpol("(Press [Spacebar] to skip to the end of text)", interpolSpeed); wait();
            interpol("Here, you will create a fictional character based on your preferred characteristics, whether they be fictional or not.", interpolSpeed); wait();
            //Skip to assignment.
            interpol("The story begins after you wake up with amnesia.", interpolSpeed); wait();
            interpol("The beckoning sunlight awakens you. Its color tainted red by stained-glass windows.", interpolSpeed); wait();
            interpol("Pain surges from the back of your skull, as each throb hits you like the beat of a drum.", interpolSpeed); wait();
            interpol("(Press [S] to sit up)", interpolSpeed);
            while (true) { if (Console.ReadKey(true).Key == ConsoleKey.S) { break; } }
            Console.WriteLine(); //Wait for S key
            interpol("You sit up on the wooden bench you’ve made your bed. The lumber groans an awful creak as you pull yourself up.", interpolSpeed); wait();
            interpol("How did you get here? ", interpolSpeed); wait();
            interpol("The stained-glass and the arrangement of the benches give the impression of some religious temple.", interpolSpeed); wait();
            interpol("But, Why are you here?", interpolSpeed); wait();
            interpol("There are rows of the stone men, each standing before a stained-glass portrait.", interpolSpeed); wait();
            interpol("The closest statue clutching a great sword, the point piercing the ground below. His stone grip ensnared the sapphire-set pommel and the other laid upon the shagreen handle. Once a zealot for the gods of this temple, no doubt.", interpolSpeed); wait();
            interpol("Did the gods of those same gods guide you here? ", interpolSpeed); wait();
            interpol("You don’t have time, you must hurry.", interpolSpeed); wait();
            interpol("Hurry? What for?", interpolSpeed); wait();
            interpol("You can't seem to remember.", interpolSpeed); wait();
            interpol("The sudden sound of wood grinding on stone catches your attention.", interpolSpeed); wait();
            interpol("You turn to see one of the colossal doors, meant for humans and giants alike, slowly being pushed by a man merely a fifth of the size", interpolSpeed); wait();
            interpol("He begins to stagger toward you.", interpolSpeed); wait();
            interpol("Unknown: \"HEY... grrgh\"", interpolSpeed); wait();
            interpol("As he writhes in pain, you wonder who the man is. You don't recall ever meeting him before.", interpolSpeed); wait();
            interpolSame("Unknown: \"I see you've...", interpolSpeed); Thread.Sleep(500); interpolSame(" grrgh...", interpolSpeed); Thread.Sleep(500); interpol("made it here in one piece.\"", interpolSpeed); wait();
            interpol("(Press [Space] to stand)", interpolSpeed);
            while (true) { if (Console.ReadKey(true).Key == ConsoleKey.Spacebar) { break; } } Console.WriteLine(); //Wait for Spacebar
            interpolSame("*THUMP*", interpolSpeed); Thread.Sleep(500); interpol("The great hall echoes as you drop back to the seat with a thud.", interpolSpeed); wait();
            interpol("Your tattered limbs resist. Throbbing pain lives where muscles once did.", interpolSpeed); wait();
            interpol("You must get up! What if that man is an enemy?", interpolSpeed); wait();
            interpolSame("A BATTLE!", interpolSpeed); Thread.Sleep(500); interpol("The sudden pain and urgency bring back a piece of your memory", interpolSpeed); wait();
            interpol("But now's not the time you must stand!", interpolSpeed); wait();
            interpol("(PRESS [Spacebar] 10 times before he reaches you!)", interpolSpeed);
            count = 0;
            timer = 0;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    while (!Console.KeyAvailable)
                    {
                        Thread.Sleep(1);
                        timer++;
                        switch (timer)
                        {
                            case 200:
                                interpol("\nHe's half way there!", interpolSpeed);
                                break;
                            case 400:
                                interpol("\nYou failed to reach your feet in time.", interpolSpeed); wait();
                                interpol("Unknown: \"Can't stand? Guess they did you in worse than I thought.\"", interpolSpeed); wait();
                                i = 10;
                                break;
                        }
                        if (timer > 399) { break; }
                    }
                    if (timer > 399) { break; }
                } while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);
                count++;
            }
            if (count == 10)
            {
                interpol("\nYou lurch to your feet preparing to defend yourself from the stranger teetering closer to your position.", interpolSpeed); wait();
                interpol("Unknown: \"Whoah! you look bloody well ready for a fight!\"", interpolSpeed); wait();
            }
            else
            {
                interpol("Unknown: \"Here, I'll help you to your feet.\"", interpolSpeed); wait();
                interpol("He grabs your arm and wrenches your upward", interpolSpeed); wait();
            }

            interpol("Unknown: \"What's that look in your eye for? Don't you remember me?\n We've been fightin' together for a damned fortnite!\"", interpolSpeed); wait();
            interpol("You: \"...\"", interpolSpeed); wait();
            interpol("Unknown: \"Name's Dagoth, bloody nice to meet you. You may not who I am, but I sure as hell know who you are.\"", interpolSpeed); wait();
            interpol("He extends his hand to shake yours", interpolSpeed); wait();
            interpol("(Press [E] to shake his hand)", interpolSpeed);
            timer = 0;
            do
            {
                while (!Console.KeyAvailable)
                {
                    Thread.Sleep(1);
                    timer++;
                    switch (timer)
                    {
                        case 200:
                            interpol("\nHis out-stretched hand begins to wobble as you stare at it with distrusting eyes.", interpolSpeed);
                            break;
                        case 400:
                            interpol("\nHe finally succumbs to the social pressure of being denied a handshake.", interpolSpeed); wait();
                            interpol("Dagoth: \"Not the most likeable person are you?\"", interpolSpeed); wait();
                            break;
                    }
                    if (timer > 399) { break; }
                }
                if (timer > 399) { break; }
                Console.WriteLine();
                interpol("You reach for his hand and shake.", interpolSpeed); wait();
            } while (Console.ReadKey(true).Key != ConsoleKey.E);
            */

            /*-----------------------------------------------------------------------Beginning of the assignment-----------------------------------------------------------------------------------*/
            /*interpol("Dagoth: \"Well? It's only nice to give your own name after I gave mine.\"", interpolSpeed); wait();
            firstName = wordAnswerLoop("Dagoth: \"What is your first name?\"", "Dagoth: \"What foreign tongue is that? I'm gonna need it my language this time.\"", interpolSpeed);
            interpol($"\nDagoth: \"Aye, {firstName} is a fine name!\"", interpolSpeed);
            lastName = wordAnswerLoop("\nDagoth: \"What is your last name?\"", "Dagoth: \"What foreign tongue is that? I'm gonna need it my language this time.\"", interpolSpeed);
            if (firstName == lastName) { interpol($"Dagoth: \"{firstName} {lastName}? What kinda name is that? Your parents are bloody loons!\" ", interpolSpeed); wait(); } //if last name matches first reaction
            interpol($"Dagoth: \"\nWell alright {firstName} {lastName}, I saw you fightin' on the battlefield. A true warrior you are, born to kill.\" ", interpolSpeed); wait();
            
            interpol("Dagoth: \"It got me wonderin' how old you are.\" ", interpolSpeed); wait();
            do
            {
                birthYearWord = numberAnswerLoop("Dagoth: \"What year were you born?\"", interpolSpeed);
                birthYear = Convert.ToInt16(birthYearWord);
            } while (!checkBirthYear(birthYear, interpolSpeed));
            age = DateTime.Now.Year - birthYear;
            */
            /* Varied resopnses to age */
            /*if (age <= 5) { interpol($"Dagoth: \"{age} this year?! You mean to tell me your a toddler? Come off it!\" ", interpolSpeed); wait(); }
            else if (age <= 14 && age > 5)  { interpol($"Dagoth: \"{age} this year?! Your species must age rather quick for that to be true.\" ", interpolSpeed); wait(); }
            else if (age <= 19 && age > 14) { interpol($"Dagoth: \"{age} this year? ‘Tis a ripe age for battle!\" ", interpolSpeed); wait(); }
            else if (age <= 39 && age > 19) { interpol($"Dagoth: \"{age} this year? The way you fought, I wouldn't doubt it. A prime age for fightin'.\" ", interpolSpeed); wait(); }
            else if (age <= 69 && age > 39) { interpol($"Dagoth: \"{age} this year?! Aged like a fine wine, you did!\" ", interpolSpeed); wait(); }
            else if (age <= 99 && age > 69) { interpol($"Dagoth: \"{age} this year?! I would be a great-grandsire at that age!\" ", interpolSpeed); wait(); }
            else { interpol($"Dagoth: \"{age} this year?! I’m surprised you fight the way you do with brittle for bones.\" ", interpolSpeed); wait(); }
            
            interpol("Dagoth: \"And I hope I don’t have to remind ya about your gender\"", interpolSpeed); wait();  
            gender = checkGender(interpolSpeed);
            species = wordAnswerLoop("Dagoth: \"What is your Species?\" (Species: Ex. Human, Elf, Orc, Giant, etc.)", "Dagoth: \"Never heard o' them before, I think your lyin'.\"", interpolSpeed);
            interpol($"Dagoth: \"Ha! A mirror could tell you as well as I. I could tell you're one o’ them {species} peoples just by the look of you.\"", interpolSpeed); wait();
            interpol("Dagoth: \"But... your hair color... you don’t see many people around here with...that color. What was it called again?\"", interpolSpeed); wait();
            hairColor = wordAnswerLoop("Dagoth: \"What is your hair color?\"", "Dagoth: \"No, no that's not it, it was somethin' else.\"", interpolSpeed);
            interpol($"Dagoth: \"You rarely see one of my peoples have {hairColor} hair.\"", interpolSpeed); wait();
            interpol("Dagoth: \"And the color of your eyes are... it’s hard to see with this little light. What color are those?\"", interpolSpeed); wait();
            eyeColor = wordAnswerLoop("Dagoth: \"What is your eye color?\" ", "Dagoth: \"No, no that's not it, it was somethin' else.\"", interpolSpeed);
            interpol($"Dagoth: \"{eyeColor}... I see it now. Wait, now that we are standing eye to eye, it seems that you’re a wee bit taller than me.\"", interpolSpeed); wait(); 
            heightWord = numberAnswerLoop("Dagoth: \"What is your height? In inches of course.\"", interpolSpeed); height = Convert.ToInt16(heightWord);
            if (height <= 22) { interpol("Dagoth: \"Nevermind I must've been seein' things I'm much taller than you\"", interpolSpeed); wait(); } //smallest recorded human
            else { interpol($"Dagoth: \"Ah, well I’m {height - 2} inches so that would explain why I’m lookin’ up at ya.\"", interpolSpeed); wait(); }
            weightWord = numberAnswerLoop("Dagoth: \"How much do you weigh in pounds?\"", interpolSpeed); weight = Convert.ToInt16(weightWord);
            interpol($"Dagoth: \"I weigh 200 pounds, so there’s {Math.Abs(200 - weight)} pound difference between us.\"", interpolSpeed); wait();
            interpol("Dagoth: \"Now I'll remember exactly what you'll look like the next time I see ya'\"", interpolSpeed); wait();
            interpol("Dagoth: \"Many moons have past since we began fightin' together, so I still want to know more about how you became such a great warrior.\"", interpolSpeed); wait();
            hometown = wordAnswerLoop("Dagoth: \"What is the name of your hometown?\"", "Dagoth: \"Never heard of that place before, maybe you mispoke.\"", interpolSpeed);
            string hometownLower = hometown.ToLower();
            if (hometownLower == "araevell" || hometownLower == "araevell kingdom") { interpol("Dagoth: \"I grew up in Araevell as well. This is no place for children. \nThe constant battles between the Kreoti Empire and the Shukiar Rebellion have left many without homes to return to.\"", interpolSpeed); wait(); }
            else { interpol($"Dagoth: \"{hometown} is many leagues away from this retched place, be thankful for that. Araevell Kingdom is not a place for family and loved ones. \nThe constant battles between the Kreoti Empire and the Shukiar Rebellion have left many without homes to return to.\"", interpolSpeed); wait(); }
            fightYears = numberAnswerLoop("Dagoth: \"How many years have you been fighting this damned war?\"", interpolSpeed); timeYears = Convert.ToInt16(fightYears);
            if (timeYears > age)
            {
                while (timeYears > age)
                {
                    interpol($"Dagoth: \"That's not possible! You said you were {age} this year! So I'll ask you again.\"", interpolSpeed); wait();
                    fightYears = numberAnswerLoop("Dagoth: \"How many years have you been fighting this damned war?\"", interpolSpeed); timeYears = Convert.ToInt16(fightYears);
                }
            }
            else if (timeYears == age) { interpol($"Dagoth: \"{timeYears} years?! Came out the womb swingin’ eh? Much like me. \nI’ve been fightin’ so long that it feels as though I was born with a dirk in my hand. I was born in the slums of this ‘ere kingdom. That’s why I am so passionate about fighting this war. \"", interpolSpeed); wait(); }
            else { interpol($"Dagoth: \"{timeYears} years, eh? I’ve been fightin’ so long that it feels as though I was born with a dirk in my hand. I was born in the slums of this ‘ere kingdom. That’s why I am so passionate about fighting this war.\"", interpolSpeed); wait(); }
            */
            allegiance = checkAllegiance(interpolSpeed);
            allegianceWord = Convert.ToString(allegiance);
            if (allegiance == 'k' || allegiance == 'K')
            {
            //    interpol($"Dagoth: \"I knew you were a Kreotian through and through! The blood of the Shukiar still lay on your bare hands! Those ravenous dogs deserved what they wrought! You killed so many that nobody would dare question your allegiance. We shall stamp out this bloody rebellion together, {firstName}.\"", interpolSpeed);
            }
            else if (allegiance == 's' || allegiance == 'S')
            {
             //   interpol($"Dagoth: \"Aye... could tell by your passion on the battlefield that you were a true ally to our cause. The Shukiar welcome you back into our midst. The Kreotian people shall not hold power while we still draw breath! {firstName}, we shall crush this cruel empire under our boot.\"", interpolSpeed);
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
                interpolSame(question + "\n\nYou: ", interpolSpeed);
                answer = Console.ReadLine();
                Console.WriteLine();
                if (checkWord(answer))
                {
                    return answer;
                }
                else
                {
                    interpol(error, interpolSpeed); wait();
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
                interpolSame(question + "\n\nYou: ", interpolSpeed);
                number = Console.ReadLine();
                if (checkNumber(number))
                {
                    Console.WriteLine();
                    return number;
                }
                else
                {
                    interpol("\nDagoth: \"Bloody hell! I asked for a positive number! Do you need me to ask louder?\"", interpolSpeed); wait();
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
            if(number < 0) { return false; }
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
                interpol("Dagoth: \"Do you take me for a fool? That's impossible! Let's try this again.\"", interpolSpeed); wait();
                return false;
            }
        }
        /// <summary>
        /// checks if gender is a character, 
        /// </summary>
        /// <returns>char output</returns>
        static string checkGender(int interpolSpeed)
        {
            string gender = "Not";
            interpol("Dagoth: \"What is your gender?\" ([M], [F], or [O])", interpolSpeed);
            while (gender == "Not")
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.M:
                        gender = "Male";
                        break;
                    case ConsoleKey.F:
                        gender = "Female";
                        break;
                    case ConsoleKey.O:
                        gender = "Other";
                        break;
                }
            }
            Console.WriteLine();
            return gender;
        }

        /// <summary>
        /// Checks if the input is k or s
        /// </summary>
        /// <returns>char output</returns>
        static char checkAllegiance(int interpolSpeed)
        {
            char allegiance = 'L';
            interpol("Dagoth: \"Which side are you on?\" (Choose a side: Enter [S], [K], or [N] key. {Shukiar Rebellion, Kreoti Empire, or Neither})", interpolSpeed);
            while (allegiance == 'L')
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.S:
                        allegiance = 'S';
                        interpol("Dagoth: \"Hmm...\"", interpolSpeed); Thread.Sleep(1000); Console.WriteLine();
                        interpol("Dagoth: \"Aye... could tell by your passion on the battlefield that you were a true ally to our cause. The Shukiar welcome you back into our midst. \nThe Kreotian people shall not hold power while we still draw breath! We shall crush this cruel empire under our boot.\"", interpolSpeed); wait();
                        break;
                    case ConsoleKey.K:
                        allegiance = 'K';
                        interpol("Dagoth: \"Hmm...\"", interpolSpeed); Thread.Sleep(1000); Console.WriteLine();
                        interpol("Dagoth: \"I knew you were a Kreotian through and through! The blood of the Shukiar still lay on your bare hands! Those ravenous dogs deserved what they wrought! \nYou killed so many that nobody would dare question your allegiance. We shall stamp out this bloody rebellion together.\"", interpolSpeed); wait();
                        break;
                    case ConsoleKey.N:
                        allegiance = 'N';
                        interpol("Dagoth: \"Hmm...\"", interpolSpeed); Thread.Sleep(1000); Console.WriteLine();
                        interpol("Dagoth: \"I didn't take you for a mercenary. A pity, if only more men like you would fight for honor rather than few gold pieces, we would have won this bloody war ages ago!\"", interpolSpeed); wait();
                        break;
                }
                if (allegiance == 'N')
                {
                    while (allegiance == 'N') 
                    { 

                        interpol("Dagoth: \"Well which side has been tossing you most of your coin?\" (Choose a side: Enter [S] or [K] key. {Shukiar Rebellion or Kreoti Empire})", interpolSpeed);
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.S:
                                allegiance = 'R';
                                interpol("Dagoth: \"Good, the Kreotian gold won't be worth a rat's ass after we're through with their Empire.\"", interpolSpeed); wait();
                                break;
                            case ConsoleKey.K:
                                allegiance = 'E';
                                interpol("Dagoth: \"'least you got sense to take from the side that means to keep peace in the region. The Usurper, Shukiar, and his dogs deserve a traitor's death, by mercenary or not.\"", interpolSpeed); wait();
                                break;
                        }
                    }
                }
            }
            Console.WriteLine();
            return allegiance;
        }
        /// <summary>
        /// Waits for input of any key
        /// </summary>
        static void wait()
        {
            Console.Write("->");
            do
            { //wait
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            Console.WriteLine();
        }
        /// <summary>
        /// prints each letter in the string, then enters next line
        /// </summary>
        /// <param name="sentence">string input</param>
        static void interpol(string sentence, int speed)
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
                            Thread.Sleep(speed);
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
        static void interpolSame(string sentence, int speed)
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
                            Thread.Sleep(speed);
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