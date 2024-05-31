using System;
namespace Learn
{
    class Program
    {
        int x;

        public Program(int i)
        {
            x = i;// By your define constructor it inslize the value.
            Console.WriteLine("parametrize constructor " + i);
        }
        public void Display()
        {
            Console.WriteLine("Vale of x is: " + x);
        }
        static void Main(string[] args)
        {
            Program pc = new Program(15); //you send the value in constructor. Output is :- parametrize constructor 15
            Program pc1 = new Program(19); //you send the value in constructor. Output is :- parametrize constructor 15
            pc.Display(); //Output is :- Vale of x is: 15
            pc1.Display(); //Output is :- Vale of x is: 15
        }
    }
}