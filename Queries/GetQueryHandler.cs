using MediatR;
using Microsoft.EntityFrameworkCore;

namespace TestStreamRender.Queries;

public class GetQueryHandler(TestDbContext dbContext)
    : IRequestHandler<GetQuery>
{
    private readonly TestDbContext _dbContext = dbContext;

    public async Task Handle(GetQuery request, CancellationToken cancellationToken)
    {
        await _dbContext.Models.ToListAsync(cancellationToken);
    }
}
