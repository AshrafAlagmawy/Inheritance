using Inheritance;
using System;

// Employee
var employee = new Employee();
employee.SetName("Ashraf", "Alagmawy");
employee.SetBirthDate(new DateOnly(2001, 12, 21));
employee.SetBasicSalary(5000);
employee.SetTaxPercentage(15);

Console.WriteLine("Employee Data:");
Console.WriteLine("---------------");

PrintPersonDetails(employee);
Console.WriteLine($"Basic Salary:\t{employee.BasicSalary}");
Console.WriteLine($"Tax Percentage:\t{employee.TaxPercentage}");

Console.WriteLine("----------------------------------------------");

// Applicant
var applicant = new Applicant();
applicant.SetName("Emad", "Alagmawy");
applicant.SetBirthDate(new DateOnly(2005, 3, 8));

Console.WriteLine("Applicant Data:");
Console.WriteLine("---------------");

PrintPersonDetails(applicant);

//Person person = employee;
//person = applicant;

Console.ReadKey();

void PrintPersonDetails(Person person)
{
    Console.WriteLine($"Full Name:\t{person.FirstName} {person.LastName}");
    Console.WriteLine($"Birth Date:\t{person.BirthDate}");
}
