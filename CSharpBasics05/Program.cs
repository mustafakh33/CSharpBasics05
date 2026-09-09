namespace CSharpBasics05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            // 1. Question 01
            // Answer:
            // We cannot access the password field from Main because it is private.
            // A private field can only be accessed from within the same class.
            // Trying to access it from Main will cause a compilation error.
            Book book = new Book();
            //Console.WriteLine(book.password); // Error
            #endregion

        }
    }
}
