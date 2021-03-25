using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Color:IEntity
    {
        public int colorId { get; set; }
        public string colorName { get; set; }

    }
}
