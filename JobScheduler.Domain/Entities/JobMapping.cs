namespace JobScheduler.Domain.Entities
{
    public class JobMapping
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public Job Job { get; set; }

        public string AliasKey { get; set; } // e.g. "table.orders" atau "value.status.expired"
        public string MappedValue { get; set; } // e.g. "trx_orders" atau "3"
    }

}
