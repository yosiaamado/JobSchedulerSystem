namespace JobScheduler.Domain.Entities
{
    public class JobTemplate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SqlTemplate { get; set; } // Pakai {{table.orders}}, dll
        public string ParamSchemaJson { get; set; } // Optional: untuk dynamic form
    }

}
