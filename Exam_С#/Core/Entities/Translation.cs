using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Translation
    {
        public int Id { get; set; }
        public string Value { get; set; }

        [ForeignKey(nameof(Word))]
        public int WordId { get; set; }
        public Word? Word { get; set; }
    }
}
