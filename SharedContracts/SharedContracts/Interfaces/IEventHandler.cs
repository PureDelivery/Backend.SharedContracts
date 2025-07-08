namespace PureDelivery.Shared.Contracts.Interfaces;

public interface IEventHandler<in T> where T : class
{
    Task Handle(T @event);
}