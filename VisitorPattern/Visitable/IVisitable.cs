namespace VisitorPattern
{
    public interface IVisitable
    {
        void Accept(ICurrencyVisitor visitor);
    }
}