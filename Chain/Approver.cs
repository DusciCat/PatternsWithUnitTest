namespace Chain
{
    public abstract class Approver
    {
        protected Approver Successor;
        public void SetSuccessor(Approver successor)
        {
            Successor = successor;
        }
        public abstract string ProcessRequest(Purchase purchase);
        public abstract double Limit { get; }
    }
}