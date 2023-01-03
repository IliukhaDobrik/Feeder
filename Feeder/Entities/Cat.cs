using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class Cat
    {
        public Guid CatId { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
    }
}
