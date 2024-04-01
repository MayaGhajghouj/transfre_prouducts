using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transfre_prouduct_ramya_hw
{
    internal class Forward_Bills : Cach_Bills

    {
        string customer_name;
        double discount;
       public double full_discount {  get; set; }
       static int number_trips;
        public Forward_Bills(int bill_id, string bill_date, int car_id, string driver_name,
            double driver_rate, double company_rate, double weight, double distance,
            double rent_for_1km, double full_rent, string customer_name, double discount,
            double full_discount) : base(bill_id, bill_date, car_id, driver_name,
                driver_rate, company_rate, weight, distance, rent_for_1km, full_rent)
        {
            this.customer_name = customer_name;
            this.discount = discount;
            number_trips++;
            // when object created the number_trips will increase +1 because 
            // we want to use in calcFullDiscount
            this.full_discount = calcFullDiscount(number_trips);
        }
        public override double calcFullRent()
        {
            return base.calcFullRent();
        }
        public double calcFullDiscount(int numberOfTrips) 
        {
            if (numberOfTrips == 2)
            {
                return this.discount + 10 / 100;
            }
            else if (numberOfTrips == 3)
            {
                return this.discount + 15 / 100;
            }
            else if(numberOfTrips >3)
            {
                return this.discount + 20 / 100;
            }
            else return this.discount;
        }

        public double earningDriverForwardBill()//what the driver earrn from this Forward bill
        {
            // calc the full rent after discount then calc the earning of driver 

           double billAfteerDiscount= full_rent-(full_rent * full_discount);

            return driver_rate * billAfteerDiscount;
        }

        public double earningCompanyForward()//what the Company earrn from this forward bill
        {
            // calc the full rent after discount then calc the earning of company
            
            double billAfteerDiscount = full_rent - (full_rent * full_discount);

            return company_rate * billAfteerDiscount;
        }

    }
}
