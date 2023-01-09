namespace CleanArchitectureDotnet.Persistence.Configurations
{
    public abstract class BaseConfiguration<TModel> : IEntityTypeConfiguration<TModel>
        where TModel : BaseEntity
    {
        public void Configure(EntityTypeBuilder<TModel> builder)
        {
            //TODO:
        }
    }
}

