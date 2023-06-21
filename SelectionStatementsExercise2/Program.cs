namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite class?");
            var asigment = Console.ReadLine();
            Console.WriteLine("-----------------------------------");
              
            

            switch (asigment) 
            {

                case "Algebra":

                    Console.WriteLine("That is a boring class");

                    break;

                case "Geography":

                    Console.WriteLine("That is an interesting class");

                    break;

                case "Spanish":

                    Console.WriteLine("is a difficult class");

                    break;

                case "Japanesse":

                    Console.WriteLine("that is my favorite class too");

                    break;

                case "Art":

                    Console.WriteLine("I am into that class, I love to draw");

                    break;

                default:

                    Console.WriteLine("well that is not what I ask");

                    break;



            }
        }
    }
}