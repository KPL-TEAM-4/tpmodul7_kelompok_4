using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Member
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public string NIM { get; set; }
}

public class Team
{
    public List<Member> Members { get; set; }
}

//public class Program
//{
//    public static Team ReadJSON(string filePath)
//    {
//        try
//        {
//            string jsonData = File.ReadAllText(filePath);
//            Team team = JsonConvert.DeserializeObject<Team>(jsonData);
//            return team;
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error reading JSON file: {ex.Message}");
//            return null;
//        }
//    }

//    public static void Main()
//    {
//        string filePath = @"E:\Data ITTP\Perkuliahan\Semester 6\KPL\Praktikum\Praktikum5\tpmodul7_kelompok_4\jurnal7_2_2211104015.json";
//        Team team = ReadJSON(filePath);

//        if (team != null && team.Members != null)
//        {
//            Console.WriteLine("Team member list:");
//            foreach (var member in team.Members)
//            {
//                Console.WriteLine($"{member.NIM} {member.FirstName} {member.LastName} ({member.Age} {member.Gender})");
//            }
//        }
//        else
//        {
//            Console.WriteLine("No team members found.");
//        }
//    }
//}
