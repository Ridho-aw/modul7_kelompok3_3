using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.IO;
using System.Text.Json;

public class alamat
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}

public class Courses 
{
    public string code { get; set; }
    public string name { get; set; }
}
public class DataMahasiswa103082400024
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public alamat address { get; set; }
    public List<Courses> courses { get; set; }

    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal_1_103082400024.json");
        DataMahasiswa103082400024 data = JsonSerializer.Deserialize<DataMahasiswa103082400024>(jsonString);

        Console.WriteLine($"Nama Lengkap: {data.firstName} {data.lastName}");
        Console.WriteLine($"Nama Depan: {data.firstName}");
        Console.WriteLine($"Nama Belakang: {data.lastName}");
        Console.WriteLine($"Jenis Kelamin: {data.gender}");
        Console.WriteLine($"Umur: {data.age}");
        Console.WriteLine($"alamat: {data.address.streetAddress}, {data.address.city}, {data.address.state}");
        Console.WriteLine("Mata kuliah yang diambil:");
        for (int i = 0; i < data.courses.Count; i++)
        {
            Console.WriteLine($"MK {i + 1}. {data.courses[i].code} - {data.courses[i].name}");
        }
    }
}
