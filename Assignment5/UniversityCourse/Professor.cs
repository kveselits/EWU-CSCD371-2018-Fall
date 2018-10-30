namespace UniversityCourse
{
    public class Professor : Person
    {
        private string ProfessorId { get; set; }

        public Professor(string firstName, string lastName)
            : base(firstName, lastName)
        { }

        public string Id
        {
            get => ProfessorId;
            internal set => ProfessorId = value;
        }
    }
}
