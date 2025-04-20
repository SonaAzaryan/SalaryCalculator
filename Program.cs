using System;

class Program
{
    static void Main()
    {
        Console.Write("Mutqagreq dzer ashkhatavardzy (dram): ");
        if (double.TryParse(Console.ReadLine(), out double grossSalary))
        {
            double incomeTax = grossSalary * 0.20;

            // Socialakan vchar
            double socialPayment = 0;
            if (grossSalary <= 500000)
            {
                socialPayment = grossSalary * 0.05;
            }
            else
            {
                socialPayment = grossSalary * 0.10 - 25000;
                if (socialPayment > 87500)
                {
                    socialPayment = 87500;
                }
            }

            // Droshmanishayin vchar
            double stampDuty = 0;
            if (grossSalary <= 100000)
                stampDuty = 1500;
            else if (grossSalary <= 200000)
                stampDuty = 3000;
            else if (grossSalary <= 500000)
                stampDuty = 5500;
            else if (grossSalary <= 1000000)
                stampDuty = 8500;
            else
                stampDuty = 15000;

            // Maqur ashkhatavardz
            double netSalary = grossSalary - incomeTax - socialPayment - stampDuty;

            // Արդյունք
            Console.WriteLine("\n--- Ashkhatavardzi hashvark ---");
            Console.WriteLine($"Yndhanur ashkhatavardz: {grossSalary:N0} dram");
            Console.WriteLine($"Ekamtayin hark (20%): {incomeTax:N0} dram");
            Console.WriteLine($"Socialakan vchar: {socialPayment:N0} dram");
            Console.WriteLine($"Droshmanishayin vchar: {stampDuty:N0} dram");
            Console.WriteLine($"Maqur ashkhatavardz: {netSalary:N0} dram");
        }
        else
        {
            Console.WriteLine("Khndurm em mutqagrel vaver tivy:");
        }
    }
}
