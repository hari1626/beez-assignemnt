using System;

namespace electric_bill
{
    class electric_bill
    {
        static void Main(string[] args)
        {
            int loop = 0;
            do
            {
                int CustomerId, UsedUnits;
                double charge, surcharge = 0, GrantAmount, netamount;
                string CostumerName;

                Console.Write("CALCULATING THE ELECTRICITY BILL\n");
                Console.Write("----------------------------\n");
                Console.Write("Enter the customer ID: ");
                CustomerId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the name of the customer: ");
                CostumerName = Console.ReadLine();
                Console.Write("Input the unit used by the customer:");
                UsedUnits = Convert.ToInt32(Console.ReadLine());

                if (UsedUnits < 200)
                {
                    charge = 1.20;
                }
                else if (UsedUnits >= 200 && UsedUnits < 400)
                {
                    charge = 1.50;
                }
                else if (UsedUnits >= 400 && UsedUnits < 600)
                {
                    charge = 1.80;
                }
                else
                {
                    charge = 2.00;
                }
                GrantAmount = UsedUnits * charge;
                if (GrantAmount > 300)
                    surcharge = GrantAmount * 15 / 100.0;
                netamount = GrantAmount + surcharge;
                if (netamount < 100)
                    netamount = 100;
                Console.WriteLine("\nElectricity Bill");
                Console.WriteLine("----------------------");
                Console.WriteLine("Customer IDNO                       :{0}", CustomerId);
                Console.WriteLine("Customer Name                       :{0} ", CostumerName);
                Console.WriteLine("unit Consumed                       :{0}", UsedUnits);
                Console.WriteLine("Amount Charges @Rs. {0}  per unit :{1}", charge, GrantAmount);
                Console.WriteLine("Surchage Amount                     :{0}", surcharge);
                Console.WriteLine("Net Amount Paid By the Customer     :{0}", netamount);
                Console.WriteLine("Press 1 to continue");
                loop = Convert.ToInt32(Console.ReadLine());




            } while (loop == 1);

        }
    }
}