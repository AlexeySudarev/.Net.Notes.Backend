using MediatR;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    class GetNoteDetailsQuery : IRequest<NoteDetailsVM>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}
