using System;
using System.Threading.Tasks;
using HipLibrary.Patient.Model.Request;
using HipLibrary.Patient.Model.Response;

namespace HipLibrary.Patient
{ 
    public interface ILink
    {
        Task<Tuple<PatientLinkReferenceResponse, ErrorResponse>> LinkPatients(PatientLinkReferenceRequest request);
        Task<Tuple<PatientLinkResponse, ErrorResponse>> VerifyAndLinkCareContext(PatientLinkRequest request);
    }
}