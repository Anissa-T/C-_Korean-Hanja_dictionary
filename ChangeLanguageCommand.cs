namespace KoreanHanjaDictionary
{
    public class ChangeLanguageCommand
    {
        private readonly LocalizationService localizationService;
        private readonly string newLang;

        public ChangeLanguageCommand(LocalizationService localizationService, string newLang)
        {
            this.localizationService = localizationService;
            this.newLang = newLang;
        }

        public void Execute()
        {
            localizationService.ChangeLanguage(newLang);
        }
    }
}