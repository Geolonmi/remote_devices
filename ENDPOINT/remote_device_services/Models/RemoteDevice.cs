﻿namespace remote_device_services.Models
{
    public abstract class RemoteDevice : BaseEntity
    {
        public RemoteDevice() : base() { }

        public string Name { get; set; }
        public string HostName { get; set; }
    }
}
