using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace hip_library.Patient.models.domain
{
    public class Patient
    {
        [JsonPropertyName("referenceNumber")]
        [XmlElement("referenceNumber")]
        public string ReferenceNumber { get; }

        [JsonPropertyName("name")]
        [XmlElement("name")]
        public Name Name { get; }
        
        [JsonPropertyName("gender")]
        [XmlElement("gender")]
        public string Gender { get; }

        [JsonPropertyName("email")]
        [XmlElement("email")]
        public string Email { get; }

        [JsonPropertyName("phoneNumber")]
        [XmlElement("phoneNumber")]
        public string PhoneNumber { get; }

        [JsonPropertyName("dob")]
        [XmlElement("dob")]
        public DateTime DateOfBirth { get; }

        [JsonPropertyName("careContexts")]
        [XmlElement("careContexts")]
        public IEnumerable<CareContext> CareContexts { get; }

        public Patient(string referenceNumber, Name name, string gender, string email, string phoneNumber,
            DateTime dateOfBirth, IEnumerable<CareContext> careContexts)
        {
            ReferenceNumber = referenceNumber;
            Name = name;
            Gender = gender;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            CareContexts = careContexts;
        }
    }
}