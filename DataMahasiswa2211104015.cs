using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
}

public class Course
{
    public string Code { get; set; }
    public string Name { get; set; }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }
    public List<Course> Courses { get; set; }
}

//public class Program
//{
//    public static void ReadJSON()
//    {
//        string path = @"E:\Data ITTP\Perkuliahan\Semester 6\KPL\Praktikum\Praktikum5\tpmodul7_kelompok_4\jurnal7_1_2211104015.json";
//        if (File.Exists(path))
//        {
//            string jsonData = File.ReadAllText(path);
//            var person = JsonConvert.DeserializeObject<Person>(jsonData);

//            Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
//            Console.WriteLine($"Gender: {person.Gender}");
//            Console.WriteLine($"Age: {person.Age}");
//            Console.WriteLine($"Address: {person.Address.StreetAddress}, {person.Address.City}, {person.Address.State}");
//            Console.WriteLine("Courses:");
//            foreach (var course in person.Courses)
//            {
//                Console.WriteLine($"  - {course.Code}: {course.Name}");
//            }
//        }
//        else
//        {
//            Console.WriteLine("File JSON tidak ditemukan!");
//        }
//    }

//    public static void Main()
//    {
//        ReadJSON();
//    }
//}
