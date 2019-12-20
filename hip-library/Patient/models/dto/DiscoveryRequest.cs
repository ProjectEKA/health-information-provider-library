using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace hip_library.Patient.models.dto
{
    public class DiscoveryRequest
    {
        [JsonPropertyName("verifiedIdentifiers")]
        [XmlElement("verifiedIdentifiers")]
        public IEnumerable<Identifier> VerifiedIdentifiers { get; }

        [JsonPropertyName("unverifiedIdentifiers")]
        [XmlElement("unverifiedIdentifiers")]
        public IEnumerable<Identifier> UnverifiedIdentifiers { get; }

        [JsonPropertyName("firstName")]
        [XmlElement("firstName")]
        public string FirstName { get; }

        [JsonPropertyName("lastName")]
        [XmlElement("lastName")]
        public string LastName { get; }

        [JsonPropertyName("gender")]
        [XmlElement("gender")]
        public string Gender { get; }

        [JsonPropertyName("dob")]
        [XmlElement("dob")]
        public DateTime DateOfBirth { get; }

        public DiscoveryRequest(IEnumerable<Identifier> verifiedIdentifiers,
            IEnumerable<Identifier> unverifiedIdentifiers, string firstName, string lastName, string gender,
            DateTime dateOfBirth)
        {
            VerifiedIdentifiers = verifiedIdentifiers;
            UnverifiedIdentifiers = unverifiedIdentifiers;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }
    }
}