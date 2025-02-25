using MediatR;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    class GetNoteListQuery : IRequest<NoteListVM>
    {
        public Guid UserId { get; set; }
    }
}
