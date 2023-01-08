namespace CleanArchitectureDotnet.Domain.Events
{
    public class SyncEvent<TModel>
        where TModel : BaseEntity
    {
        public SyncDatabaseAction Action { get; set; }
        public TModel Model { get; set; }

        public SyncEvent(SyncDatabaseAction action,TModel model)
        {
            Action = action;
            Model = model;
        }
    }
}

