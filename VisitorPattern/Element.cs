namespace VisitorPattern
{
    using System;

    public class Element : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void OperationAfterVisit()
        {
            Console.WriteLine("Current simple operation is process of visiting.");
        }
    }
}