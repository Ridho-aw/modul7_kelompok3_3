using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JurnalModul7
{
    internal class DataMahasiswa103082400005
    {
        public class DataMahasiswa
        {
            public class AddressDetail
            {
                [JsonPropertyName("streetAddress")]
                public string StreetAddress {  get; set; }
                
                [JsonPropertyName("city")]
                public string City { get; set; }
                
                [JsonPropertyName("state")]
                public string State { get; set; }

            }

            public class Course
            {
                [JsonPropertyName("code")]
                public string Code { get; set; }
                [JsonPropertyName("name")]
                public string Name { get; set; }
            }

            [JsonPropertyName("firstName")]
            public string FirstName { get; set; }
            [JsonPropertyName("lastName")]
            public string LastName { get; set; }
            [JsonPropertyName("gender")]
            public string Gender { get; set; }
            [JsonPropertyName("age")]
            public int Age {  get; set; }

            [JsonPropertyName("address")]
            public AddressDetail Address { get; set; }
            [JsonPropertyName("courses")]
            public List<Course> Courses { get; set; }

        }

        public static void ReadJSON()
        {
            string stringJson = File.ReadAllText("../../../jurnal7_1_103082400005.json");

            try
            {
                DataMahasiswa dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(stringJson);

                Console.WriteLine($"Nama: {dataMahasiswa.FirstName} {dataMahasiswa.LastName}" +
                    $"\nGender: {dataMahasiswa.Gender}" +
                    $"\nUmur: {dataMahasiswa.Age}" +
                    $"\nAlamat: {dataMahasiswa.Address.StreetAddress}" +
                    $"\nKota: {dataMahasiswa.Address.City}" +
                    $"\nProvinsi: {dataMahasiswa.Address.State}" +
                    $"\n\nKursus Yang Diambil: ");
                for (int i = 0; i < dataMahasiswa.Courses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {dataMahasiswa.Courses[i].Code} - {dataMahasiswa.Courses[i].Name}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Gagal memuat JSON: {ex.Message}");
            }
        }



    }
}
