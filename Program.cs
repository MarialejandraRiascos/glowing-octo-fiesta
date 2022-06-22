using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Est_Evaluación
{
    internal class Program
    {
        Data myData = new Data();
        public void CalculatePayroll()
        {
            try
            {
                Console.WriteLine("Document: ");
                myData.document = double.Parse(Console.ReadLine());
                Console.WriteLine("FirstName: ");
                myData.firstName = (Console.ReadLine());
                Console.WriteLine("LastName: ");
                myData.lastName = (Console.ReadLine());
                Console.WriteLine("Salary: ");
                myData.salary = double.Parse(Console.ReadLine());
                Console.WriteLine("WorkedDays: ");
                myData.workedDays = double.Parse(Console.ReadLine());
            }
            catch (FormatException m)
            {
                Console.WriteLine("Not valid.\nEnter a numerical value", m);
                Console.ReadKey();
            }

            myData.totalAccrued = myData.salary / 30;
            myData.totalAccrued = myData.totalAccrued * myData.workedDays;

            myData.transportSubsidy = 117172 / 30;
            myData.transportSubsidy = myData.transportSubsidy * myData.workedDays;

            myData.healt = myData.totalAccrued * 0.04;
            myData.pension = myData.totalAccrued * 0.04;

            if (myData.salary <= 2000000)
            {
                myData.totalAccrued = myData.totalAccrued + myData.transportSubsidy;
            }
            else
            {
                myData.totalAccrued = myData.totalAccrued;
            }
        }
        public void ToPrintData()
        {
            StreamWriter Write = File.AppendText("Payroll.txt");
            Write.WriteLine($"Document: {myData.document}");
            Write.WriteLine($"FirstName: {myData.firstName}");
            Write.WriteLine($"LastName: {myData.lastName}");
            Write.WriteLine($"Salary: {myData.salary}");
            Write.WriteLine($"WorkedDays: {myData.workedDays}");
            Write.WriteLine($"TotalAccrued: {myData.totalAccrued}");
            Write.WriteLine($"TransportSubsidy: {myData.transportSubsidy}");
            Write.WriteLine($"Healt: {myData.healt}");
            Write.WriteLine($"Pension: {myData.pension}");
            Write.Close();
        }
    }

}