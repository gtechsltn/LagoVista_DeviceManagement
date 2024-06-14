﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LagoVista.IoT.DeviceManagement.Models
{
    public class DeviceStatus
    {
        public const string DeviceStatus_New = "New";
        public const string DeviceStatus_Online = "Online";
        public const string DeviceStatus_TimeedOut = "Timed Out";

        public string DeviceId { get; set; }
        public string DeviceUniqueId { get; set; }
        public string Timestamp { get; set; }
        public string LastContact { get; set; }
        public string LastNotified { get; set; }
        public string WatchdogCheckPoint { get; set; }
        public string PreviouStatus { get; set; }
        public string CurrentStatus { get; set; }
        public string Details { get; set; }
    }
}
