using Encapsulation.Invoicing;
using Encapsulation.Employment;
using System;
using Encapsulation.Calendar;
using Encapsulation.Banking;
using Encapsulation.Extra;
namespace Encapsulation;

public class Program
{
    static void Main(string[] args)
    {
        // Invoicing
        Invoice invoice1 = new Invoice("001", "Hammer", 5, 75.0);
        Console.WriteLine($"Part Number: {invoice1.PartNumber}");
        Console.WriteLine($"Part Description: {invoice1.PartDescription}");
        Console.WriteLine($"Quantity: {invoice1.Quantity}");
        Console.WriteLine($"Price per item: {invoice1.Price}");
        Console.WriteLine($"Total Invoice Amount: {invoice1.GetInvoiceAmount()}");

        Console.WriteLine("===================================================================================");

        // // Employee
        Employee employee1 = new Employee("John", "Doe", 3200.0);
        Employee employee2 = new Employee("Jane", "Doe", 3500.0);

        Console.WriteLine($"Yearly Salary of {employee1.FirstName} {employee1.LastName}: {employee1.GetYearlySalary()}");
        Console.WriteLine($"Yearly Salary of {employee2.FirstName} {employee2.LastName}: {employee2.GetYearlySalary()}");

        
        // Raise salary by 10%
        employee1.RaiseSalary(10);
        employee2.RaiseSalary(-10);
        employee2.MonthlySalary=-100;

        Console.WriteLine($"Yearly Salary after 10% raise for {employee1.FirstName} {employee1.LastName}: {employee1.GetYearlySalary()}");
        Console.WriteLine($"Yearly Salary after 10% raise for {employee2.FirstName} {employee2.LastName}: {employee2.GetYearlySalary()} {employee2.MonthlySalary}");

        Console.WriteLine("===================================================================================");
        // // Date
        Date validDate = new Date(12, 15, 2021);
        Date invalidDate = new Date(13, 32, 2021); // Ini akan diset ke 1/1/1970

        Console.WriteLine("Valid date:");
        validDate.DisplayDate();
        Console.WriteLine("Invalid date set to default:");
        invalidDate.DisplayDate();
        Console.WriteLine("===================================================================================");

        // Banking

        BankAccount account = new BankAccount("123456789", "John Doe", 1000.0);
        Console.WriteLine($"Initial balance: {account.GetBalance()}");

        account.Deposit(500.0);
        Console.WriteLine($"Balance after deposit: {account.GetBalance()} {account.AccountNumber}");

        account.Withdraw(2200.0);
        Console.WriteLine($"Balance after withdrawal: {account.GetBalance()}");

        Console.WriteLine("===================================================================================");

        // Extra
         // Membuat reservasi baru
            Reservation reservation1 = new Reservation("zaky", "101", "Suite", 150.0,4,false,false);

            // Menampilkan detail reservasi sebelum check-in
            Console.WriteLine($"Reservation for {reservation1.CustomerName} in room {reservation1.RoomNumber}, Type: {reservation1.RoomType}, Price per night: {reservation1.PricePerDay}");
            Console.WriteLine($"Total price for {reservation1.Days} nights: {reservation1.CalculateTotalPrice()}");
            // Melakukan check-in
            reservation1.DoCheckIn();
            Console.WriteLine($"{reservation1.CustomerName} has checked in from room {reservation1.RoomNumber}.");
            reservation1.DoCheckOut();
            Console.WriteLine($"{reservation1.CustomerName} has checked out from room {reservation1.RoomNumber}.");

    }
}
