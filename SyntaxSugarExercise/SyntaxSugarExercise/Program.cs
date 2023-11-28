namespace SyntaxSugarExercise
{
     class program
    {
        static void Main(string[] args)
        {
            int Num;
           var Num2 = 2;
            Console.WriteLine("What is your favorite number?(Please put it in numerics)");
            Num = int.Parse(Console.ReadLine());
            

            //Console.WriteLine(Num + FirstName + Petname);
            var GreaterThanTwo = (Num > Num2) ? "Your favorite number is greater than 2!" : "Your number less than 2!";
            Console.WriteLine( GreaterThanTwo);
            
        }







    }


}





