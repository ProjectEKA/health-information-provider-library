using System;
using System.Threading.Tasks;
using hip_library.Patient.models;
using hip_library.Patient.models.dto;

namespace hip_library.Patient
{
    public interface ILink
    {
        Task<Tuple<PatientLinkReferenceResponse, Error>> LinkPatients(PatientLinkReferenceRequest request);
    }
}