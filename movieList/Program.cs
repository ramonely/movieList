using System;

namespace movieList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Database Shows = new Database();

            string answer = Shows.Welcome();
            Shows.lookUp(answer);
        }
    }
}