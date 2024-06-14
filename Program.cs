namespace The_Magic_8_ball
{
    internal class Program
    {

   
        static void Main(string[] args)
        {
            //A magic 8-ball style program that asks user three questions and gives different answers with a random number generator
            Console.WriteLine("I am the magic 8-ball, I will give answers to 3 questions. Use ");
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            /*The random number generator, hox! the stored "randomNum" works,
            but won't generate new num inside our loop, so we have to use the 'raw' version */
            Random rnd = new Random();
            int randomNum = rnd.Next(0, 4);

            int questionCounter = 0;
            string questionLimit = "I cannot answer to any other question. Good luck!";


            //While loop. 
            int index = 1;
            while (index <= 3)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"{name}, ask a question:  ");
                string question = Console.ReadLine();
                



                //checks if user gave spesific question types
                if (question.Contains("why"))
                {
                    Console.WriteLine("The magic 8-ball: " + magicAnswerWhy(rnd.Next(0, 8)));

                }
                else if (question.Contains("when"))
                {
                    Console.WriteLine("The magic 8-ball: " + magicAnswerWhen(rnd.Next(0, 8)));
                }
                else if (question.Contains("what"))
                {
                    Console.WriteLine("The magic 8-ball: " + magicAnswerWhat(rnd.Next(0, 8)));
                }
                //if any of upper words are not given, this basic answer will be printed
                else
                {  
                    Console.WriteLine("You already know the answer.");
                }

                //update the counters
                index++;
                questionCounter++;
            }


            //when the counter is 3, the message is shown
            if (questionCounter == 3)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(questionLimit);
            }

        }
        //switch cases for question type "why"
        static string magicAnswerWhy(int num)
        {
            string answer;

            switch (num)
            {
                case 0:
                    answer = "Why indeed?";
                    break;
                case 1:
                    answer = " I might know, but I cannot tell you.";
                    break;
                case 2:
                    answer = "I do not know why.";
                    break;
                case 3:
                    answer = "Because.";
                    break;
                case 4:
                    answer = "Because of reasons.";
                    break;
                case 5:
                    answer = "Because of the weather.";
                    break;
                case 6:
                    answer = "Because it is just awesome.";
                    break;
                case 7:
                    answer = "You sure alredy know why";
                    break;
                default:
                    answer = "Not so sure.";
                    break;
            }


            return answer;
        }

        //switch cases for question type "when"
        static string magicAnswerWhen(int num)

        {
            string answer;

            switch (num)
            {
                case 0:
                    answer = "Today, tomorrow, who knows?";
                    break;
                case 1:
                    answer = "It can happen any time.";
                    break;
                case 2:
                    answer = "When the time is right.";
                    break;
                case 3:
                    answer = "When the night falls.";
                    break;
                case 4:
                    answer = "When you are being confident.";
                    break;
                case 5:
                    answer = "When the sun is shining.";
                    break;
                case 6:
                    answer = "When you are being positive.";
                    break;
                case 7:
                    answer = "Maybe never.";
                    break;
                default:
                    answer = "Not so sure.";
                    break;
            }

            return answer;
        }

        //switch cases for question type "what"
        static string magicAnswerWhat(int num)

        {
            string answer;

            switch (num)
            {
                case 0:
                    answer = "What indeed?";
                    break;
                case 1:
                    answer = "I have no idea.";
                    break;
                case 2:
                    answer = "It is a mystery...";
                    break;
                case 3:
                    answer = "That is for you to discover.";
                    break;
                case 4:
                    answer = "What do you think?";
                    break;
                case 5:
                    answer = "Could be anything.";
                    break;
                case 6:
                    answer = "There is not easy answer to 'what'.";
                    break;
                case 7:
                    answer = "What?";
                    break;
                default:
                    answer = "Not so sure.";
                    break;
            }

            return answer;
        }

    }
}
