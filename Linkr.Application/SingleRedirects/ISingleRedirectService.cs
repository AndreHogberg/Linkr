using Linkr.Domain;

namespace Linkr.Application.SingleRedirects;

public interface ISingleRedirectService
{
    ValueTask<string> GetUrlFromSlug(string slug);
}