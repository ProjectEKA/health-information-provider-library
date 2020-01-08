using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Model.Request
{
    public class DiscoveryRequest
    {
        [JsonPropertyName("patient")]
        [XmlElement("patient")]
        public Patient Patient { get; }

        [JsonPropertyName("transactionId")]
        [XmlElement("transactionId")]
        public string TransactionId { get; }

        public DiscoveryRequest(Patient patient, string transactionId)
        {
            Patient = patient;
            TransactionId = transactionId;
        }
    }
}