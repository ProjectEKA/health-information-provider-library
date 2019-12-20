using hip_library.Patient.models.dto;

namespace hip_library.Patient
{
    public interface IDiscovery
    {
        DiscoveryResponse DiscoverPatients(DiscoveryRequest request);
    }
}