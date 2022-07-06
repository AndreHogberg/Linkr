namespace Linkr.Domain;

public class SingleRedirect
{
    public Guid Id { get; set; }
    public string? Slug { get; set; }
    public string? OriginalUrl { get; set; }
    public DateTime CreatedOn { get; set; }
}