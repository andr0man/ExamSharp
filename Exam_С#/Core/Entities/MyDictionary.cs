using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MyDictionary
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<Word>? Words { get; set; }
    }
}
