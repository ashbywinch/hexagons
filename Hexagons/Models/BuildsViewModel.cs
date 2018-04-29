using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hexagons.Models
{
    public class BuildViewModel
    {
        public string Tooltip { get; set; }
        public string Score { get; set; }
        public string Path { get; set; }

    }
    public class BuildsViewModel
    {
        public List<BuildViewModel> Builds { get; set; }
    }
}
