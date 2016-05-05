
namespace EFModelsDAL.Models
{
    public class Word
    {
        public int Id { get; set; }

        public int LanguageIdOrigin { get; set; }

        public Language LanguageOrigin { get; set; }

        public int LanguageIdTranslation { get; set; }

        public Language LanguageTranslation { get; set; }

        public string OriginWord { get; set; }

        /// <summary>
        /// A word can have more than one translations. All of them shall be seved in this property.
        /// </summary>
        public string Translations { get; set; }

        /// <summary>
        /// Definitions of the word. Must be written in the language of origin.
        /// </summary>
        public string DefinitionsOrigin { get; set; }

        /// <summary>
        /// Usage examples. Must be written in the language of origin.
        /// </summary>
        public string UsageExamples { get; set; }

        public int? ContextId { get; set; }

        public Context Context { get; set; } 
    }
}
