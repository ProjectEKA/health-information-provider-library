using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Response
{
    public class LinkPatient
    {
        
        [JsonPropertyName("referenceNumber")]
        [XmlElement("referenceNumber")]
        public string ReferenceNumber { get; }
        
        [JsonPropertyName("display")]
        [XmlElement("display")]
        public string Display { get; }

        [JsonPropertyName("careContexts")]
        [XmlElement("careContexts")]
        public IEnumerable<CareContextRepresentation> CareContexts { get; }

        public LinkPatient(string referenceNumber, string display, IEnumerable<CareContextRepresentation> careContexts)
        {
            ReferenceNumber = referenceNumber;
            Display = display;
            CareContexts = careContexts;
        }
    }
}