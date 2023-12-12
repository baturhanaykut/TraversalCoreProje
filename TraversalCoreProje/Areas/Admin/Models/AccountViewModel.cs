namespace TraversalCoreProje.Areas.Admin.Models
{
    public class AccountViewModel
    {
        public int SenderId { get; set; }

        public int ReceiverId { get; set; }

        public decimal Amount { get; set; }

        public decimal SenderNewBalance { get; set; }

        public decimal ReceiverNewBalance { get; set; }
    }
}
