using System.Xml.Serialization;

namespace xuexiaojie
{
    public class AppSettings
    {
        private static IConfiguration appSetting = null;

        public static string GetAppSetting(string key)
        {
            var section = appSetting.GetSection(key);
            if (section != null)
            {
                return section.Value;
            }
            else
            {
                return string.Empty;
            }
        }

        public static void SetAppSetting(IConfiguration section)
        {
            appSetting = section;
        }

    }
}
