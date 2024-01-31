namespace MyEvent.Application.Common.Interfaces.Utils;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}