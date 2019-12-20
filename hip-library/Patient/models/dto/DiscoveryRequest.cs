namespace hip_library.Patient.models.dto
 {
     public class DiscoveryRequest
     {
         public string PhoneNumber { get; }
         public string FirstName { get; }
         public string LastName { get; }
         public string ContextReferenceNumber { get; }
 
         public DiscoveryRequest(string phoneNumber, string firstName, string lastName, string contextReferenceNumber)
         {
             PhoneNumber = phoneNumber;
             FirstName = firstName;
             LastName = lastName;
             ContextReferenceNumber = contextReferenceNumber;
         }
     }
 }