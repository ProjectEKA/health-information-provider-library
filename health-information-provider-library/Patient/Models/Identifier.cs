using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models
{
    public class Identifier
    {
        [JsonPropertyName("type")]
        [XmlElement("type")]
        public IdentifierType Type { get; }

        [JsonPropertyName("value")]
        [XmlElement("value")]
        public string Value { get; }

        public Identifier(IdentifierType type, string value)
        {
            Type = type;
            Value = value;
        }
    }
}