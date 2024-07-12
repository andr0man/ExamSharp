using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Word
    {
        public int Id { get; set; }
        public string Value { get; set; } = string.Empty;

        [ForeignKey(nameof(Dictionary))]
        public int DictionaryId { get; set; }
        public MyDictionary? Dictionary { get; set; }
        public ICollection<Translation>? Translations { get; set; }
    }
}
