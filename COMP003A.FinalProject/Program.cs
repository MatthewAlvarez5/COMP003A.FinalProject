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
            string firstName; string lastName; string gender;
            char skip = '㋛';
            int age; int birthYear; int height; int weight; int fightYears; int interpolSpeed = 11; int count; int timer;

            Console.ForegroundColor = ConsoleColor.Yellow;
            interpol("Choose a text speed, [S], [N], [F], or [J]  (Slow, Normal, Fast, or Jump): ", interpolSpeed);
            while (interpolSpeed == 11)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.S:
                        interpolSpeed = 25;
                        break;
                    case ConsoleKey.N:
                        interpolSpeed = 10;
                        break;
                    case ConsoleKey.F:
                        interpolSpeed = 1;
                        break;
                    case ConsoleKey.J:
                        interpolSpeed = 0;
                        break;
                }
            }
            Console.WriteLine();
            
            interpol("Welcome to Araevell Kingdom! (When \"->\" appears click [Enter] Key to continue)", interpolSpeed); wait();
            interpol("(Press [Spacebar] to skip to the end of text)", interpolSpeed); wait();
            interpol("Maximize window for best experience.", interpolSpeed); wait();
            interpol("Here, you will create a fictional character based on your preferred characteristics, whether they be fictional or not.", interpolSpeed); wait();
            
            //Skip to assignment.
            interpol("Would you like to skip to the assignment? [Y]/[N]: ", interpolSpeed);
            while (skip == '㋛')
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Y:
                        skip = 'Y';
                        break;
                    case ConsoleKey.N:
                        skip = 'N';
                        break;
                }
                Console.WriteLine();
            }

            /*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*----------------------------------------------------------------------- Narrative (Nothing For Assignment) -----------------------------------------------------------------------------*/
            /*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            if (skip == 'N')
            {
                // This whole block is mainly narrative
                printSeparator("Narrative");
                interpol("Beckoning sunlight awakens you. Its color tainted red by stained-glass windows.", interpolSpeed); wait();
                interpol("You can't remember a thing.", interpolSpeed); wait();
                interpol("Pain surges from the back of your skull, as each throb hits you like the beat of a drum.", interpolSpeed); wait();
                interpol("(Press [S] to sit up)", interpolSpeed);
                while (true) { if (Console.ReadKey(true).Key == ConsoleKey.S) { break; } } Console.WriteLine(); //Wait for S key
                interpol("You sit up on the wooden bench you’ve made your bed. The lumber groans an awful creak as you pull yourself up.", interpolSpeed); wait();
                interpol("How did you get here? ", interpolSpeed); wait();
                interpol("The stained-glass and the arrangement of the benches give the impression of some religious temple.", interpolSpeed); wait();
                interpol("But, Why are you here?", interpolSpeed); wait();
                interpol("There are rows of the stone men, each standing before a stained-glass portrait.", interpolSpeed); wait();
                interpol("The closest statue clutching a great sword, the point piercing the ground below. His stone grip ensnared the sapphire-set pommel and the other laid upon the shagreen handle. Once a zealot for the gods of this temple, no doubt.", interpolSpeed); wait();
                interpolSame("The plate of bronze placed below his feet read: ", interpolSpeed); Thread.Sleep(1000); interpol("'Ser Barriston the Bold'", interpolSpeed); wait();
                interpol("Did the those same gods guide you here? ", interpolSpeed); wait();
                interpol("You don’t have time, you must hurry.", interpolSpeed); wait();
                interpol("Hurry? What for?", interpolSpeed); wait();
                interpol("You can't seem to remember.", interpolSpeed); wait();
                interpol("The sudden sound of wood grinding on stone catches your attention.", interpolSpeed); wait();
                interpol("You turn to see one of the colossal doors, meant for humans and giants alike, slowly being pushed by a man merely a fifth of the size", interpolSpeed); wait();
                interpol("He begins to stagger towards you.", interpolSpeed); wait();
                interpol("Unknown: \"HEY... grrgh\"", interpolSpeed); wait();
                interpol("As he writhes in pain, you wonder who the man is. You don't recall ever meeting him before.", interpolSpeed); wait();
                interpolSame("Unknown: ", interpolSpeed); interpolSame("\"I see you've...", interpolSpeed); Thread.Sleep(500); interpolSame(" grrgh...", interpolSpeed); Thread.Sleep(500); interpol("made it here in one piece.\"", interpolSpeed); wait();
                interpol("(Press [Space] to stand)", interpolSpeed);
                while (true) { if (Console.ReadKey(true).Key == ConsoleKey.Spacebar) { break; } } Console.WriteLine(); //Wait for Spacebar
                interpolSame("*THUMP* ", interpolSpeed); Thread.Sleep(1000); interpol("The great hall echoes as you drop back to the seat with a thud.", interpolSpeed); wait();
                interpol("Your tattered limbs resist. Throbbing pain lives where muscles once did.", interpolSpeed); wait();
                interpol("You must get up! What if that man is an enemy?", interpolSpeed); wait();
                interpolSame("A BATTLE! ", interpolSpeed); Thread.Sleep(1000); interpol("The sudden pain and urgency bring back a piece of your memory. You were in a battle.", interpolSpeed); wait();
                interpol("But now's not the time, you must stand!", interpolSpeed); wait();
                interpol("(PRESS [Spacebar] 10 times before he reaches you!)", interpolSpeed);

                //minigame press space 10 times before time runs out
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
                                    interpolSame("Unknown: ", interpolSpeed); interpol("\"Can't stand? Guess they did you in worse than I thought.\"", interpolSpeed); wait();
                                    i = 10;
                                    break;
                            }
                            if (timer > 399) { break; }
                        }
                        if (timer > 399) { break; }
                    } while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);
                    count++;
                }
                if (count == 10)    //If game won
                {
                    interpol("\nYou lurch to your feet preparing to defend yourself from the stranger teetering closer to your position.", interpolSpeed); wait();
                    interpolSame("Unknown: ", interpolSpeed); interpol("\"Whoah! you look bloody well ready for a fight!\"", interpolSpeed); wait();
                }
                else                //if lost
                {
                    interpolSame("Unknown: ", interpolSpeed); interpol("\"Here, I'll help you to your feet.\"", interpolSpeed); wait();
                    interpol("He grabs your arm and wrenches your upward", interpolSpeed); wait();
                }

                //Narrative
                interpolSame("Unknown: ", interpolSpeed); interpol("\"What's that look in your eye for? Don't you remember me?\n We've been fightin' together for a damned fortnite!\"", interpolSpeed); wait();
                interpolSame("You: ", interpolSpeed); interpol("\"...\"", interpolSpeed); wait();
                interpolSame("Unknown: ", interpolSpeed); interpol("\"Name's Dagoth, bloody nice to meet you. You may not who I am, but I sure as hell know who you are.\"", interpolSpeed); wait();
                interpol("He extends his hand to shake yours", interpolSpeed); wait();
                interpol("(Press [E] to shake his hand)", interpolSpeed);
                
                //Press E within the given time
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
                                interpolSame("Dagoth: ", interpolSpeed); interpol("\"Not the most likeable person are you?\"", interpolSpeed); wait();
                                break;
                        }
                        if (timer > 399) { break; }
                    }
                    if (timer > 399) { break; }
                    Console.WriteLine();
                    interpol("You reach for his hand and shake.", interpolSpeed); wait();
                } while (Console.ReadKey(true).Key != ConsoleKey.E);
            }

            /*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*----------------------------------------------------------------------- Beginning of the assignment ------------------------------------------------------------------------------------*/
            /*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            List<string> Answer = new List<string> { }; List<string> Question = new List<string> { };

            printSeparator("Create your character");
            //First Name
            interpolSame("Dagoth: ", interpolSpeed); interpol("\"Well? It's only nice to give your own name after I gave mine.\"", interpolSpeed); wait();
            firstName = wordAnswerLoop("\"What is your first name?\"", "\"What foreign tongue is that? I'm gonna need it my language this time.\"", interpolSpeed);

            //Last Name
            interpolSame("Dagoth: ", interpolSpeed); interpol($"\"Aye, {firstName} is a fine name!\"", interpolSpeed); wait();
            lastName = wordAnswerLoop("\"What is your last name?\"", "\"What foreign tongue is that? I'm gonna need it my language this time.\"", interpolSpeed);
            if (firstName == lastName) { interpolSame("Dagoth: ", interpolSpeed); interpol($"\"{firstName} {lastName}? What kinda name is that? Your parents are bloody loons!\" ", interpolSpeed); wait(); } //if last name matches first lol

            //BirthYear & Age
            interpolSame("Dagoth: ", interpolSpeed); interpol($"\"Well alright {firstName} {lastName}, I saw you fightin' on the battlefield. A true warrior you are, born to kill.\" ", interpolSpeed); wait();
            interpolSame("Dagoth: ", interpolSpeed); interpol("\"It got me wonderin' how old you are.\" ", interpolSpeed); wait();
            do
            {
                birthYear = numberAnswerLoop("\"What year were you born?\"", interpolSpeed);
            } while (!checkBirthYear(birthYear, interpolSpeed));
            age = DateTime.Now.Year - birthYear;

            /* Varied resopnses to age */
            if (age <= 5) { interpolSame("Dagoth: ", interpolSpeed); interpol($"\"{age} this year?! You mean to tell me your a toddler? Come off it!\" ", interpolSpeed); wait(); }  //age <=5
            else if (age <= 14 && age > 5)  { interpolSame("Dagoth: ", interpolSpeed); interpol($"\"{age} this year?! Your species must age rather quick for that to be true.\" ", interpolSpeed); wait(); } //age <=14
            else if (age <= 19 && age > 14) { interpolSame("Dagoth: ", interpolSpeed); interpol($"\"{age} this year? ‘Tis a ripe age for battle!\" ", interpolSpeed); wait(); }  //age <=19
            else if (age <= 39 && age > 19) { interpolSame("Dagoth: ", interpolSpeed); interpol($"\"{age} this year? The way you fought, I wouldn't doubt it. A prime age for fightin'.\" ", interpolSpeed); wait(); }   //age <=39
            else if (age <= 69 && age > 39) { interpolSame("Dagoth: ", interpolSpeed); interpol($"\"{age} this year?! Aged like a fine wine, you did!\" ", interpolSpeed); wait(); } //age <=69
            else if (age <= 99 && age > 69) { interpolSame("Dagoth: ", interpolSpeed); interpol($"\"{age} this year?! I would be a great-grandsire at that age!\" ", interpolSpeed); wait(); }   //age <=99
            else { interpolSame("Dagoth: ", interpolSpeed); interpol($"\"{age} this year?! I’m surprised you fight the way you do with brittle for bones.\" ", interpolSpeed); wait(); } //age >99

            //Gender
            interpolSame("Dagoth: ", interpolSpeed); interpol("\"And I hope I don’t have to remind you about your gender.\"", interpolSpeed); wait();  
            gender = checkGender(interpolSpeed);

            //Question 1
            Question.Add("What is your species?");
            Answer.Add(wordAnswerLoop("\""+Question[0]+"\" (Species: Ex. Human, Elf, Orc, Giant, etc.)", "\"Never heard o' them before, I think your lyin'.\"", interpolSpeed));
            interpolSame("Dagoth: ", interpolSpeed); interpol($"\"Ha! A mirror could tell you as well as I. I could tell you're one o’ them {Answer[0]} peoples just by the look of you.\"", interpolSpeed); wait();

            //Question 2
            Question.Add("What is your hair color?");
            interpolSame("Dagoth: ", interpolSpeed); interpol("\"But... your hair color... you don’t see many people around here with...that color. What was it called again?\"", interpolSpeed); wait();
            Answer.Add(wordAnswerLoop("Dagoth: \""+Question[1]+"\"", "Dagoth: \"No, no that's not it, it was somethin' else.\"", interpolSpeed));
            
            interpolSame("Dagoth: ", interpolSpeed); interpol($"\"You rarely see one of my peoples have {Answer[1]} hair.\"", interpolSpeed); wait();

            //Question 3
            Question.Add("What is your eye color?");
            interpolSame("Dagoth: ", interpolSpeed); interpol("\"And the color of your eyes are... it’s hard to see with this little light. What color are those?\"", interpolSpeed); wait();
            Answer.Add(wordAnswerLoop("\""+Question[2]+"\" ", "\"No, no that's not it, it was somethin' else.\"", interpolSpeed));
            interpolSame("Dagoth: ", interpolSpeed); interpol($"\"{Answer[2]}... I see it now. Wait, now that we are standing eye to eye, it seems that you’re a wee bit taller than me.\"", interpolSpeed); wait();

            //Question 4
            Question.Add("What is your height in inches?");
            height = numberAnswerLoop("\""+Question[3]+"\"", interpolSpeed);
            Answer.Add(Convert.ToString(height));
            
            //checks height
            if (height <= 22) { interpolSame("Dagoth: ", interpolSpeed); interpol("\"Nevermind I must've been seein' things I'm much taller than you\"", interpolSpeed); wait(); } //smallest recorded human
            else { interpolSame("Dagoth: ", interpolSpeed); interpol($"\"Ah, well I’m {height - 2} inches so that would explain why I’m lookin’ up at ya.\"", interpolSpeed); wait(); }

            //Question 5
            Question.Add("What is your weight in pounds?");
            weight = numberAnswerLoop("\""+Question[4]+"\"", interpolSpeed);
            Answer.Add(Convert.ToString(weight));
            interpolSame("Dagoth: ", interpolSpeed); interpol($"\"I weigh about 200 pounds, so there’s {Math.Abs(200 - weight)} pound difference between us.\"", interpolSpeed); wait();

            //dialogue
            interpolSame("Dagoth: ", interpolSpeed); interpol("\"Now I'll remember exactly what you'll look like the next time I see ya'\"", interpolSpeed); wait();
            interpolSame("Dagoth: ", interpolSpeed); interpol("\"Many moons have past since we began fightin' together, so I still want to know more about how you became such a great warrior.\"", interpolSpeed); wait();

            //Question 6
            Question.Add("What is your hometown?");
            Answer.Add(wordAnswerLoop("\""+Question[5]+"\"", "\"Never heard of that place before, maybe you mispoke.\"", interpolSpeed));
            interpolSame("Dagoth: ", interpolSpeed); interpol($"\"{Answer[5]} is many leagues away from this retched place, be thankful for that. Araevell Kingdom is not a place for family and loved ones. \nThe constant battles between the Kreoti Empire and the Shukiar Rebellion have left many without homes to return to.\"", interpolSpeed); wait();

            //Question 7
            Question.Add("How many years have you been fighting this war?");
            fightYears = numberAnswerLoop("\""+Question[6]+"\"", interpolSpeed);
            //Compares answer to age
            if (fightYears > age)
            {
                while (fightYears > age)
                {
                    interpolSame("Dagoth: ", interpolSpeed); interpol($"\"That's not possible! You said you were {age} this year! So I'll ask you again.\"", interpolSpeed); wait();
                    fightYears = numberAnswerLoop("\"How many years have you been fighting this damned war?\"", interpolSpeed);
                }
            }
            else if (fightYears == age) 
            { 
                interpolSame("Dagoth: ", interpolSpeed); interpol($"\"{fightYears} years?! Came out the womb swingin’ eh? Much like me. I’ve been fightin’ so long that it feels as though I was born with a dirk in my hand. I was born in the slums of this ‘ere kingdom. That’s why I am so passionate about fighting this war. \"", interpolSpeed); wait(); 
            }
            else 
            { 
                interpolSame("Dagoth: ", interpolSpeed); interpol($"\"{fightYears} years, eh? I’ve been fightin’ so long that it feels as though I was born with a dirk in my hand. I was born in the slums of this ‘ere kingdom. That’s why I am so passionate about fighting this war.\"", interpolSpeed); wait(); 
            }
            Answer.Add(Convert.ToString(fightYears));

            //Question 8
            Question.Add("Which side of the war are you on?");
            Answer.Add(checkAllegiance(interpolSpeed));

            //Question 9
            Question.Add("What is your weapon?");
            interpolSame("Dagoth: ", interpolSpeed); interpol("\"Let’s find your weapon, it must be lying around here somewhere, what was it again?\"", interpolSpeed); wait();
            Answer.Add(wordAnswerLoop("\""+Question[8]+"\"", "\"No, no that wasn't it. It was something more elegant than that.\"", interpolSpeed));
            interpolSame("Dagoth: ", interpolSpeed); interpol($"\"Aha! Here it is, a fine weapon indeed. You musn’t part ways with such a beauty! The finest looking {Answer[8]} I’ve ever laid eyes upon.\"", interpolSpeed); wait();
            interpolSame("Dagoth: ", interpolSpeed); interpol($"\"And judging by your weapon, the {Answer[8]}, you must be a... uh... a...\"", interpolSpeed); wait();

            //Question 10
            Question.Add("What is your fighter type?");
            Answer.Add(wordAnswerLoop($"\""+Question[9]+"\" (Fighter Type: Ex. Warlock, Wizard, Warrior, Alchemist, etc.)", "\"Did you come up with that fighting style yourself? Say something I would know.\"", interpolSpeed));
            interpolSame("Dagoth: ", interpolSpeed); interpol($"\"Right, the fiercest {Answer[8]} wieldin' {Answer[8]} I've ever seen.\"", interpolSpeed); wait();
            
            /*---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*----------------------------------------------------------------------- End of the assignment input -----------------------------------------------------------------------------------*/
            /*---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            printSeparator("Narrative");

            if (skip == 'N')
            {
                //Mainly Dialogue
                interpolSame("Dagoth: ", interpolSpeed); interpol("\"The battlefield sounds much quieter from this distance. Here in this temple.\"", interpolSpeed); wait();
                interpol("\"This is the Temple of the Theoí Máchis, ‘The Battle Gods’.\"", interpolSpeed); wait();
                interpol("\"They seek blood sacrifice on the field of battle. Each of these statues: a champion, a warrior, a martyr. They spilled much blood on the battlefield, and now they stand here. Made of stone.\"", interpolSpeed); wait();
                interpol("\"But, When all of your followers believe glory should be had fightin', there won't be many who die of old age.\"", interpolSpeed); wait();
                interpolSame("Dagoth: ", interpolSpeed); interpolSame("\"That's why this place is so rundown...", interpolSpeed); Thread.Sleep(750); interpol("abandoned...\"", interpolSpeed); wait();
                interpolSame("Dagoth: ", interpolSpeed); interpol("\"Come, we can’t keep that rotten old coot, Commander Uquidor, waiting much longer.\"", interpolSpeed); wait();
                interpol("The stone figures seem to sense your presence as you step toward the entrance to the great hall.", interpolSpeed); wait();
                interpol("Each step catches the gaze of the next statue. ", interpolSpeed); wait();
                interpol("The columns of stone men ended near the oversized doorway. Each their own weapon", interpolSpeed); wait();
                interpolSame("A sword...", interpolSpeed); interpolSame("A staff...", interpolSpeed); interpol("A javelin...", interpolSpeed); wait();
                interpolSame("Two statues flanked the doorway.", interpolSpeed); Thread.Sleep(500); interpol("Giants.", interpolSpeed); wait();
                interpol("One held a club so large that it could only have made from an entire tree", interpolSpeed); wait();
                interpol("The other held a battle axe that dwarfed the other metal-made weapons in the hall.", interpolSpeed); wait();
                interpol("You pass the  depart, eager to return to battle.", interpolSpeed); wait();
                interpol("Maybe one day this may be your resting place.", interpolSpeed); wait(); Console.WriteLine();
            }

            /*---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*---------------------------------------------------------------------------- Profile Summary ------------------------------------------------------------------------------------------*/
            /*---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            printSeparator("Profile Summary");
            interpol($"The great {gender} warrior named {firstName} {lastName}, born in the year {birthYear}, victorious in battle as a {Answer[7]}. The {Answer[0]}, {Answer[1]} of hair and eyes of {Answer[2]}, " +
                $"\ntall as {Answer[3]} inches and weighed {Answer[4]} pounds. The warrior of the Theoí Máchis was raised in {Answer[5]} and spent over {Answer[6]} years fighting in Araevell Kingdom. " +
                $"\nThe {Answer[8]} used by the warrior will be buried alongside the great {Answer[9]} when their fight has ended. ", interpolSpeed); wait();
            
            interpol("Profile Summary", interpolSpeed); wait();
            interpol($"Name: {lastName}, {firstName}", interpolSpeed);
            interpol($"Age: {age}", interpolSpeed);
            interpol($"Birth Year: {birthYear}", interpolSpeed);
            //list traversal or iteration
            for(int i=0; i < Question.Count; i++)
            {
                interpol($"Question {i+1}: {Question[i]}", interpolSpeed);
                interpol($"Answer   {i+1}: {Answer[i]}", interpolSpeed);
            }
            printSeparator("End of Character Build");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*------------------------------------------------------------------------------ Methods for Questions ------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

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
                interpolSame("Dagoth: ", interpolSpeed); interpolSame(question + "\n\nYou: ", interpolSpeed);
                answer = Console.ReadLine();
                Console.WriteLine();
                if (checkWord(answer))
                {
                    return answer;
                }
                else
                {
                    interpolSame("Dagoth: ", interpolSpeed); interpol(error, interpolSpeed); wait();
                }
            }
        }
        /// <summary>
        /// Loops until number is given
        /// </summary>
        /// <param name="question">string Input</param>
        /// <returns>string output</returns>
        static int numberAnswerLoop(string question, int interpolSpeed)
        {
            string answer;
            int number;
            while (true)
            {
                interpolSame("Dagoth: ", interpolSpeed); interpolSame(question + "\n\nYou: ", interpolSpeed);
                answer = Console.ReadLine();
                if (checkNumber(answer))
                {
                    Console.WriteLine();
                    number= Convert.ToInt32(answer);
                    return number;
                }
                else
                {
                    interpolSame("\nDagoth: ", interpolSpeed); interpol("\"Bloody hell! I asked for a positive number! Do you need me to ask louder?\"", interpolSpeed); wait();
                }
            }
        }
        /// <summary>
        /// Checks name input for incorrect inputs
        /// </summary>
        /// <param name="name">String Input</param>
        /// <returns></returns>
        static bool checkWord(string word)
        {
            string pattern = "^[A-Za-z]+$";
            if (Regex.IsMatch(word, pattern))
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
                interpolSame("Dagoth: ", interpolSpeed); interpol("\"Do you take me for a fool? That's impossible! Let's try this again.\"", interpolSpeed); wait();
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
            interpolSame("Dagoth: ", interpolSpeed); interpol("\"What is your gender?\" ([M], [F], or [O])", interpolSpeed);
            while (gender == "Not")
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.M:
                        gender = "Male \v";
                        break;
                    case ConsoleKey.F:
                        gender = "Female \f";
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
        static string checkAllegiance(int interpolSpeed)
        {
            string allegiance = "None";
            interpolSame("Dagoth: ", interpolSpeed); interpol("\"Which side are you on?\" (Choose a side: Enter [S], [K], or [N] key. {Shukiar Rebellion, Kreoti Empire, or Neither})", interpolSpeed);
            while (allegiance == "None")
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.S:
                        allegiance = "Shukiar Rebel";
                        interpolSame("Dagoth: ", interpolSpeed); interpol("\"Hmm...\"", interpolSpeed); Thread.Sleep(1000); Console.WriteLine();
                        interpolSame("Dagoth: ", interpolSpeed); interpol("\"Aye... could tell by your passion on the battlefield that you were a true ally to our cause. The Shukiar welcome you back into our midst. \nThe Kreotian people shall not hold power while we still draw breath! We shall crush this cruel empire under our boot.\"", interpolSpeed); wait();
                        break;
                    case ConsoleKey.K:
                        allegiance = "Kreotian Imperial";
                        interpolSame("Dagoth: ", interpolSpeed); interpol("\"Hmm...\"", interpolSpeed); Thread.Sleep(1000); Console.WriteLine();
                        interpolSame("Dagoth: ", interpolSpeed); interpol("\"I knew you were a Kreotian through and through! The blood of the Shukiar still lay on your bare hands! Those ravenous dogs deserved what they wrought! \nYou killed so many that nobody would dare question your allegiance. We shall stamp out this bloody rebellion together.\"", interpolSpeed); wait();
                        break;
                    case ConsoleKey.N:
                        allegiance = "Neither";
                        interpolSame("Dagoth: ", interpolSpeed); interpol("\"Hmm...\"", interpolSpeed); Thread.Sleep(1000); Console.WriteLine();
                        interpolSame("Dagoth: ", interpolSpeed); interpol("\"I didn't take you for a mercenary. A pity, if only more men like you would fight for honor rather than few gold pieces, we would have won this bloody war ages ago!\"", interpolSpeed); wait();
                        break;
                }
                if (allegiance == "Neither")
                {
                    while (allegiance == "Neither") 
                    { 

                        interpolSame("Dagoth: ", interpolSpeed); interpol("\"Well, which side has been filling your pockets with their coin?\" (Choose a side: Enter [S] or [K] key. {Shukiar Rebellion or Kreoti Empire})", interpolSpeed);
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.S:
                                allegiance = "Shukiar Mercenary";
                                interpolSame("Dagoth: ", interpolSpeed); interpol("\"Good, the Kreotian gold won't be worth a rat's ass after we're through with their Empire.\"", interpolSpeed); wait();
                                break;
                            case ConsoleKey.K:
                                allegiance = "Kreotian Mercenary";
                                interpolSame("Dagoth: ", interpolSpeed); interpol("\"'least you got sense to take from the side that means to keep peace in the region. The Usurper, Shukiar, and his dogs deserve a traitor's death, by mercenary or not.\"", interpolSpeed); wait();
                                break;
                        }
                    }
                }
            }
            Console.WriteLine();
            return allegiance;
        }

        /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*------------------------------------------------------------------------------ Methods for Syntax ---------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        /// <summary>
        /// Prints Section Title
        /// </summary>
        /// <param name="sectionTitle">String input</param>
        static void printSeparator(string sectionTitle)
        {
            int letterCount=0;
            foreach(char letter in sectionTitle)
            {
                  letterCount++; 
            }
            
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("".PadRight(100, '-'));
            if(letterCount%2 == 0)
            {
                for(int i=0; i<50-(letterCount/2); i++;) { Console.Write(" "); }
                Console.Write($"{sectionTitle}")
                for(int i=0; i<50-(letterCount/2); i++;) { Console.Write(" "); }
            }
            else if(letterCount%2 != 0)
            {
                for(int i=0; i<50-((letterCount+1)/2); i++;) { Console.Write(" "); }
                Console.Write($"{sectionTitle}")
                for(int i=0; i<50-(letterCount/2); i++;) { Console.Write(" "); }
            }
            Console.WriteLine("".PadRight(100, '-'));
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            wait();
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
        /// <summary>
        /// Changes the color of the given string only
        /// </summary>
        /// <param name="sentence">string input</param>
        static void ColorChange(string sentence, char, color, int interpolSpeed)
        {
            switch(color)
            {
                case 'w':
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 'g':
                    Console.ForegroundColor = ConsoleColor.Green;
                    break; 
                case 'b':
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 'c':
                    Console.ForegroundColor = ConsoleColor.LightBlue;
                    break;
                case 'r':
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            interpolSame(sentence, interpolSpeed); 
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}
