using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.learning
{
    public class Triangle : IShape
    {
        public void getShape()
        {
            Console.WriteLine("Okay, i am a triangle!!!");
        }
    }
}
