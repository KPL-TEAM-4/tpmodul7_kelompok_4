using System;
using System.IO;
using Newtonsoft.Json;

public class Nama
{
    public string Depan { get; set; }
    public string Belakang { get; set; }
}

public class DataMahasiswa
{
    public Nama Nama { get; set; }  // Properti Nama sebagai objek
    public string NIM { get; set; }
    public string Fakultas { get; set; }

    public static void ReadJSON()
    {
        string path = @"E:\Data ITTP\Perkuliahan\Semester 6\KPL\Praktikum\Praktikum4\TP\tpmodul7_kelompok_4\tp7_1_2211104015.json";
        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            var mahasiswa = JsonConvert.DeserializeObject<DataMahasiswa>(jsonData);

            Console.WriteLine($"Nama {mahasiswa.Nama.Depan} {mahasiswa.Nama.Belakang} dengan NIM {mahasiswa.NIM} dari fakultas {mahasiswa.Fakultas}");
        }
        else
        {
            Console.WriteLine("File JSON tidak ditemukan!");
        }
    }
}
