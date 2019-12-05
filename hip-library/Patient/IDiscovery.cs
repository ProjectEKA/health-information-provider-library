using System.Collections.Generic;
using hip_library.Patient.models.dto;

namespace hip_library.Patient
{
    public interface IDiscovery
    {
        List<models.domain.Patient> GetPatients(PatientRequest request);
    }
}