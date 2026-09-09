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

            #region Question 03
            // Question 03
            book.Title = "Clean Code";
            Console.WriteLine(book.Title);
            #endregion

            #region Question 04
            // Question 04
            book.Genre = Genre.Science;

            Console.WriteLine(book.Genre);
            #endregion

            #region Question 05
            // Question 05
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion

            #region Question 06
            // Question 06
            int genreNumber = 1;
            Genre genre = (Genre)genreNumber;
            Console.WriteLine(genre);
            #endregion

            #region Question 07
            // Question 07
            Genre genre2 = Genre.Fiction;
            string genreName = genre2.ToString();
            Console.WriteLine(genreName);
            #endregion

            #region Question 08
            // Question 08
            string genreText = "Science";
            Genre genre3 = Enum.Parse<Genre>(genreText);
            Console.WriteLine(genre3);
            #endregion
        }
    }
}
