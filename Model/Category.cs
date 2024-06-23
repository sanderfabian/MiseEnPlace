using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiseEnPlace.Model
{
    public class Category
    {
        public string Name { get; set; }

        public List<string> Items { get; set; }

        public Color Color { get; set; }
        public string Image { get; set; }
    }
}
