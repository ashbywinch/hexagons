using Hexagons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hexagons.Services
{
    public interface IBuildsService
    {
        BuildsModel GetBuilds();
    }
}
