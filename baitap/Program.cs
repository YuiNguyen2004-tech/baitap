using baitap;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<student> students = new List<student>
        {
            new student (1, "Nguyen Thanhh Huy", 15),
            new student (2, "Nguyen Mong Khang", 16),
            new student (3, "Tran Van Hung", 18),
            new student (4, "Nguyen Thi Nhat Thanh", 22),
            new student (5, "Alex Cuong Nguyen", 23)
        };

        Console.WriteLine("Danh sach toan bo hoc sinh:");

        foreach (student Student in students)
        {
            Console.WriteLine(Student.ToString());
        }

        var tuoitu15den18 = students.Where(s => s.age >= 15 && s.age <= 18).ToList();

        Console.WriteLine("\nDanh sach hoc sinh co do tuoi tu 15 den 18:");

        foreach (var student in tuoitu15den18)
        {
            Console.WriteLine(student.ToString());
        }

        var studentsNameStartingWith = students.Where(s => s.name.StartsWith("A")).ToList();

        Console.WriteLine("\nDanh sach hoc sinh o ten bat dau bang chu A:");

        foreach (var student in studentsNameStartingWith)
        {
            Console.WriteLine(student.ToString());
        }

        int totalAge = students.Sum(s => s.age);
        Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh la: {totalAge}");

        var tuoilonnhat = students.OrderByDescending(s => s.age).First();
        Console.WriteLine($"\nHoc sinh co tuoi lon nhat: \n{tuoilonnhat} ");

        var tuoitangdan = students.OrderBy(s => s.age).ToList();
        Console.WriteLine("\nDanh sach hoc sinh co do tuoi tang dan: ");
        foreach(var student in tuoitangdan) { 
            Console.WriteLine(student.ToString()); 
        }
  }
}