using System;

namespace MileageTracker.Repository.Entities
{
    public class Mileage
    {
        public int Id { get; set; }
        public DateTime DeliveryDate { get; set; }
        public double Miles { get; set; }
    }
}
