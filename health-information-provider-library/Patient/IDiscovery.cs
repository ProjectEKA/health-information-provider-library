using System;
using System.Threading.Tasks;
using HipLibrary.Patient.Model.Request;
using HipLibrary.Patient.Model.Response;

namespace HipLibrary.Patient
{
    public interface IDiscovery
    {
        Task<Tuple<DiscoveryResponse, ErrorResponse>> PatientFor(DiscoveryRequest request);
    }
}