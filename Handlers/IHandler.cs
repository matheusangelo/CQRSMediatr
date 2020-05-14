using Mediatr.Commands;

namespace Mediatr.Handlers
{
    public interface IHandler<T> where T : class
    {
        CreateCustomerResult handle(T command);
    }
}