using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Response
{
    public class PatientLinkReferenceResponse
    {
        [JsonPropertyName("link")]
        [XmlElement("link")]
        public LinkReference Link { get; }
        
        public PatientLinkReferenceResponse(LinkReference link)
        {
            Link = link;
        }
    }
}