using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace hip_library.Patient.models.dto
{
    public class PatientLinkReferenceResponse
    {
        [JsonPropertyName("linkReferenceNumber")]
        [XmlElement("linkReferenceNumber")]
        public String LinkReferenceNumber { get; }
        
        [JsonPropertyName("authenticationType")]
        [XmlElement("authenticationType")]
        public AuthenticationType AuthenticationType { get; }
        
        [JsonPropertyName("meta")]
        [XmlElement("meta")]
        public LinkReferenceMeta Meta { get; }

        public PatientLinkReferenceResponse(string linkReferenceNumber, AuthenticationType authenticationType, LinkReferenceMeta meta)
        {
            LinkReferenceNumber = linkReferenceNumber;
            AuthenticationType = authenticationType;
            Meta = meta;
        }
    }
}