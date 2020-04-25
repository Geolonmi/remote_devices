namespace remote_device_services.Models
{
    public class LedStrip : RemoteDevice
    {
        public LedStrip() { }
        public LedStrip(LedStrip ledStrip) : base(ledStrip)
        {
            MinBrightness = ledStrip.MinBrightness;
            MaxBrightness = ledStrip.MaxBrightness;
        }

        public int MinBrightness { get; set; }
        public int MaxBrightness { get; set; }
    }
}