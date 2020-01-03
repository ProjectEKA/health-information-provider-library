using System;
using System.Threading.Tasks;
using HipLibrary.Patient.Models.Request;
using HipLibrary.Patient.Models.Response;

namespace HipLibrary.Patient
{
    public interface IDiscovery
    {
        Task<Tuple<DiscoveryResponse, Error>> PatientFor(DiscoveryRequest request);
    }
}