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

            #region Question 02
            // Question 02
            // Answer:
            // Yes, it compiles because the field is internal.
            // An internal member can be accessed from anywhere within the same assembly.
            // Since Main is in the same assembly as the Book class, copiesInStock can be accessed.
            Console.WriteLine(book.copiesInStock);
            #endregion

        }
    }
}
