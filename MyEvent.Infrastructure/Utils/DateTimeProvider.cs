using MyEvent.Application.Common.Interfaces.Utils;

namespace MyEvent.Infrastructure.Utils;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.Now;
}