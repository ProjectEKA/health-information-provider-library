using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Response
{
    public class ErrorResponse
    {
        [JsonPropertyName("error")]
        [XmlElement("error")]
        public Error Error { get; }

        public ErrorResponse(Error error)
        {
            Error = error;
        }
    }
}