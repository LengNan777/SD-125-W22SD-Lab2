using SD_125_W22SD_Lab2.Data;

namespace SD_125_W22SD_Lab2.Models
{
    public class ParkingHelper

    {

        private ParkingContext parkingContext;

        public ParkingHelper(ParkingContext context)

        {

            this.parkingContext = context;

        }

        public Pass CreatePass(string purchaser, bool premium, int capacity)

        {
            try
            {
                if(purchaser.Length<3 || purchaser.Length>20 || capacity <= 0)
                {
                    throw new ArgumentException();
                }

                Pass newPass = new Pass();

                newPass.Purchaser = purchaser;

                newPass.Premium = premium;

                newPass.Capacity = capacity;

                parkingContext.Passes.Add(newPass);

                parkingContext.SaveChanges();

                return newPass;
            }
            catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return null;
        }

        public ParkingSpot CreateParkingSpot()

        {

            ParkingSpot newSpot = new ParkingSpot();

            newSpot.Occupied = false;

            parkingContext.ParkingSpots.Add(newSpot);

            return newSpot;

        }

    }
}
