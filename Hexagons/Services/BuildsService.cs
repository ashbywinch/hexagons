using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hexagons.Models;

namespace Hexagons.Services
{
    public class BuildsService : IBuildsService
    {
        public BuildsModel GetBuilds()
        {
            return new BuildsModel
            {
                Builds = new List<BuildModel>
                {
                    new BuildModel { name = "pies", score = 1 },
                    new BuildModel { name = "pies", score = 2 },
                    new BuildModel { name = "pies", score = 3 },
                    new BuildModel { name = "pies", score = 4 },
                    new BuildModel { name = "pies", score = 5 },
                    new BuildModel { name = "pies", score = 6 },
                    new BuildModel { name = "pies", score = 7 },

                }
            };
        }
    }
}
