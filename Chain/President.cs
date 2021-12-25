namespace Chain
{
    public class President : Approver
    {
        public override string ProcessRequest(Purchase purchase)
        {
            return purchase.Amount < Limit
                ? $"{GetType().Name} одобренный запрос# {purchase.Number}"
                : $"Запрос# {purchase.Number} требуется исполнительная встреча!";
        }

        public override double Limit { get; } = 100000.0;
    }
}