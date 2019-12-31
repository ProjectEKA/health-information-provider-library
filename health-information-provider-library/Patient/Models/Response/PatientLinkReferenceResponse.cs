using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Response
{
    public class PatientLinkReferenceResponse
    {
        [JsonPropertyName("linkReferenceNumber")]
        [XmlElement("linkReferenceNumber")]
        public String LinkReferenceNumber { get; }

        [JsonPropertyName("authenticationType")]
        [XmlElement("authenticationType")]
        public string AuthenticationType { get; }

        [JsonPropertyName("meta")]
        [XmlElement("meta")]
        public LinkReferenceMeta Meta { get; }

        public PatientLinkReferenceResponse(string linkReferenceNumber, string authenticationType,
            LinkReferenceMeta meta)
        {
            LinkReferenceNumber = linkReferenceNumber;
            AuthenticationType = authenticationType;
            Meta = meta;
        }
    }
}