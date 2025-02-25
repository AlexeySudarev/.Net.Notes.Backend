using AutoMapper;
using MediatR;
using Notes.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    class GetNoteListQueryHandler : IRequestHandler<GetNoteListQuery, NoteListVM>
    {
        private readonly INotesDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetNoteListQueryHandler(INotesDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<NoteListVM> Handle(GetNoteListQuery request, CancellationToken cancellationToken)
        {
            var entities = await _dbContext.Notes
                .Where(note => note.UserId == request.UserId)
                .ProjectTo<NoteListElementVM>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new NoteListVM { Notes = entities };
        }
    }
}
