using C_Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Web.Repositories
{
    public class InMemoryRepository
    {
        public readonly List<item> items = new()
        {
            new item { Id = Guid.NewGuid(), Name = "Shield", Price = 10, CreatedDate = DateTimeOffset.UtcNow },
            new item { Id = Guid.NewGuid(), Name = "Sword", Price = 8, CreatedDate = DateTimeOffset.UtcNow },
            new item { Id = Guid.NewGuid(), Name = "Health", Price = 3, CreatedDate = DateTimeOffset.UtcNow },
            new item { Id = Guid.NewGuid(), Name = "Mana", Price = 4, CreatedDate = DateTimeOffset.UtcNow }
        };
        public IEnumerable<item> Getİtems()
        {
            return items;
        }
        public item Getİtem(Guid id)
        {
            return items.Where(item => item.Id == id).FirstOrDefault();
        }
    }
}