using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transfre_prouduct_ramya_hw
{
    internal class Payments
    {
        int payment_id;
        string payment_date;
        int payment_value;
        string payment_type;

        public Payments(int payment_id, string payment_date, int payment_value, string payment_type)
        {
            this.payment_id = payment_id;
            this.payment_date = payment_date;
            this.payment_value = payment_value;
            this.payment_type = payment_type;
        }
        public override string ToString()
        {
            return payment_id.ToString()+"   "+payment_date+"   "+payment_value.ToString()+"   "+payment_type+"\n";
        }
    }
}
