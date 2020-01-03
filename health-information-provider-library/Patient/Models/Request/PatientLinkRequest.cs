using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Request
{
    public class PatientLinkRequest
    {
        [JsonPropertyName("token")]
        [XmlElement("token")]
        public string Token { get; }

        public PatientLinkRequest(string token)
        {
            Token = token;
        }
    }
}