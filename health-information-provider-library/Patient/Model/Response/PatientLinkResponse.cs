using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Model.Response
{
    public class PatientLinkResponse
    {
        [JsonPropertyName("patient")]
        [XmlElement("patient")]
        public LinkPatient Patient { get; }

        public PatientLinkResponse(LinkPatient patient)
        {
            Patient = patient;
        }
    }
}