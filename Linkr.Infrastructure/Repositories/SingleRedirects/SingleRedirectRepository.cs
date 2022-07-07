using Linkr.Application.SingleRedirects;
using Linkr.Application.SingleRedirects.Repository;
using Linkr.Domain;
using Microsoft.EntityFrameworkCore;

namespace Linkr.Infrastructure.Repositories.SingleRedirects;

public class SingleRedirectRepository : ISingleRedirectRepository
{
    private readonly DataContext _context;

    public SingleRedirectRepository(DataContext context)
    {
        _context = context;
    }

    public async ValueTask<SingleRedirect> GetSingleRedirect(string slug)
    {
        var sr = await _context.SingleRedirects.SingleOrDefaultAsync(x => x.Slug == slug);

        return sr;
    }
}