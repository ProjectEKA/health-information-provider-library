namespace hip_library.Patient.models.domain
{
    public class Address
    {
        public string Use { get; }
        public string Line { get; }
        public string City { get; }
        public string District { get; }
        public string State { get; }
        public string PostalCode { get; }

        public Address(string use, string line, string city, string district, string state, string postalCode)
        {
            Use = use;
            Line = line;
            City = city;
            District = district;
            State = state;
            PostalCode = postalCode;
        }
    }
}