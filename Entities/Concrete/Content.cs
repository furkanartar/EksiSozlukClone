using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Content : IEntity
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public DateTime Date { get; set; }
        public int HeadingId { get; set; }
        public int WriterId { get; set; }
    }
}
