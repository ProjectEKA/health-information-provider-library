using System;

namespace hip_library.Patient.models.domain
{
    public class Patient
    {
        public string ResourceType { get; }
        public string Name { get; }
        public string Gender { get; }
        public DateTime BirthDate { get; }
        public Address Address { get; }
        public Contact Contact { get; }

        public Patient(string resourceType, string name, string gender, DateTime birthDate, Address address, Contact contact)
        {
            ResourceType = resourceType;
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Address = address;
            Contact = contact;
        }
    }
}