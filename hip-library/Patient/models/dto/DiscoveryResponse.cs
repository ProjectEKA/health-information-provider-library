using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace hip_library.Patient.models.dto
 {
     public class DiscoveryResponse
     {
         [JsonPropertyName("patients")]
         [XmlElement("patients")]
         public IEnumerable<domain.Patient> Patients { get; }

         public DiscoveryResponse(IEnumerable<domain.Patient> patients)
         {
             Patients = patients;
         }
     }
 }