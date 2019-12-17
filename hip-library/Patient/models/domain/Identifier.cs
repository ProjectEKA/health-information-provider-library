namespace hip_library.Patient.models.domain
{
    public class Identifier
    {
        public string System { get; }
        public string Value { get; }

        public Identifier(string system, string value)
        {
            System = system;
            Value = value;
        }
    }
}