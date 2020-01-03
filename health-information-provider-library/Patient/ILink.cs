using System;
using System.Threading.Tasks;
using HipLibrary.Patient.Models.Request;
using HipLibrary.Patient.Models.Response;

namespace HipLibrary.Patient
{
    public interface ILink
    {
        Task<Tuple<PatientLinkReferenceResponse, Error>> LinkPatients(PatientLinkReferenceRequest request);
        Task<Tuple<PatientLinkResponse, Error>> VerifyAndLinkCareContext(PatientLinkRequest request);
    }
}