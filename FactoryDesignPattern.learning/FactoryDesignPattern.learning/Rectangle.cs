using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.learning
{
    public class Rectangle : IShape
    {
        public void getShape()
        {
            Console.WriteLine("I am rectangle!!");
        }
    }
}
