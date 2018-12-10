using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace FactoryDesignPattern.learning
{
    public class ShapeFactory
    {
        public void ChooseAShape(string shape)
        {
            string product = ConfigurationManager.AppSettings[shape];
            Type type = Type.GetType(product);
            ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
            object classObj = constructor.Invoke(new object[] { });
            MethodInfo method = type.GetMethod("getShape");
            method.Invoke(classObj, null);
        }
    }
}
