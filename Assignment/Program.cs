using Assignment.Context;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {

            }
        }
    }
}