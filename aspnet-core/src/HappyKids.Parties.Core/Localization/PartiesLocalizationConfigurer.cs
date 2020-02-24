using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HappyKids.Parties.Localization
{
    public static class PartiesLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PartiesConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PartiesLocalizationConfigurer).GetAssembly(),
                        "HappyKids.Parties.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
