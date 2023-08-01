namespace SuaApi
{
    public interface IApplicationBuilder
    {
        void UseAuthorization();
        void UseDeveloperExceptionPage();
        void UseEndpoints(Action<object> value);
        void UseRouting();
    }
}