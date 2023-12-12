﻿using DataAccessLayer.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TraversalCoreProje.CQRS.Queries.GuideQueries;
using TraversalCoreProje.CQRS.Results.GuideResults;

namespace TraversalCoreProje.CQRS.Handlers.GuideHandlers
{
    public class GetAllQueryHandler : IRequestHandler<GetAllGuideQuery, List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;

        public GetAllQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                GuideId = x.GuideId,
                Description = x.Description,
                Image = x.Image,
                Name = x.Name

            }).AsNoTracking().ToListAsync();
        }
    }
}
