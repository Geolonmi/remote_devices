using System;

namespace remote_device_services.Models
{
    public abstract class BaseEntity
    {
        public BaseEntity() { }
        public BaseEntity(BaseEntity baseEntity)
        {
            Id = baseEntity.Id;
            CreatedAt = baseEntity.CreatedAt;
            UpdatedAt = baseEntity.UpdatedAt;
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
