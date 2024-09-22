

class Program
    {
       
        static string FormatCurrency(decimal value)
        {
            return string.Format("{0:C2}", value);
        }

        
        static (string Subtotal, string Tax, string GrandTotal) CalculateRepairBill(decimal oilChangeTotal, decimal tiresTotal, decimal inspectionTotal)
        {
            
            decimal subtotal = oilChangeTotal + tiresTotal + inspectionTotal;

           
            decimal taxRate = 0.06m;
            decimal taxAmount = subtotal * taxRate;

          
            decimal grandTotal = subtotal + taxAmount;

           
            return (FormatCurrency(subtotal), FormatCurrency(taxAmount), FormatCurrency(grandTotal));
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to the Repair Shop! Let's calculate your total bill.");

            try
            {
               
                Console.Write("Enter the total for oil change: ");
                decimal oilChangeTotal = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the total for tires: ");
                decimal tiresTotal = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the total for inspection: ");
                decimal inspectionTotal = Convert.ToDecimal(Console.ReadLine());

               
                var billDetails = CalculateRepairBill(oilChangeTotal, tiresTotal, inspectionTotal);

               
                Console.WriteLine($"Subtotal: {billDetails.Subtotal}");
                Console.WriteLine($"Tax (6%): {billDetails.Tax}");
                Console.WriteLine($"Grand Total: {billDetails.GrandTotal}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid decimal numbers.");
            }
        }
    }

}
}
