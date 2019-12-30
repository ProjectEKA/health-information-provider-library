using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace health_information_provider_library.Patient.models
{
    public class PatientLinkRequest
    {
        [JsonPropertyName("token")]
        [XmlElement("token")]
        public string Token { get; }

        public PatientLinkRequest(string token)
        {
            this.Token = token;
        }
    }
    
}