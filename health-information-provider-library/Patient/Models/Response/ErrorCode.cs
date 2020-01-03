namespace HipLibrary.Patient.Models.Response
{
    public enum ErrorCode
    {
        NoPatientFound = 1000,
        MultiplePatientsFound,
        CareContextNotFound,
        OtpInValid,
        OtpExpired
    }
}