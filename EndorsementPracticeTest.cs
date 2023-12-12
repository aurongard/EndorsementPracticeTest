//Filname EndorsementPracticeTest.cs
//Written by Tom Williams
//Written on 10/28/23
//Test information taken from: https://dmv-permit-test.com/michigan/motorcycle-test-1.html

namespace EndorsementPracticeTest
{
    using Microsoft.VisualBasic;
    using System;
    using System.Diagnostics;
    using System.Numerics;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Runtime.ConstrainedExecution;
    using System.Runtime.Intrinsics.X86;
    using System.Text.RegularExpressions;
    using System.Threading.Channels;
    using static System.Console;
    class User
    {
        private string userName;
        public int userScore;

        public User(string newName)
        {
            userName = newName;
            userScore = 0;
        }

        public void AddScore() //increases score each time a question is answered
        {
            userScore += 1;
        }

        public string GetUserName() 
        {
            return userName;
        }
        public int UserScore()
        {
            return userScore;
        }
        public void PrintUser() // prints the final test score
        {
            WriteLine("********Test Score********");
            WriteLine("Username: {0}", userName);
            WriteLine("Test Score: {0}/10", userScore);
            WriteLine("**************************");
            WriteLine();
            if (userScore >= 7) //prints whether or not the user passed. Needs a 70% or higher to pass.
            {
                WriteLine("Congratualation, you passed!");
            }
            else
            {
                WriteLine("You failed, please study and try again.");
            }
        }
    }

    class Questions
    {
        public bool q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19, q20;
        public bool a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;

        public Questions()
        {
            q1 = true;
            q2 = true;
            q3 = true;
            q4 = true;
            q5 = true;
            q6 = true;
            q7 = true;
            q8 = true;
            q9 = true;
            q10 = true;
            q11 = true;
            q12 = true;
            q13 = true;
            q14 = true;
            q15 = true;
            q16 = true;
            q17 = true;
            q18 = true;
            q19 = true;
            q20 = true;
            
            a1 = false; 
            a2 = false;
            a3 = false;
            a4 = false;
            a5 = false;
            a6 = false;
            a7 = false; 
            a8 = false;
            a9 = false;
            q10 = false;
        }

        public void SetQuestion(int questionNum) //changes the status of a question to used
        {
            switch(questionNum)
            {
                case 0: q1 = false; break;
                case 1: q2 = false; break;
                case 2: q3 = false; break;
                case 3: q4 = false; break;
                case 4: q5 = false; break;
                case 5: q6 = false; break;
                case 6: q7 = false; break;
                case 7: q8 = false; break;
                case 8: q9 = false; break;
                case 9: q10 = false; break;
                case 10: q11 = false; break;
                case 11: q12 = false; break;
                case 12: q13 = false; break;
                case 13: q14 = false; break;
                case 14: q15 = false; break;
                case 15: q16 = false; break;
                case 16: q17 = false; break;
                case 17: q18 = false; break;
                case 18: q19 = false; break;
                case 19: q20 = false; break;
            }
        }

        public bool GetQuestion(int questionNum) //returns the status of a question as to whether or not it's been used.
        {
            bool question = false;
            switch(questionNum)
            {
                case 0: question = q1; break;
                case 1: question = q2; break;
                case 2: question = q3; break;
                case 3: question = q4; break;
                case 4: question = q5; break;
                case 5: question = q6; break;
                case 6: question = q7; break;
                case 7: question = q8; break;
                case 8: question = q9; break;
                case 9: question = q10; break;
                case 10: question = q11; break;
                case 11: question = q12; break;
                case 12: question = q13; break;
                case 13: question = q14; break;
                case 14: question = q15; break;
                case 15: question = q16; break;
                case 16: question = q17; break;
                case 17: question = q18; break;
                case 18: question = q19; break;
                case 19: question = q20; break;
            }
            return question;
        }
        public void SetAnswer(int questionNum, bool answer) //sets whether the user got the question correct or not
        {
            switch (questionNum) { 
                case 0: a1 = answer; break;
                case 1: a2 = answer; break;
                case 2: a3 = answer; break;
                case 3: a4 = answer; break;
                case 4: a5 = answer; break;
                case 5: a6 = answer; break;
                case 6: a7 = answer; break;
                case 7: a8 = answer; break;
                case 8: a9 = answer; break;
                case 9: a10 = answer; break;
            }
        }

        public void PrintQuestions() //prints whether questions were answered correctly or not
        {
            WriteLine("******Question Score******");
            WriteLine("True = Correctly answered.");
            WriteLine("False = Incorrectly answered.");
            WriteLine();
            WriteLine("Question 1: " + a1);
            WriteLine("Question 2: " + a2);
            WriteLine("Question 3: " + a3);
            WriteLine("Question 4: " + a4);
            WriteLine("Question 5: " + a5);
            WriteLine("Question 6: " + a6);
            WriteLine("Question 7: " + a7);
            WriteLine("Question 8: " + a8);
            WriteLine("Question 9: " + a9);
            WriteLine("Question 10: " + a10);
            WriteLine("**************************");
        }
    }
    internal class EndorsementPracticeTest
    {
        static bool CheckAnswer(string answer)
        {
            bool answerBool = false; //boolean for correct (true) or incorrect (false)
            bool menu2 = false; //boolean for the questions
            string choice = ""; //for answers to questions

            while (menu2 == false)
            {
                //requests input from user for answer
                WriteLine("Enter you selection: ");
                choice = ReadLine();
                choice.ToLower();
                
                if ((choice == "a") || (choice == "b") || (choice == "c") || (choice == "d"))
                {
                    if (choice == answer) //for correct answer
                    {
                        //WriteLine("Correct!");
                        answerBool = true;
                        menu2 = true;
                    }
                    else //incorrect answers
                    {
                        //WriteLine("Incorrect!");
                        answerBool = false;
                        menu2 = true;
                    }
                }
                else //invalid entries
                {
                    WriteLine("That is not a valid response."); 
                    WriteLine();
                }
            }
            WriteLine();
            return answerBool;
        }
        static void Main(string[] args)
        {
            string userName = ""; //test takers name
            string choice = "a"; //for answers to questions
            int questions = 0; //keeps track of the number of questions the user has tried
            int switchNum = 0; //moves user through switch for random questions
            bool menu1 = false; //boolean for entering name
            bool menu2 = false; //boolean for question check
            bool answer; //boolean for test answers
            bool randNum = true; //boolean for checking if a question has been used

            WriteLine("Welcome to your Motor Cycle Endorsement practice test");
            WriteLine();
            WriteLine("Please type your name and press enter: ");

            //while loop to request the user's name
            while (menu1 == false)
            {
                userName = ReadLine();//reads user input for name

                WriteLine("Is {0} correct? Type [y] for yes, or [n] to enter a new name.", userName);
                choice = ReadLine();//reads user input for y or n
                choice.ToLower();//sets the choice to lowercase for reduction in code and error

                //if yes breaks while loop
                if (choice ==  "y")
                {
                    WriteLine();
                    menu1 = true;
                }
                //if no asks the user to enter their name again and loops through
                else if (choice == "n")
                {
                    WriteLine("Please type your name and press enter: ");
                    WriteLine();
                }
                //if user enters anything that isn't y or n, it states the input was invalid and loops to the beginning again.
                else
                {
                    WriteLine("That is not a valid entry.");
                    WriteLine("Please type your name and press enter: ");
                    WriteLine();
                }
            }


            User user = new User(userName); //creates user object.
            Questions que = new Questions(); //creates object to control question booleans
            Random random = new Random(); //creates a random number generator

            while (questions < 10)
            {
                answer = false;
                ++questions;

                if (questions <= 10)
                    Write("Question #{0}: ", questions);

                while (menu2 != true)
                {
                    switchNum = random.Next(0, 19); //produces a random number between 0 and 19
                    randNum = que.GetQuestion(switchNum); //checks boolean status of question as to whether it's been used or not already
                    if (randNum == true)
                        menu2 = true;
                }

                menu2 = false; //resets randomizer status
                
                //a series of questions held in switches.
                switch(switchNum)
                {

                    case 0: //correct answer is a
                        WriteLine("You cannot ride a motorcycle on highways:");
                        WriteLine("     [a] unless you can travel safely at the minimum posted speed.");
                        WriteLine("     [b] at night, because your lights aren't bright enough.");
                        WriteLine("     [c] during rush hour.");
                        WriteLine("     [d] without proper sunglasses.");
                        WriteLine();

                        answer = CheckAnswer("a"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 1: //correct answer is d
                        WriteLine("If a car on an entrance ramp is going to merge into your lane, you should: ");
                        WriteLine("     [a] ride next to the car.");
                        WriteLine("     [b] flash your brake light.");
                        WriteLine("     [c] increase your speed and pass the car.");
                        WriteLine("     [d] change to another lane if one is open.");
                        WriteLine();

                        answer = CheckAnswer("d"); //calls the function to request the user answer and check if it is correct or not.

                        break; 

                    case 2: //correct answer is c
                        WriteLine("To discourage other vehicles from trying to share your lane, you should: ");
                        WriteLine("     [a] wear your helmet.");
                        WriteLine("     [b] use your horn.");
                        WriteLine("     [c] ride in the center lane position.");
                        WriteLine("     [d] slow down and come to a stop.");
                        WriteLine();

                        answer = CheckAnswer("c"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 3: //correct answer is c
                        WriteLine("When it starts to rain:");
                        WriteLine("     [a] always ride in the left lane position.");
                        WriteLine("     [b] increase your speed to lessen your chances of skidding.");
                        WriteLine("     [c] ride in the tire tracks left by cars.");
                        WriteLine("     [d] ride in the center lane position.");
                        WriteLine();

                        answer = CheckAnswer("c"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 4: //correct answer is d
                        WriteLine("Before riding a motorcycle, it's important to check: ");
                        WriteLine("     [a] tires and wheels.");
                        WriteLine("     [b] chassis.");
                        WriteLine("     [c] oil and fluids. ");
                        WriteLine("     [d] All of the above.");
                        WriteLine();

                        answer = CheckAnswer("d"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 5: //correct answer is c

                        WriteLine("To increase your chances of avoiding obstacles at night, you should:");
                        WriteLine("     [a] ride in a staggered formation.");
                        WriteLine("     [b] always ride in the center lane position. ");
                        WriteLine("     [c] reduce your speed. ");
                        WriteLine("     [d] grab at the front brake.");
                        WriteLine();

                        answer = CheckAnswer("c"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 6: //correct answer is d

                        WriteLine("When should motorcycles share lanes with cars?");
                        WriteLine("     [a] When riding in a staggered formation.");
                        WriteLine("     [b] In heavy traffic.");
                        WriteLine("     [c] In school zones.");
                        WriteLine("     [d] Never.");
                        WriteLine();

                        answer = CheckAnswer("d"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 7: //correct answer is c

                        WriteLine("The right foot pedal controls:");
                        WriteLine("     [a] the front brake.");
                        WriteLine("     [b] the throttle.");
                        WriteLine("     [c] the rear brake.");
                        WriteLine("     [d] the clutch.");
                        WriteLine();

                        answer = CheckAnswer("c"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 8: //correct answer is a

                        WriteLine("Eye protection:");
                        WriteLine("     [a] should give a clear view to either side.");
                        WriteLine("     [b] is only needed if your motorcycle is not equipped with a windshield.");
                        WriteLine("     [c] is only needed when riding in bad weather.");
                        WriteLine("     [d] None of the other answers is correct.");
                        WriteLine();

                        answer = CheckAnswer("a"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 9: //correct answer is b

                        WriteLine("When riding at night you should:");
                        WriteLine("     [a] use your low beam.");
                        WriteLine("     [b] increase the following distance.");
                        WriteLine("     [c] decrease your following distance.");
                        WriteLine("     [d] increase your speed.");
                        WriteLine();

                        answer = CheckAnswer("b"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 10: //correct answer is d

                        WriteLine("By 'choosing the best lane position' you:");
                        WriteLine("     [a] are not in a blind spot.");
                        WriteLine("     [b] are avoiding hazards.");
                        WriteLine("     [c] maximize the space cushion around you.");
                        WriteLine("     [d] All of the above.");
                        WriteLine();

                        answer = CheckAnswer("d"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 11: //correct answer is d

                        WriteLine("When turning through a slow, tight turn, you should:");
                        WriteLine("     [a] lean at the same angle as the motorcycle.");
                        WriteLine("     [b] lean the opposite way of the turn.");
                        WriteLine("     [c] pull in the clutch.");
                        WriteLine("     [d] keep your body straight while leaning the motorcycle.");
                        WriteLine();

                        answer = CheckAnswer("d"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 12: //correct answer is b

                        WriteLine("For railroad tracks that run parallel to your course, move far enough away from the tracks to cross at an angle of at least:");
                        WriteLine("     [a] 30°");
                        WriteLine("     [b] 45°");
                        WriteLine("     [c] 90°");
                        WriteLine("     [d] 15°");
                        WriteLine();

                        answer = CheckAnswer("b"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 13: //correct answer is d

                        WriteLine("While stopped at a traffic light, if you believe that your motorcycle has not triggered a light sensor, when can you proceed?");
                        WriteLine("     [a] After coming to a complete stop");
                        WriteLine("     [b] After waiting for a reasonable amount of time");
                        WriteLine("     [c] After yielding the right - of - way to any vehicle or pedestrian in or near the intersection");
                        WriteLine("     [d] All of the above.");
                        WriteLine();

                        answer = CheckAnswer("d"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 14: //correct answer is b

                        WriteLine("In a single lane of traffic there are _____ lane positions.");
                        WriteLine("     [a] two");
                        WriteLine("     [b] three");
                        WriteLine("     [c] four");
                        WriteLine("     [d] one");
                        WriteLine();

                        answer = CheckAnswer("b"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 15: //correct answer is d

                        WriteLine("At a minimum, your street-legal motorcycle should have:");
                        WriteLine("     [a] Turn signals and two mirrors.");
                        WriteLine("     [b] Front and rear brakes, horn.");
                        WriteLine("     [c] Headlight, taillight and brakelight.");
                        WriteLine("     [d] All of the above.");
                        WriteLine();

                        answer = CheckAnswer("d"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 16: //correct answer is c

                        WriteLine("______ helps you absorb shock when riding over obstacles.");
                        WriteLine("     [a] Rolling on the throttle");
                        WriteLine("     [b] Pulling in the clutch");
                        WriteLine("     [c] Rising slightly off the seat");
                        WriteLine("     [d] Using a higher gear." );
                        WriteLine();

                        answer = CheckAnswer("c"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 17: //correct answer is d

                        WriteLine("When it starts to rain, you should ride:");
                        WriteLine("     [a] in groups larger than 4 or 5 motorcyclists.");
                        WriteLine("     [b] in the center lane position.");
                        WriteLine("     [c] on the shoulder of the road.");
                        WriteLine("     [d] in the tire tracks left by cars.");
                        WriteLine();

                        answer = CheckAnswer("d"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 18: //correct answer is c

                        WriteLine("To keep other vehicles from sharing your lane:");
                        WriteLine("     [a] sound your horn.");
                        WriteLine("     [b] change lanes often.");
                        WriteLine("     [c] ride closer to the center portion of the lane.");
                        WriteLine("     [d] flash your brake light.");
                        WriteLine();

                        answer = CheckAnswer("c"); //calls the function to request the user answer and check if it is correct or not.

                        break;

                    case 19: //correct answer is d

                        WriteLine("You should use both brakes at the same time:");
                        WriteLine("     [a] when riding on hills.");
                        WriteLine("     [b] in emergencies only.");
                        WriteLine("     [c] None of the other answers is correct.");
                        WriteLine("     [d] every time you slow or stop.");
                        WriteLine();

                        answer = CheckAnswer("d"); //calls the function to request the user answer and check if it is correct or not.

                        break;
                }

                que.SetQuestion(switchNum); //marks question as used

                //if the user got a question correct this will increase the score.
                if (answer == true)
                {
                    bool questionBool = true;
                    user.AddScore();
                    que.SetAnswer(questions, questionBool);
                }
            }
            user.PrintUser();
            WriteLine();
            que.PrintQuestions();
        }
    }
}