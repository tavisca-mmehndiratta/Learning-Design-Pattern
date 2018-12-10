using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.learning
{
    public class Circle : IShape
    {
        public void getShape()
        {
            Console.WriteLine("Woo hoo, i am a circle..");
        }
    }
}
