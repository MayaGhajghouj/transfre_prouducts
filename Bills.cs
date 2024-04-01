using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transfre_prouduct_ramya_hw
{
    internal class Bills 
    {
        protected int bill_id;
        protected String bill_date;
        protected int car_id;
        protected String driver_name;
        protected double driver_rate;
        protected double company_rate;

        public Bills(int bill_id, string bill_date, int car_id, string driver_name, double driver_rate, double company_rate)
        {
            this.bill_id = bill_id;
            this.bill_date = bill_date;
            this.car_id = car_id;
            this.driver_name = driver_name;
            this.driver_rate = driver_rate;
            this.company_rate = company_rate;
        }
    }
}
