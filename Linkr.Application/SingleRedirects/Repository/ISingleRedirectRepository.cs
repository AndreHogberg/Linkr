using Linkr.Domain;

namespace Linkr.Application.SingleRedirects.Repository;

public interface ISingleRedirectRepository
{
    ValueTask<SingleRedirect> GetSingleRedirect(string slug);
}