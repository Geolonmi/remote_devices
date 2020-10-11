namespace remote_device_data.Models
{
    public class LedStrip : RemoteDevice
    {
        public LedStrip() : base() { }

        public int MinBrightness { get; set; }
        public int MaxBrightness { get; set; }
    }
}