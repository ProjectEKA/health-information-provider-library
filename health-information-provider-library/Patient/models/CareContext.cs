using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace hip_library.Patient.models
{
    public class CareContext
    {
        [JsonPropertyName("referenceNumber")]
        [XmlElement("referenceNumber")]
        public string ReferenceNumber { get; }

        public CareContext(string referenceNumber)
        {
            ReferenceNumber = referenceNumber;
        }
    }
}