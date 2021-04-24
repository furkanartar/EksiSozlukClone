using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Heading : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        public int WriterId { get; set; }
    }
}
