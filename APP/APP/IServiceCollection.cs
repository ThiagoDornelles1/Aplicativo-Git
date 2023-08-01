namespace SuaApi
{
    public interface IServiceCollection
    {
        void AddControllers();
        void AddScoped<T>(Func<object, MySqlConnection> value);
    }
}