namespace CleanArchitectureDotnet.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public RecordStatus Status { get; set; }

        private List<INotification> _domainEvents;
        public IReadOnlyList<INotification> DomainEvents
            => _domainEvents;

        protected BaseEntity()
        {
            _domainEvents = new List<INotification>();

            Status = RecordStatus.Active;
        }

        public void AddDomainEvent(INotification notification)
        {
            if (_domainEvents is null)
                _domainEvents = new List<INotification>();
            _domainEvents.Add(notification);
        }

        public void ClearDomainEvent()
        {
            if (_domainEvents is null) return;
            _domainEvents.Clear();
        }
    }
}

