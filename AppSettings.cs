namespace NoteMaster
{
    public class AppSettings
    {
        public const string ConfigurationSectionName = "AppSettings";

        public IWritableOptions<AppSettings> Options;

        public AppSettings()
        {
        }

        public AppSettings(IWritableOptions<AppSettings> options)
        {
            Options = options;
        }

        public string DataFilePath { get; set; }
    }
}