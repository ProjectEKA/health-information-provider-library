using System;
using System.Collections.Generic;

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
        public List<Identifier> Identifier { get; }
        public Organization ManagingOrganization { get; }

        public Patient(string resourceType, string name, string gender, DateTime birthDate, Address address,
            Contact contact, List<Identifier> identifier, Organization managingOrganization)
        {
            ResourceType = resourceType;
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Address = address;
            Contact = contact;
            Identifier = identifier;
            ManagingOrganization = managingOrganization;
        }
    }
}