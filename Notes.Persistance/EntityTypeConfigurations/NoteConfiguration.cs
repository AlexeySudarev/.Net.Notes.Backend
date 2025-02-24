using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Notes.Domain
{
    class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        private const int TitleMaxLength = 250;

        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(note => note.Id);
            builder.HasIndex(note => note.Id).IsUnique();
            builder.Property(note => note.Title).HasMaxLength(TitleMaxLength);
        }
    }
}