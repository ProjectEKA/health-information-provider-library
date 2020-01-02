using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace hip_library.Patient.models.dto
{
    public class PatientLinkReferenceResponse
    {
        [JsonPropertyName("referenceNumber")]
        [XmlElement("referenceNumber")]
        public String ReferenceNumber { get; }
        
        [JsonPropertyName("authenticationType")]
        [XmlElement("authenticationType")]
        public string AuthenticationType { get; }
        
        [JsonPropertyName("meta")]
        [XmlElement("meta")]
        public LinkReferenceMeta Meta { get; }

        public PatientLinkReferenceResponse(string referenceNumber, string authenticationType, LinkReferenceMeta meta)
        {
            ReferenceNumber = referenceNumber;
            AuthenticationType = authenticationType;
            Meta = meta;
        }
    }
}