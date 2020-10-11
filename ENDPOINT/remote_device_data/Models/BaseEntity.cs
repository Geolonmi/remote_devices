using System;

namespace remote_device_data.Models
{
    public abstract class BaseEntity
    {
        public BaseEntity() { }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
