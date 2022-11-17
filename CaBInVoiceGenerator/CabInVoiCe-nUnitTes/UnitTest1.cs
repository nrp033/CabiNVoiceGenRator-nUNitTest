using CaBInVoiceGenerator;

namespace CabInVoiCe_nUnitTes
{
    public class Tests
    {
        //Test Case 1 Given Distance and Time when Analyse should Return Fare
        [Test]
        public void GivenDistanceAndTime_ShouldReturnFare()
        {
            //Creating Instance of Invoice Generator For Normal Ride
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            double distance = 12.0;
            int time = 10;

            //Calculating Fare
            double fare = invoice.CalculateFare(distance, time);
            double expected = 130;         //(12.0 x 10)+10 = 120+10 = 130

            //Asserting Values
            Assert.AreEqual(expected, fare);
        }


        [Test]
        public void GivenMultipleRides_ShouldReturnInvoiceSummary()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(12, 10), new Ride(8, 25) };

            InvoiceSummary summary = new InvoiceSummary(2, 235);             //no of rides=2,   and totalfare=130+105=235
            InvoiceSummary expectedSummary = invoice.CalculateFare(rides);
            Assert.AreEqual(summary, expectedSummary);
        }

    }
}