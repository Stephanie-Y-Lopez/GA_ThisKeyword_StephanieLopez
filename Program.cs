namespace GA_ThisKeyword_StephanieLopez
{
    internal class Program
    {
        //Stephanie Lopez
        // 1/18/24
        static void Main(string[] args)
        {
            Person individual1 = new Person("Yolanda", 42);
            individual1.Display();

            Console.WriteLine("");
            Person individual2 = new Person("Oswaldo");
            individual2.Display();
            individual2.SetAge(27);
            individual2.Display();

            Console.WriteLine("");
            Person individual3 = new Person("Diana");
            individual3.Display();
            individual3.SetAge(19);
            individual3.Display();

            //The use of "this" in constructor is to differ fields from parameters as well as in methods. An example of "this" use could be constructor chains, property implementation and passing instances.
        }
    }
}