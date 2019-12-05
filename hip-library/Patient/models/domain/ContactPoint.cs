namespace hip_library.Patient.models.domain
{
    public class ContactPoint
    {
        public string Use { get; }
        public string System { get; }
        public string Value { get; }

        public ContactPoint(string use, string system, string value)
        {
            Use = use;
            System = system;
            Value = value;
        }
    }
}