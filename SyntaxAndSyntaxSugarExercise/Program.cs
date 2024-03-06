namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int answer = 4;
            //string response;
            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + " is greater than or equal to nine";
            //}


            var answer = 4;
            var response = (answer < 9) ? $"{answer} is lees than nine." : $"{answer} is greater than or equal to nice.";
            Console.WriteLine(response);


        }
    }
}
