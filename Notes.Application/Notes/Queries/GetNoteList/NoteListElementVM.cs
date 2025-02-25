using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Domain;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    class NoteListElementVM : IMapWith<Note>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteListElementVM>()
                .ForMember(noteVM => noteVM.Id, opt => opt.MapFrom(note => note.Id))
                .ForMember(noteVM => noteVM.Title, opt => opt.MapFrom(note => note.Title));
        }
    }
}
