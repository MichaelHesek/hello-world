using HelloWorld.Domain.Models;

namespace HelloWorld.Domain.Services
{
    public interface IMessageService : IBaseService
    {
        IMessage GetMessage();
    }
}