using System;
using System.Threading.Tasks;
using hip_library.Patient.models;

namespace hip_library.Patient
{
    public interface IDiscovery
    {
        Task<Tuple<models.Patient, Error>> PatientFor(DiscoveryRequest request);
    }
}