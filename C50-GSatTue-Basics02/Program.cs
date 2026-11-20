namespace C50_GSatTue_Basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // 1] ---------------------------------

            Book book = new Book();
            book.Title = "System Design";
            book.Pages = 100;
            object obj = book;
            Console.WriteLine(obj.ToString());

            #endregion
        }
    }
}
