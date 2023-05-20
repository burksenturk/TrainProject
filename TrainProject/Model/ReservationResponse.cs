using System.Collections.Generic;
using TrainProject.Controllers;

namespace TrainProject.Model
{
    public class ReservationResponse
    {
        public bool ReservationPossible { get; set; }
        public List<SeatingDetail> SeatingDetails { get; set; }
    }
}
