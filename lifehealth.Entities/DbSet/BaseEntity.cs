using System.Data;

namespace lifehealth.Entities.DbSet;

public abstract class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public int Status { get; set; } = 1;

    public DateTime AddedData { get; set; } = DateTime.UtcNow;

    public DateTime UpdateData { get; set; }
}
