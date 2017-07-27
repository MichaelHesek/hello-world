namespace HelloWorld.Domain.Services
{
    public interface IBaseService
    {
        ModelManager ModelManager { get; }
        ServiceManager ServiceManager { get; }
    }
}