namespace hip_library.Patient.models
{
    public enum ErrorCode
    {
        NoPatientFound = 1,
        MultiplePatientsFound = 2,
        CareContextNotFound = 3,
        OtpInValid = 4,
        OtpExpired = 5
    }
}