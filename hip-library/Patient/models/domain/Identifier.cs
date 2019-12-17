namespace hip_library.Patient.models.domain
{
    public class Identifier
    {
        public string Use { get; }
        public string Type { get; }
        public string Value { get; }

        public Identifier(string use, string type, string value)
        {
            Use = use;
            Type = type;
            Value = value;
        }
    }
}