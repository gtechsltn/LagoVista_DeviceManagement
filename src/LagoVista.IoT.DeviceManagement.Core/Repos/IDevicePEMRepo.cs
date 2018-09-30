﻿using LagoVista.Core.Models.UIMetaData;
using LagoVista.IoT.DeviceManagement.Core.Models;
using System.Threading.Tasks;

namespace LagoVista.IoT.DeviceManagement.Core.Repos
{
    public interface IDevicePEMRepo
    {
        Task<string> GetPEMAsync(DeviceRepository deviceRepo, string deviceId, string messageId);

        Task<ListResponse<IPEMIndex>> GetPEMIndexForDeviceAsync(DeviceRepository deviceRepo, string deviceId, ListRequest request);
        Task<ListResponse<IPEMIndex>> GetPEMIndexForErrorReasonAsync(DeviceRepository deviceRepo, string errorReason, ListRequest request);
    }
}
