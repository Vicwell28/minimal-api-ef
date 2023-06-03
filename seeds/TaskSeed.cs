using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api_ef.Models;

namespace minimal_api_ef.seeds
{
    public static class TaskSeed
    {
        public static List<TaskApi> GetListTaskSeed()
        {
            return new List<TaskApi>() {
                new TaskApi() {
                    TaskId = Guid.Parse("a04766b0-9690-4ca5-8321-9c73cfc8f331"),
                    CategoryId = Guid.Parse("2450798d-1abd-4e84-a66c-3df24301986d"),
                    Titulo = "Titulo 1",
                    Priority = Priority.Alta,
                    Create_at = DateTime.UtcNow
                },
                new TaskApi() {
                    TaskId = Guid.Parse("26cd13ec-bf25-419e-84c9-6808609f5b1e"),
                    CategoryId = Guid.Parse("dbbf016e-758d-42d8-b8d1-347e42a0dde2"),
                    Titulo = "Titulo 2",
                    Priority = Priority.Baja,
                    Create_at = DateTime.UtcNow
                },
                new TaskApi() {
                    TaskId = Guid.Parse("1a848752-ec55-4f80-a7c1-3e2ad963e89e"),
                    CategoryId = Guid.Parse("dc61a01f-237e-4f7f-8ab2-47b51d5bf3f9"),
                    Titulo = "Titulo 3",
                    Priority = Priority.Media,
                    Create_at = DateTime.UtcNow
                },
                new TaskApi() {
                    TaskId = Guid.Parse("f1f86554-0df6-4e67-b8d3-3db051d4091c"),
                    CategoryId = Guid.Parse("1a9d1516-1a96-4413-8084-9fc82b28ab44"),
                    Titulo = "Titulo 4",
                    Priority = Priority.Baja,
                    Create_at = DateTime.UtcNow
                },
            };
        }
    }
}