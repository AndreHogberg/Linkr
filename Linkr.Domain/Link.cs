namespace Linkr.Domain;

public class Link
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Url { get; set; }

    public LinkGroup LinkGroup { get; set; }
}