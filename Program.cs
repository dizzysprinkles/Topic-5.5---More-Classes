namespace Topic_5._5___More_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;
            die1 = new Die();
            die2 = new Die(-20);
            

            Console.WriteLine(die2);
            die2.DrawDie();
            die1.RollDie();
            Console.WriteLine(die1);
            die1.DrawDie();
        }
    }
}
