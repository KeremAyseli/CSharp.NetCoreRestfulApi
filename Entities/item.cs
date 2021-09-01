using System;
namespace C_Web.Entities
{
    public class item
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public int Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}