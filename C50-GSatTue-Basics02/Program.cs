using static System.Runtime.InteropServices.JavaScript.JSType;

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

            //Book book = new Book();
            //book.Title = "System Design";
            //book.Pages = 100;
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());

            #endregion

            #region Question 3
            // 3]----------------------------

            // It's compile-time error 
            //int pages = 464;

            #endregion

            #region Question 4
            // 4]------------------------

            //int num1 = 10;
            //int num2 = 0;
            //try
            //{
            //    Console.WriteLine(num1/num2);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}

            #endregion

            #region Question 5
            // 5]---------------------

            //int pages = 300;
            //double x = pages;

            #endregion

            #region Question 6
            // 6]-------------------

            //double price = 49.99;
            //int x = (int)price;
            //Console.WriteLine(x);

            #endregion

            #region Question 7
            // 7]---------------

            //string pagesText = "464";
            //int pagesInt=Convert.ToInt32(pagesText);
            //Console.WriteLine(pagesInt);

            #endregion

            #region Question 8
            // 8]---------------

            //string yearText = "2023";
            //int yearInt = int.Parse(yearText);
            //Console.WriteLine(yearInt);

            //string badText = "123";
            //if (int.TryParse(badText, out int x))
            //    Console.WriteLine(x);
            //else
            //    Console.WriteLine("Invalid number");

            #endregion

            #region Question 9
            // 9]---------------

            //int pages = 464;
            //string pagesText = pages.ToString();
            //Console.WriteLine(pagesText.GetType());

            #endregion

            #region Question 10
            // 10]------------------

            int copies = 100;
            object obj = copies;
            Console.WriteLine(obj);

            int x = (int)obj;
            Console.WriteLine(x);

            #endregion
        }
    }
}
