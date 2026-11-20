namespace C50_GSatTue_Basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // 1] ---------------------------------

            //Book book = new Book();
            //book.Title = "System Design";
            //book.Pages = 100;
            //object obj = book;
            //Console.WriteLine(obj.ToString());

            #endregion

            #region Question 2
            // 2]------------------

            Book book = new Book();
            book.Title = "System Design";
            book.Pages = 100;
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());

            #endregion
        }
    }
}
