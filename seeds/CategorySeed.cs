using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api_ef.Models;

namespace minimal_api_ef.seeds
{
    public static class CategorySeed
    {
        public static List<Category> GetListCategorySeed()
        {
            return new List<Category>{
                new Category() {
                    CategoryId = Guid.Parse("2450798d-1abd-4e84-a66c-3df24301986d"),
                    Name = "Personales",
                    Peso = 20,
                    Create_at = DateTime.UtcNow
                },
                 new Category() {
                    CategoryId = Guid.Parse("dbbf016e-758d-42d8-b8d1-347e42a0dde2"),
                    Name = "Personales",
                    Peso = 20,
                    Create_at = DateTime.UtcNow
                },
                 new Category() {
                    CategoryId = Guid.Parse("dc61a01f-237e-4f7f-8ab2-47b51d5bf3f9"),
                    Name = "Personales",
                    Peso = 20,
                    Create_at = DateTime.UtcNow
                },
                 new Category() {
                    CategoryId = Guid.Parse("1a9d1516-1a96-4413-8084-9fc82b28ab44"),
                    Name = "Personales",
                    Peso = 20,
                    Create_at = DateTime.UtcNow
                }
            };
        }
    }
}