using Chain;

namespace TestProject1
{
    public class TestApprover : Approver
    {
        public override string ProcessRequest(Purchase purchase)
        {
            return Result;
        }

        public override double Limit { get; } = 0;

        public const string Result = "test";
    }
}