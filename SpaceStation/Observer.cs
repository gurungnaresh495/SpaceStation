using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    public interface Observer
    {
        int Location { get; set; }
        void updatePrice(List<Product> prodList);
    }
}
