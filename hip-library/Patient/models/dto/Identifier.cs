using System.Text.Json.Serialization;
 using System.Xml.Serialization;
 
 namespace hip_library.Patient.models.dto
 {
     public class Identifier
     {
         [JsonPropertyName("type")]
         [XmlElement("type")]
         public string Type { get; }
 
         [JsonPropertyName("value")]
         [XmlElement("value")]
         public string Value { get; }
 
         public Identifier(string type, string value)
         {
             Type = type;
             Value = value;
         }
     }
 }