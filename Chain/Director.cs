namespace Chain
{
    public class Director : Approver
    {
        public override string ProcessRequest(Purchase purchase)
        {
            return purchase.Amount < Limit
                ? $"{GetType().Name} одобренный запрос# {purchase.Number}"
                : Successor?.ProcessRequest(purchase);
        }

        public override double Limit { get; } = 10000.0;
    }
}