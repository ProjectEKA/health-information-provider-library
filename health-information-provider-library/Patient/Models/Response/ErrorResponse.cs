namespace HipLibrary.Patient.Models.Response
{
    public class ErrorResponse
    {
        public Error Error { get; }

        public ErrorResponse(Error error)
        {
            Error = error;
        }
    }
}