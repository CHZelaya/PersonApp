namespace PersonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Person person1 = new Person("Evil", "Morty", "2025-05-15");
            Person person2 = new Person("Rick", "Sanchez", "1990-05-15");
            Person person3 = new Person("Bird", "Person", "1889-10-31");
            Person person4 = new Person(" ", " ", "01/01/2000");

            //Testing to see if the date can be in different formats
            Person person5 = new Person("Morty", "Smith", "09/19/2002");

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person3);
            Console.WriteLine(person4);
            Console.WriteLine(person5);

        }


    }
}
