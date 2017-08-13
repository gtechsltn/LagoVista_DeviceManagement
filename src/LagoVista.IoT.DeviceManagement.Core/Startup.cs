﻿using LagoVista.IoT.DeviceManagement.Core.Managers;
using LagoVista.IoT.DeviceManagement.Core.Reporting;
using Microsoft.Extensions.DependencyInjection;

namespace LagoVista.IoT.DeviceManagement.Core
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IDeviceGroupManager, DeviceGroupManager>();
            services.AddTransient<IDeviceManager, DeviceManager>();
            services.AddTransient<IDeviceManagerRemote, DeviceManager>();
            services.AddTransient<IDevicePEMManager, DevicePEMManager>();
            services.AddTransient<IDeviceLogManager, DeviceLogManager>();                        
            services.AddTransient<IDeviceRepositoryManager, DeviceRepositoryManager>();
            services.AddTransient<IDeviceArchiveReportUtils, DeviceArchiveReportUtils>();

            services.AddTransient<IDeviceManagerRemote, DeviceManager>();
            services.AddTransient<IDeviceArchiveManager, DeviceArchiveManager>();
            services.AddTransient<IDeviceArchiveManagerRemote, DeviceArchiveManager>();
            services.AddTransient<IDeviceRepositoryManagerRemote, DeviceRepositoryManager>();
        }
    }
}
