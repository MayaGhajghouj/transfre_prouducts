using transfre_prouduct_ramya_hw;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nPlease enter the number of cach trip from date 1-11-2023 to 30-11-2023\n");
        int numberOfCashTrips = int.Parse(Console.ReadLine());

        Cach_Bills[] myCaachBills = new Cach_Bills[numberOfCashTrips];

        double companyRentFromCachForwardBills = 0;// sum of full_rent for all bills entred 
        double driverEarningFromCachForwardBills = 0;// calc the driver earning using rate for all bills entred
        double CompanyEarn = 0;  // calc the company earning using rate for  all bills entred

        // the Bills attribute will entred from user in forward and cach  bills :
        int billId;
        string billDate;
        string driverName;
        int carId;
        double driverRate;
        double companyRate;

        for (int i = 0; i < myCaachBills.Length; i++)
        {
            Console.WriteLine("\n\tinformation cach trip number : {0} \n", i + 1);

            Console.WriteLine("enter BILL ID ");
            billId = int.Parse(Console.ReadLine());

            Console.WriteLine("enter BILL DATE ");
            billDate = Console.ReadLine();

            Console.WriteLine("enter CAR ID ");
            carId = int.Parse(Console.ReadLine());

            Console.WriteLine("enter DRIVER NAME ");
            driverName = Console.ReadLine();

            Console.WriteLine("enter DRIVER RATE ");
            driverRate = double.Parse(Console.ReadLine());

            Console.WriteLine("enter COMPANY RATE ");
            companyRate = double.Parse(Console.ReadLine());

            Console.WriteLine("enter WEIGHT (kg)");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("enter distance (km)");
            double distance = double.Parse(Console.ReadLine());

            Console.WriteLine("enter rent_for_1km");
            double rent_for_1km = double.Parse(Console.ReadLine());

            myCaachBills[i] = new Cach_Bills(billId, billDate, carId, driverName, driverRate, companyRate,
                weight, distance, rent_for_1km, 0);

            companyRentFromCachForwardBills += myCaachBills[i].full_rent;
            driverEarningFromCachForwardBills += myCaachBills[i].earningDriverCachBill();
            CompanyEarn += myCaachBills[i].earningCompanyCachBill();
            Console.WriteLine("\nthe full rent of cach bill number {0} is {1}", i + 1, myCaachBills[i].full_rent);


        }
        // finish cach bills 


        Console.WriteLine("\nPlease enter the number of forward trip from date 1-11-2023 to 30-11-2023\n");
        int numberOfForwardTrips = int.Parse(Console.ReadLine());

        Forward_Bills[] myForwardBills = new Forward_Bills[numberOfForwardTrips];

        double sumOfDiscount = 0;// sum of full discount for all trips that entred from user

        for (int i = 0; i < myForwardBills.Length; i++)
        {
            Console.WriteLine("\n\tinformation forward trip number : {0} \n", i + 1);

            Console.WriteLine("enter BILL ID ");
            billId = int.Parse(Console.ReadLine());

            Console.WriteLine("enter BILL DATE ");
            billDate = Console.ReadLine();

            Console.WriteLine("enter CAR ID ");
            carId = int.Parse(Console.ReadLine());

            Console.WriteLine("enter DRIVER NAME ");
            driverName = Console.ReadLine();

            Console.WriteLine("enter DRIVER RATE ");
            driverRate = double.Parse(Console.ReadLine());

            Console.WriteLine("enter COMPANY RATE ");
            companyRate = double.Parse(Console.ReadLine());

            Console.WriteLine("enter WEIGHT (kg)");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("enter distance (km)");
            double distance = double.Parse(Console.ReadLine());

            Console.WriteLine("enter rent_for_1km");
            double rent_for_1km = double.Parse(Console.ReadLine());

            Console.WriteLine("enter customer name");
            string customer_name = Console.ReadLine();

            Console.WriteLine("enter discount");
            double discount = double.Parse(Console.ReadLine());

            myForwardBills[i] = new Forward_Bills(billId, billDate, carId, driverName, driverRate, companyRate,
                weight, distance, rent_for_1km, 0,
                customer_name, discount, 0);

            sumOfDiscount += myForwardBills[i].full_discount;
            companyRentFromCachForwardBills += myForwardBills[i].full_rent;
            driverEarningFromCachForwardBills += myForwardBills[i].earningDriverForwardBill();
            CompanyEarn += myForwardBills[i].earningCompanyForward();

            Console.WriteLine("\nthe full rent of forward bill number {0} is {1}", i + 1, myForwardBills[i].full_rent);

        }
        Console.WriteLine("\n full discount for forward bills : {0}                ", sumOfDiscount);
        // finish forward bills

        // results : 
        Console.WriteLine("\n\n\t\t");
        Console.WriteLine("\n full company rent for cach & forward bills : {0}     ", companyRentFromCachForwardBills);
        Console.WriteLine("\n full driver rent for cach & forward bills : {0}      ", driverEarningFromCachForwardBills);
        Console.WriteLine("\n full company earning for cach & forward bills : {0}  ", CompanyEarn);
        Console.WriteLine("\n\n");


        Console.WriteLine("\nPlease enter the number of payment from date 1-11-2023 to 30-11-2023\n");
        int numberOfPayments = int.Parse(Console.ReadLine());

        Payments[] myPayments = new Payments[numberOfPayments];

        for (int i = 0; i < myPayments.Length; i++)
        {
            Console.WriteLine("\n\tinformation payment number : {0} \n", i + 1);

            Console.WriteLine("enter payment_id");
           int payment_id = int.Parse(Console.ReadLine());

            Console.WriteLine("enter payment_date");
           string payment_date = Console.ReadLine();

            Console.WriteLine("enter payment_value");
            int payment_value = int.Parse(Console.ReadLine());

            Console.WriteLine("enter payment_type");
            string payment_type = Console.ReadLine();

            myPayments[i] = new Payments(payment_id, payment_date, payment_value, payment_type);
        }

        for (int i = 0; i < myPayments.Length; i++)
        {
            Console.Write("\n\tinformation payment number : {0} is\t{1}", i + 1, myPayments[i].ToString());
        }


    }
}