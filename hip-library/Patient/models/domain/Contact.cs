namespace hip_library.Patient.models.domain
{
    public class Contact
    {
        public string Name { get; }
        public ContactPoint Telecom { get; }

        public Contact(string name, ContactPoint telecom)
        {
            Name = name;
            Telecom = telecom;
        }
    }
}