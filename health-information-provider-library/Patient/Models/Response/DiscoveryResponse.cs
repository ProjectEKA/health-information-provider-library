using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Response
{
    public class DiscoveryResponse
    {
        [JsonPropertyName("patient")]
        [XmlElement("patient")]
        public Patient Patient { get; }

        [JsonPropertyName("transactionId")]
        [XmlElement("transactionId")]
        public string TransactionId { get; }

        public DiscoveryResponse(Patient patient, string transactionId)
        {
            Patient = patient;
            TransactionId = transactionId;
        }
    }
}