namespace AcademyTest.Entities
{
    public record User
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Email { get; init; }
        public long Phone { get; init; }

        internal static object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}