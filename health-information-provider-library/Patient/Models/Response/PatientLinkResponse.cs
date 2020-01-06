using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Response
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