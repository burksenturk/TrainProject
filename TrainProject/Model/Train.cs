using System.Collections.Generic;
using TrainProject.Controllers;

namespace TrainProject.Model
{
    public class Train
    {
        public string Name { get; set; }
        public List<Coach> Coaches { get; set; }
    }
}
