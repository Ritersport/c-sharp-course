namespace Strategy;

public interface IStrategy : IServiceProvider
{
    object? IServiceProvider.GetService(Type serviceType)
    {
        throw new NotImplementedException();
    }

    int GetCardNumber();
}