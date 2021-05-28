namespace Books.Catalog.Core.DomainConstructs.Entities
{
    public interface IUsernameUpsertTracking
    {
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
    }
}