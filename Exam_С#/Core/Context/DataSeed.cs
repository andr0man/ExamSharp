using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Context
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            _seedDictionary(builder);
            _seedWord(builder);
            _seedTraslations(builder);
        }

        private static void _seedDictionary(ModelBuilder builder)
        {
            var dictionary = new MyDictionary
            {
                Id = 1,
                Type = "англо-український"
            };

            builder.Entity<MyDictionary>().HasData(dictionary);
        }        

        private static void _seedWord(ModelBuilder builder)
        {
            var word = new Word
            {
                Id = 1,
                Value = "Traslation",
                DictionaryId = 1,
            };

            builder.Entity<Word>().HasData(word);
        }
        private static void _seedTraslations(ModelBuilder builder)
        {
            var translations = new List<Translation>
            {
                new Translation { Id = 1, Value = "Процес перекладу", WordId = 1 },
                new Translation { Id = 2, Value = "Пояснення", WordId = 1 },
                new Translation { Id = 3, Value = "Переміщення", WordId = 1 }
            };

            builder.Entity<Translation>().HasData(translations);
        }
    }
}
