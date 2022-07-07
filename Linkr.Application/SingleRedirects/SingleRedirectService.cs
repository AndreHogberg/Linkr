using Linkr.Application.SingleRedirects.Repository;

namespace Linkr.Application.SingleRedirects;

public class SingleRedirectService : ISingleRedirectService
{
    private readonly ISingleRedirectRepository _singleRedirectRepository;

    public SingleRedirectService(ISingleRedirectRepository singleRedirectRepository)
    {
        _singleRedirectRepository = singleRedirectRepository;
    }

    public async ValueTask<string> GetUrlFromSlug(string slug)
    {
        var singleRedirect = await _singleRedirectRepository.GetSingleRedirect(slug);
        if (singleRedirect is null)
        {
            throw new Exception("Empty");
        }
        
        return singleRedirect.OriginalUrl!;
    }
}