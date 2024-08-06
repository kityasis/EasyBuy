using System.Configuration;

namespace EasyBuy
{
    public static class ConnectionClass
    {
        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
