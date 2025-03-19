using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

public class Course
{
    public string Code { get; set; }
    public string Name { get; set; }
}

public class CoursesData
{
    public List<Course> Courses { get; set; }

    public static void ReadJSON()
    {
        string path = @"E:\Data ITTP\Perkuliahan\Semester 6\KPL\Praktikum\Praktikum4\TP\tpmodul7_kelompok_4\tp7_2_2211104015.json";
        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            var data = JsonConvert.DeserializeObject<CoursesData>(jsonData);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int index = 1;
            foreach (var course in data.Courses)
            {
                Console.WriteLine($"MK {index} {course.Code} - {course.Name}");
                index++;
            }
        }
        else
        {
            Console.WriteLine("File JSON tidak ditemukan!");
        }
    }
}


