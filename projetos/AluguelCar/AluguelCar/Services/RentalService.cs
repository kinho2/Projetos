using AluguelCar.Entities;
namespace AluguelCar.Services
{
    class RentalService
    {
        public double PrincePerHour { get; private set; }
        public double PrincePerDay { get; private set; }

        private ITaxService _taxService;

        public RentalService(double princePerHour, double princePerDay, ITaxService taxService)
        {
            PrincePerHour = princePerHour;
            PrincePerDay = princePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
             TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PrincePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PrincePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }

    }
}
