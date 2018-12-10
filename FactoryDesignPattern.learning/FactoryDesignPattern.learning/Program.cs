using System;

namespace FactoryDesignPattern.learning
{
    class Program
    {
        static void Main(string[] args)
        {
            int vari = 1;
            do
            {
                Console.WriteLine("Enter a shape");
                Console.WriteLine();
                string ask = Console.ReadLine();
                ShapeFactory shapeFactory = new ShapeFactory();
                var type = typeof(Circle);
                shapeFactory.ChooseAShape(ask);
                Console.WriteLine();
                Console.Write("you got the result. for try again press 1 :- ");
                vari = int.Parse(Console.ReadLine());
            }
            while (vari == 1);
            Console.ReadKey();
        }
    }
}
