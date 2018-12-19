namespace VisitorPattern
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var listOfElements = new List<Element>();
            listOfElements.Add(new Element());
            listOfElements.Add(new Element());
            listOfElements.Add(new Element());
            listOfElements.Add(new Element());
            listOfElements.Add(new Element());
            var visitor = new Visitor();
            foreach (var element in listOfElements)
            {
                visitor.Visit(element);
            }
            Console.ReadKey();
        }
    }
}