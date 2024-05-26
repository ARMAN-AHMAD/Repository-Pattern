using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRepositoryPattern.BusinessLeyer;
using TestRepositoryPattern.DataAccessLeyer;

namespace TestRepositoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            DonorBusiness donorBusiness = new DonorBusiness(new DonorRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'A' for Add, 'U' for Update 'D' for Delete, 'S' for Search,'C' for Clear, 'X' for Exit");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Donor> _listDonor =  donorBusiness.Get();
                        Console.WriteLine("List of Donor:");
                        Console.WriteLine("ID   |   Name    |   Address");
                        foreach (Donor _Donor in _listDonor)
                        {
                            Console.WriteLine(_Donor.DonorId + "  |   " + _Donor.DonorName + "  |   " + _Donor.DonorAddress);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a id to find a Donor:");
                        string id = Console.ReadLine();
                        Donor aDonor =  donorBusiness.Get(Convert.ToInt32(id));
                        Console.WriteLine(aDonor.DonorId + ". " + aDonor.DonorName + " -- " + aDonor.DonorAddress);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Donor aDonor = new Donor();
                        aDonor.DonorId = Convert.ToInt32(id);
                        aDonor.DonorName = name;
                        aDonor.DonorAddress = address;
                        bool isExecuted =  donorBusiness.Add(aDonor);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Donor aDonor = new Donor();
                        aDonor.DonorId = Convert.ToInt32(id);
                        aDonor.DonorName = name;
                        aDonor.DonorAddress = address;
                        bool isExecuted =  donorBusiness.Update(aDonor);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        bool isExecuted =  donorBusiness.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            Console.ReadKey();
        }

    }
}
