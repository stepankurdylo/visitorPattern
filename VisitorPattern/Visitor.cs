namespace VisitorPattern
{
    public class Visitor : IVisitor
    {
        public void Visit(IElement element)
        {
            var elem = element as Element;
            if (elem != null)
            {
                elem.OperationAfterVisit();
            }
        }
    }
}