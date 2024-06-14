namespace The_Magic_8_ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A magic 8-ball style program that asks user three questions and gives different answers with a random number generator
            Console.WriteLine("I am the magic 8-ball, I will give answers to 3 questions.");

            //The random number generator
            Random rnd = new Random();
            int randomNum = rnd.Next(0, 10);


            //While loop. 
            int index = 1;
            while (index <= 3)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Ask a question:  ");
                Console.ReadLine();

                //The 'int randomNum' won't somehow generate new number in the next line, so we need to use the raw version
                Console.WriteLine(magicAnswer(rnd.Next(0, 10)));
                index++;
            }



        }
        //switch cases in method 
        static string magicAnswer(int num)
        {
            string answer;

            switch (num)
            {
                case 0:
                    answer = "It is certain.";
                    break;
                case 1:
                    answer = " It is decidedly so.";
                    break;
                case 2:
                    answer = "Without a doubt.";
                    break;
                case 3:
                    answer = "Yes definitely";
                    break;
                case 4:
                    answer = "You may rely on it .";
                    break;
                case 5:
                    answer = "As I see it, yes.";
                    break;
                case 6:
                    answer = "Most likely";
                    break;
                case 7:
                    answer = "Outlook good.";
                    break;
                case 8:
                    answer = "Yes.";
                    break;
                case 9:
                    answer = "Signs point to yes.";
                    break;
                case 10:
                    answer = " It is decidedly so.";
                    break;
                default:
                    answer = "Not so sure.";
                    break;
            }


            return answer;
        }
    }
}
