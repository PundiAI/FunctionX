namespace Models
{
    public class OrderStatus
    {
        public enum Status {
            WaitingForPayment = 0,
            Completed = 1,
            Cancelled = 2
        }
    }
}