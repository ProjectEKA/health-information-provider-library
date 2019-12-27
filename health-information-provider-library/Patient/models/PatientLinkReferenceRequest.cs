using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace hip_library.Patient.models.dto
{
    public class PatientLinkReferenceRequest
    {
        [JsonPropertyName("patientReferenceNumber")]
        [XmlElement("patientReferenceNumber")]
        public String PatientReferenceNumber { get; }
        
        [JsonPropertyName("careContexts")]
        [XmlElement("careContexts")]
        public IEnumerable<CareContext> CareContexts { get; }

        public PatientLinkReferenceRequest(string patientReferenceNumber, IEnumerable<CareContext> careContexts)
        {
            PatientReferenceNumber = patientReferenceNumber;
            CareContexts = careContexts;
        }
    }
}