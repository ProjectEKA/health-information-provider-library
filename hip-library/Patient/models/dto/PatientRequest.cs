namespace hip_library.Patient.models.dto
 {
     public class PatientRequest
     {
         public string PhoneNumber { get; }
         public string FirstName { get; }
         public string LastName { get; }
         public string CaseId { get; }
 
         public PatientRequest(string phoneNumber, string firstName, string lastName, string caseId)
         {
             PhoneNumber = phoneNumber;
             FirstName = firstName;
             LastName = lastName;
             CaseId = caseId;
         }
     }
 }