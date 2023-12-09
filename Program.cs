using System;
namespace PetlaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x=0; x<=10; x++){
                double y = Math.Sqrt(Math.Pow(3, 2)) * x;
                Console.WriteLine(y);
            }
        }
    }
}