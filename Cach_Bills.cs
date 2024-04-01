using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transfre_prouduct_ramya_hw
{
    internal class Cach_Bills : Bills
    {
        double weight;
        double distance;
        double rent_for_1km;
       public double full_rent { get; set; }

        public Cach_Bills(int bill_id, string bill_date, int car_id, string driver_name, double driver_rate, double company_rate, double weight, double distance, double rent_for_1km, double full_rent)
            : base(bill_id, bill_date, car_id, driver_name, driver_rate, company_rate)
        {
            this.weight = weight;
            this.distance = distance;
            this.rent_for_1km = rent_for_1km;
            this.full_rent = calcFullRent();
        }

        public virtual double calcFullRent()
        {
            double additionalRentForDistance = 0;// to store the additional rent based on distance
            double additionalRentForWeight = 0;// to store the additional rent based on wweight
            double difference = 0;// to calc the actual value of distance
            this.full_rent =this.rent_for_1km *this.distance;

            if (this.distance >=0 && this.distance <= 25.0)
                return this.full_rent;

            else if (this.distance >= 26 && this.distance < 60)//calc the additional rent for distance between 26km to 60km
            {
                difference = 60 - this.distance;// example : the distance is 40 so 60-40 is 20
                additionalRentForDistance = difference * 10000; // now  we calc 20 * 10000 to calc additional rent based on distance
                if (this.weight > 1000)
                {
                    additionalRentForWeight = weight * 1000; // calc  additional rent based on wieght
                }
                return additionalRentForDistance + additionalRentForWeight + this.full_rent;
            }
            else {
                difference = this.distance - 60; // calc actually distance
                additionalRentForDistance = difference * 12000;
                if (this.weight > 1200)
                {
                    additionalRentForWeight = weight * 1500; // calc  additional rent based on wieght
                }
                return additionalRentForDistance + additionalRentForWeight + this.full_rent;
            }
        }

        public double earningDriverCachBill()//what the driver earrn from this Cach bill
        {

            return driver_rate * full_rent;
        }

        public double earningCompanyCachBill()//what the Company earrn from this Cach bill
        {

            return company_rate * full_rent; 
        }

    }
}
