using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hexagons.Models
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    public class HexagonDrawer
    {
        public IEnumerable<Point> GetPoints(int howMany, int separation)
        {
            int sqrt = (int)Math.Sqrt(howMany) + 1;
            
            for(int i = 0; i < howMany; ++i)
            {
                yield return new Point { x = 20 + (i % sqrt) * separation, y = 20 + (i / sqrt) * separation };
            }
        }
        public IEnumerable<string> DrawHexagons(BuildsModel builds)
        {
            var pointy = GetPoints(builds.Builds.Count(), 25).GetEnumerator();
            foreach(var build in builds.Builds)
            {
                pointy.MoveNext();
                var s = string.Format("M {0} {1} l 0 20 l -20 0 l 0 -20 Z", pointy.Current.x, pointy.Current.y);
                yield return s;
            }
        }
    }
}
