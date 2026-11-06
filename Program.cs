namespace TimesTables;

public class TimesTables
{
    public static void Main(string[] args)
    {
        Console.WriteLine("TIMES TABLES\n------------");

        while (true)
        {
            List<(int, int)> questions = CollectNumbers();
            int correct = 0;
            int incorrect = 0;
            string ANS_LOG = "";
            
            for (int i = 0; i < questions.Count; i++)
            {
                int number1 = questions[i].Item1;
                int number2 = questions[i].Item2;
                int ANS = number1 * number2;
                bool state;
                try
                {
                    Console.WriteLine($"What is the answer to {number1} X {number2}?");
                    int USER_ANS = Convert.ToInt32(Console.ReadLine());
                    if (USER_ANS == ANS)
                    {
                        Console.WriteLine("Great job! Keep up the good work.");

                        correct ++;
                        state=true;

                        string collection = $"Question: {number1} X {number2}\nYour Answer: {USER_ANS}\nCorrect? {state}";
                        ANS_LOG += collection +"\n\n\n";
                    }

                    else
                    {
                        Console.WriteLine("Nearly there. Try another question.........");

                        incorrect++;
                        state=false;

                        string collection = $"Question: {number1} X {number2}\nYour Answer: {USER_ANS}\nCorrect? {state}";
                        ANS_LOG += collection + "\n\n\n";
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("Something went wrong. Make sure you entered a number.");
                    incorrect++;
                }

            }

            Console.Clear();
            Console.WriteLine($"Here are your answers:\n{ANS_LOG}");
            Console.Write("\n\n------------------------------------------------------------------------------------------------------------------------\n\n");
            Console.WriteLine($"Find your total score for the last test below:\nCorrect: {correct} | Incorrect: {incorrect}");
            Console.WriteLine("Click any key to try again........");
            Console.ReadKey();
            Console.Clear();
        }
    }

    public static List<(int, int)> CollectNumbers()
    {
        List<(int, int)> questions = new List<(int, int)>();
        
        for (int i = 0; i < 10; i++)
        {
            questions.Add((RandomNumber(1, 12), RandomNumber(1, 13)));
            //Console.WriteLine($"Stored: {questions[i].Item1} X {questions[i].Item2}"); //for later use, for debugging to see what is stored - conor
        }
        return questions;
    }

    public static int RandomNumber(int min, int max)
    {
        return Random.Shared.Next(min, max);
    }

}