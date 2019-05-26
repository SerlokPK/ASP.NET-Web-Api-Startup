using System.ComponentModel;
using System.Configuration;

namespace Common
{
    public class AppSettings
    {
        public static string ConnectionString => Get<string>("ConnectionString");

        private static T Get<T>(string key)
        {
            string setting = ConfigurationManager.AppSettings[key];
            if (setting == null)
            {
                throw new ConfigurationErrorsException($"Key '{key}' not found in the configuration file!");
            }

            TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
            return (T)converter.ConvertFromInvariantString(setting);
        }
    }
}
