using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Request

{
    public class PatientLinkRequest
    {
        public string Token { get; }
        public PatientLinkRequest(string token)
        {
            Token = token;
        }
    }
}