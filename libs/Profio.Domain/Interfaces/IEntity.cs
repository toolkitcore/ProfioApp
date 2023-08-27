namespace Profio.Domain.Interfaces;
public interface IEntity<out T> where T : notnull
{
  public T Id { get; }
}
