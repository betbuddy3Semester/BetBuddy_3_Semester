namespace Model_Objects
{
    public class Community : IEntity
    {
        public Community(int id, string beskrivelse, string navn)
        {
            Id = id;
            Beskrivelse = beskrivelse;
            Navn = navn;
        }

        public string Navn { get; private set; }
        public string Beskrivelse { get; private set; }

        public int Id { get; }
    }
}