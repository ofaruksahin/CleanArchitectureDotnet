namespace CleanArchitectureDotnet.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public RecordStatus Status { get; set; }

        protected BaseEntity()
        {
            Status = RecordStatus.Active;
        }
    }
}

