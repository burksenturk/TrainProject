using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TrainProject.Model;

namespace TrainProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        [HttpPost]
        public ActionResult<ReservationResponse> PostReservation(ReservationRequest request)
        {
            Train train = request.Train;
            List<Coach> coaches = train.Coaches;

            int passengerCount = request.PassengerCount;
            bool allowPassengerSeparation = request.AllowPassengerSeparation;

            bool reservationPossible = false;
            List<SeatingDetail> seatingDetails = new List<SeatingDetail>();

            if (allowPassengerSeparation)
            {
                foreach (var coach in coaches)
                {
                    if (coach.OccupiedSeats + passengerCount <= coach.Capacity)
                    {
                        reservationPossible = true;
                        seatingDetails.Add(new SeatingDetail
                        {
                            CoachName = coach.Name,
                            PassengerCount = passengerCount
                        });

                        coach.OccupiedSeats += passengerCount;

                        if (seatingDetails.Sum(s => s.PassengerCount) >= passengerCount)
                            break;
                    }
                }
            }
            else
            {
                Coach targetCoach = coaches.FirstOrDefault(c => c.OccupiedSeats + passengerCount <= c.Capacity);

                if (targetCoach != null)
                {
                    reservationPossible = true;
                    seatingDetails.Add(new SeatingDetail
                    {
                        CoachName = targetCoach.Name,
                        PassengerCount = passengerCount
                    });

                    targetCoach.OccupiedSeats += passengerCount;
                }
            }

            ReservationResponse response = new ReservationResponse
            {
                ReservationPossible = reservationPossible,
                SeatingDetails = seatingDetails
            };

            return Ok(response);
        }
    }
}
