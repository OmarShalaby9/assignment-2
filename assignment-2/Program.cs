using System.Text;

namespace assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //string title = "clean code";
            //string upperTitle = title.ToUpper();

            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion

            #region Q2
            //    string t1 = "Clean Code";
            //    string t2 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(t1, t2));
            #endregion

            #region Q3
            //StringBuilder s1 = new StringBuilder();

            //s1.Append("Book List");
            //s1.Append(" - Updated");

            //Console.WriteLine(s1.ToString());
            #endregion

            #region Q4
            //StringBuilder s1 = new StringBuilder();

            //s1.Append("Book List");
            //s1.Append(" - Updated");

            //s1.Replace ("Book List","Library");

            //Console.WriteLine(s1.ToString());
            #endregion

            #region Q5
            //string title = "Clean Code";
            //int pages = 464;

            //string result = "Book: " + title + ", Pages: " + pages;

            //Console.WriteLine(result);
            #endregion

            #region Q6
            string title = "Clean Code";
            int pages = 464;

            string result = $"Book: {title}, Pages: {pages}";

            Console.WriteLine(result);
            #endregion

            #region Q7

            #endregion
        }
    }
}
