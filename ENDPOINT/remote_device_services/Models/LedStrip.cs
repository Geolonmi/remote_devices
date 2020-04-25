namespace remote_device_services.Models
{
    public class LedStrip : RemoteDevice
    {
        public LedStrip() : base() { }

        public int MinBrightness { get; set; }
        public int MaxBrightness { get; set; }
    }
}