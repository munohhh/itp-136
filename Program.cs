namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
         {
            namespace ConsoleApp12
    {
        internal class Program
        {
            static void Main(string[] args)
             {
                int choice;
                char patientType;
                char labs;
                double total = 0.0;

                Console.WriteLine("Please choose the type of doctor visit:");
                Console.WriteLine("1. Doctor – Sick Appointment");
                Console.WriteLine("2. Doctor – Check-up");
                Console.Write("Enter your choice (1 or 2): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                }
                Console.Write("Is the patient a child (C) or an adult (A)? ");
                patientType = Convert.ToChar(Console.ReadLine().ToUpper());

                if (patientType == 'C')
                {
                    total = 50.00;
                }
                else if (patientType == 'A')
                {
                    total = 75.00;
                }
                else
                {
                    Console.WriteLine("Invalid patient type!");
                    return;
                }
                Console.Write("Did the patient have labs done (Y/N)? ");
                labs = Convert.ToChar(Console.ReadLine().ToUpper());
                if (labs == 'Y')
                {
                    total += 25.00;
                }
                Console.WriteLine($"Total cost for the Sick Appointment: {total:C}");
                break;
                Console.Write("Is the patient a child (C) or an adult (A)? ");
                patientType = Convert.ToChar(Console.ReadLine().ToUpper());
                if (patientType == 'C')
                {
                    total = 75.00;
                }
                else if (patientType == 'A')
                {
                    total = 100.00;
                }
                else
                {
                    Console.WriteLine("Invalid patient type!");
                    return;
                }
                Console.WriteLine($"Total cost for the Check-up: {total:C}");
                break;
                default:
                    Console.WriteLine("Invalid choice!");
                break;
            }





        }
    }
}
