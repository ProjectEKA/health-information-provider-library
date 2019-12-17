using System.Collections.Generic;

namespace hip_library.Patient.models.domain
{
    public class Organization
    {
        public string Name { get; }
        public List<Identifier> Identifier { get; }

        public Organization(string name, List<Identifier> identifier)
        {
            Name = name;
            Identifier = identifier;
        }
    }
}