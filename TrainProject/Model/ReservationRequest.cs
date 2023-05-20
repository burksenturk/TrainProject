namespace TrainProject.Model
{

    public class ReservationRequest
    {
        public Train Train { get; set; }
        public int PassengerCount { get; set; }
        public bool AllowPassengerSeparation { get; set; }
    }
}
