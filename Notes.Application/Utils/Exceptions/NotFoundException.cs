namespace Notes.Application.Utils.Exceptions
{
    class NotFoundException : Exception
    {
        public NotFoundException(string name, object key) : base($"Entity \"{name}\" ({key}) not found.") { }
    }
}
