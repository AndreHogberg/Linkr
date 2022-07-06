namespace Linkr.Domain;

public class LinkGroup
{
    public Guid Id { get; set; }
    public string? UserId { get; set; }
    public ICollection<Link>? Links { get; set; }
}